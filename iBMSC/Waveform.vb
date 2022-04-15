Imports CSCore.Streams
Imports CSCore.Streams.Effects
Imports CSCore
Imports CSCore.Codecs


Partial Public Class MainWindow

    '----WaveForm Options
    Dim wWavL() As Single
    Dim wWavR() As Single
    Dim wLock As Boolean = True
    Dim wSampleRate As Integer
    Dim wPosition As Double = 0
    Dim wLeft As Integer = 50
    Dim wWidth As Integer = 100
    Dim wPrecision As Integer = 1

    Private Sub BWLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BWLoad.Click
        Dim xDWAV As New OpenFileDialog
        xDWAV.Filter = "Wave files (*.wav, *.ogg)" & "|*.wav;*.ogg"
        xDWAV.DefaultExt = "wav"
        xDWAV.InitialDirectory = IIf(ExcludeFileName(FileName) = "", InitPath, ExcludeFileName(FileName))

        If xDWAV.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
        InitPath = ExcludeFileName(xDWAV.FileName)

        Dim w As WavSample = LoadWaveForm(xDWAV.FileName)
        wWavL = w.WavL
        wWavR = w.WavR
        wSampleRate = w.SampleRate
        RefreshPanelAll()

        TWFileName.Text = xDWAV.FileName
        TWFileName.Select(Len(xDWAV.FileName), 0)
    End Sub

    Private Sub BWClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BWClear.Click
        Erase wWavL
        Erase wWavR
        TWFileName.Text = "(" & Strings.None & ")"
        RefreshPanelAll()
    End Sub

    Private Sub BWLock_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BWLock.CheckedChanged
        wLock = BWLock.Checked
        TWPosition.Enabled = Not wLock
        TWPosition2.Enabled = Not wLock
        RefreshPanelAll()
    End Sub

    Private Function LoadWaveForm(ByVal filepath As String)
        filepath = Audio.CheckFilename(filepath)
        If Not System.IO.File.Exists(filepath) Then Return New WavSample({}, {}, 0, 0)

        Dim src = CSCore.Codecs.CodecFactory.Instance.GetCodec(filepath)

        src.ToStereo()
        Dim samples(src.Length) As Single
        src.ToSampleSource().Read(samples, 0, src.Length)

        Dim flen = (src.Length - 1) / src.WaveFormat.Channels

        ' Copy interleaved data
        ReDim wWavL(flen + 1)
        ReDim wWavR(flen + 1)
        For i As Integer = 0 To flen
            If 2 * i < src.Length Then
                wWavL(i) = samples(2 * i)
            End If
            If 2 * i + 1 < src.Length Then
                wWavR(i) = samples(2 * i + 1)
            End If
        Next

        Dim flenReduced As Integer
        For i = UBound(wWavL) To 0 Step -1
            If wWavL(i) = 0 AndAlso wWavR(i) = 0 Then
                flenReduced = i
            Else
                ReDim Preserve wWavL(flenReduced)
                ReDim Preserve wWavR(flenReduced)
                Exit For
            End If
        Next
        Return New WavSample(wWavL, wWavR, src.WaveFormat.SampleRate, CSng(src.GetMilliseconds(src.Length) / 1000))

    End Function

    Private Function LoadDuration(ByVal filepath As String)
        filepath = Audio.CheckFilename(filepath)
        If Not System.IO.File.Exists(filepath) Then Return 0

        Dim src = CSCore.Codecs.CodecFactory.Instance.GetCodec(filepath)

        Return New WavSample(Nothing, Nothing, 0, CSng(src.GetMilliseconds(src.Length) / 1000))
    End Function
End Class
