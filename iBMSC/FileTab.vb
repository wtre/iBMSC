Imports System.Linq
Imports iBMSC.Editor

Partial Public Class MainWindow
    ' BMS File tabs
    Dim BMSFileStructs As BMSStruct()
    Dim BMSFileIndex As Integer = 0
    Dim BMSFileList(-1) As String ' {"G:\LR2Making\Zekk_MEJIRUSHI_V2_ogg\MEJIRUSHI_14GLITCH - Copy.bms", "G:\LR2Making\Zekk_MEJIRUSHI_V2_ogg\MEJIRUSHI_14GLITCH.bms", "G:\LR2Making\[NoE]間隙を縫う\_kanngekiAnother.bms"}
    Dim BMSFileTSBList As ToolStripButton()

    Structure BMSStruct
        Public Notes() As Note
        Public NotesTemplate() As Note
        Public hWAV() As String
        Public hBPM() As Long
        Public hSTOP() As Long
        Public hBMSCROLL() As Long
        Public hCOM() As String
        Public wLWAV() As WavSample
        Public HeaderT() As String ' Text
        Public HeaderN() As Decimal ' Numeric
        Public HeaderI() As Integer ' Integer
        Public Expansion As String
        Public MeasureLength() As Double

        Public ExpansionSplit() As String
        Public GhostMode As Integer

        Public sUndo() As UndoRedo.LinkedURCmd
        Public sRedo() As UndoRedo.LinkedURCmd
        Public sI As Integer

        Public IsSaved As Boolean
        Public WaveformLoaded As Boolean
        Public ExpansionEnabled As Boolean

        Public Sub New(xNotes() As Note, xNotesTemplate() As Note,
                       xWAV() As String, xBPM() As Long, xSTOP() As Long, xBMSCROLL() As Long, xCOM() As String, xLWAV() As WavSample,
                       xHeaderT() As String, xHeaderN() As Decimal, xHeaderI() As Integer, xExpansion As String, xMeasureLength() As Double,
                       xExpansionSplit() As String, xGhostMode As Integer,
                       xUndo() As UndoRedo.LinkedURCmd, xRedo() As UndoRedo.LinkedURCmd, xSI As Integer,
                       xIsSaved As Boolean, xWaveformLoaded As Boolean, xExpansionEnabled As Boolean)

            Notes = xNotes
            NotesTemplate = xNotesTemplate
            hWAV = xWAV
            hBPM = xBPM
            hSTOP = xSTOP
            hBMSCROLL = xBMSCROLL
            hCOM = xCOM
            wLWAV = xLWAV
            HeaderT = xHeaderT
            HeaderN = xHeaderN
            HeaderI = xHeaderI
            Expansion = xExpansion
            MeasureLength = xMeasureLength

            ExpansionSplit = xExpansionSplit
            GhostMode = xGhostMode

            sUndo = xUndo
            sRedo = xRedo
            sI = xSI

            IsSaved = xIsSaved
            WaveformLoaded = xWaveformLoaded
            ExpansionEnabled = xExpansionEnabled
        End Sub
    End Structure

    Private Sub TBClose_Click(sender As Object, e As EventArgs) Handles mnClose.Click
        If ClosingPopSave() Then Exit Sub

        If BMSFileIndex = UBound(BMSFileList) Or BMSFileIndex = -1 Then TBNew_Click(Nothing, Nothing) : Exit Sub

        Dim xITemp As Integer = BMSFileIndex
        TBTab_Click(BMSFileTSBList(BMSFileIndex + 1), New EventArgs)

        RemoveBMSFile(xITemp)
        SetBMSFileIndex(xITemp)
    End Sub

    Private Sub TBTab_Click(sender As Object, e As EventArgs)
        Dim TSBS As ToolStripButton = CType(sender, ToolStripButton)
        If TSBS.Checked Then Exit Sub

        ' If Not IsSaved Then
        '     Dim xResult As MsgBoxResult = MsgBox(Strings.Messages.SaveOnExit, MsgBoxStyle.YesNoCancel Or MsgBoxStyle.Question, Me.Text)
        '     If xResult = MsgBoxResult.Yes Then
        '         TBSave_ButtonClick(Nothing, Nothing)
        '     ElseIf xResult = MsgBoxResult.No Then
        '         SetIsSaved(True)
        '     Else
        '         Exit Sub
        '     End If
        ' End If
        SaveBMSStruct()

        SetBMSFileIndex(Array.IndexOf(BMSFileTSBList, TSBS))

        If BMSFileStructs(BMSFileIndex).Notes IsNot Nothing Then
            SetFileName(BMSFileList(BMSFileIndex))
            LoadBMSStruct(BMSFileIndex)
        Else
            If BMSFileList(BMSFileIndex) = FileNameInit Then
                TBNew_Click(Nothing, Nothing)
            Else
                ReadFile(BMSFileList(BMSFileIndex))
            End If
        End If

        ' If BMSFileList(BMSFileIndex) = FileNameInit Then
        '     TBNew_Click(Nothing, Nothing)
        ' Else
        '     If BMSFileStructs(BMSFileIndex).Notes IsNot Nothing Then
        '         SetFileName(BMSFileList(BMSFileIndex))
        '         LoadBMSStruct()
        '     Else
        '         ReadFile(BMSFileList(BMSFileIndex))
        '     End If
        ' End If
    End Sub

    Private Sub TBTab_MouseDown(sender As Object, e As MouseEventArgs)
        Dim xITemp = BMSFileIndex
        Dim xExit As Boolean = False

        If e.Button = MouseButtons.Middle Then
            Dim xIClicked = Array.IndexOf(BMSFileTSBList, CType(sender, ToolStripButton))
            If xIClicked < BMSFileIndex Then
                If Not BMSStructIsSaved(xIClicked) Then
                    TBTab_Click(BMSFileTSBList(xIClicked), New EventArgs)
                    ' If ClosingPopSave() Then Exit Sub
                    xExit = ClosingPopSave()
                    TBTab_Click(BMSFileTSBList(xITemp), New EventArgs)
                    If xExit Then Exit Sub
                End If
                RemoveBMSFile(xIClicked)
                SetBMSFileIndex(BMSFileIndex - 1)

            ElseIf xIClicked = BMSFileIndex Then
                TBClose_Click(sender, New EventArgs)

            ElseIf xIClicked <> UBound(BMSFileList) Then
                If Not BMSStructIsSaved(xIClicked) Then
                    TBTab_Click(BMSFileTSBList(xIClicked), New EventArgs)
                    ' If ClosingPopSave() Then Exit Sub
                    ClosingPopSave()
                    xExit = ClosingPopSave()
                    TBTab_Click(BMSFileTSBList(xITemp), New EventArgs)
                    If xExit Then Exit Sub
                End If
                RemoveBMSFile(xIClicked)

            End If
        End If
    End Sub

    Private Sub AddUntitledBMSFileToList()
        Dim ub As Integer = UBound(BMSFileList)
        If ub <> -1 AndAlso BMSFileList(ub) = FileNameInit Then Exit Sub

        ReDim Preserve BMSFileList(ub + 1)
        BMSFileList(ub + 1) = FileNameInit
    End Sub

    Public Sub AddBMSFiles(xPaths As String())
        For xI = 0 To UBound(xPaths)
            NewRecent(xPaths(xI))
            AddBMSFileToListAndTBTabAndStruct(xPaths(xI))
        Next
    End Sub

    Private Sub AddBMSFileToListAndTBTabAndStruct(xPath As String)
        If BMSFileList.Contains(xPath) Then
            SetBMSFileIndex(Array.IndexOf(BMSFileList, xPath))

        Else
            If BMSFileIndex = UBound(BMSFileList) Then BMSFileIndex -= 1
            ReDim Preserve BMSFileList(BMSFileList.Length)
            ReDim Preserve BMSFileTSBList(BMSFileTSBList.Length)

            For xI = UBound(BMSFileList) - 1 To BMSFileIndex + 1 Step -1
                BMSFileList(xI + 1) = BMSFileList(xI)
                BMSFileTSBList(xI + 1) = BMSFileTSBList(xI)
            Next

            BMSFileIndex += 1
            ' Add to BMSFileList
            BMSFileList(BMSFileIndex) = xPath
            ' Add to BMSFileTSBList
            BMSFileTSBList(BMSFileIndex) = NewBMSTab(xPath)

            ' Re-add buttons to TBTab
            For i = 1 To TBTab.Items.Count
                TBTab.Items.RemoveAt(0)
            Next
            TBTab.Items.AddRange(BMSFileTSBList)
            SetBMSFileIndex(BMSFileIndex)

            ' Add to BMSStructs
            AddBMSStruct()
        End If
    End Sub

    Private Function NewBMSTab(xPath As String) As ToolStripButton
        Dim xTSB As New ToolStripButton
        With xTSB
            .Image = My.Resources.x16Blank
            .Name = GetFileName(xPath)
            .Text = GetFileName(xPath)
        End With
        AddHandler xTSB.Click, AddressOf TBTab_Click
        AddHandler xTSB.MouseDown, AddressOf TBTab_MouseDown
        Return xTSB
    End Function

    Private Sub RemoveBMSFile(xI As Integer)
        For i = xI To UBound(BMSFileList) - 1
            BMSFileList(i) = BMSFileList(i + 1)
            BMSFileTSBList(i) = BMSFileTSBList(i + 1)
        Next
        ReDim Preserve BMSFileList(UBound(BMSFileList) - 1)
        ReDim Preserve BMSFileTSBList(UBound(BMSFileTSBList) - 1)
        TBTab.Items.RemoveAt(xI)
        RemoveBMSStruct(xI)
    End Sub

    Private Sub SetBMSFileIndex(xI As Integer)
        BMSFileIndex = xI
        For i = 0 To UBound(BMSFileTSBList)
            If i = BMSFileIndex Then
                BMSFileTSBList(i).Checked = True
            Else
                BMSFileTSBList(i).Checked = False
            End If
        Next
    End Sub

    Private Sub SaveBMSStruct(Optional xI As Integer = -1)
        If xI = -1 Then xI = BMSFileIndex

        Dim HeaderT() As String = {THTitle.Text, THArtist.Text, THGenre.Text, THPlayLevel.Text, THTotal.Text,
                                   THSubTitle.Text, THSubArtist.Text, THStageFile.Text, THBanner.Text, THBackBMP.Text, THExRank.Text, THComment.Text}
        Dim HeaderN() As Decimal = {THBPM.Value}
        Dim HeaderI() As Integer = {CHPlayer.SelectedIndex, CHRank.SelectedIndex, CHDifficulty.SelectedIndex, CHLnObj.SelectedIndex}

        BMSFileStructs(xI) = New BMSStruct(Notes, NotesTemplate,
                                           hWAV, hBPM, hSTOP, hBMSCROLL, hCOM, wLWAV,
                                           HeaderT, HeaderN, HeaderI, TExpansion.Text, MeasureLength,
                                           ExpansionSplit, GhostMode,
                                           sUndo, sRedo, sI,
                                           IsSaved, WaveformLoaded, TExpansion.Enabled)

    End Sub

    Private Sub LoadBMSStruct(Optional xI As Integer = -1)
        If xI = -1 Then xI = BMSFileIndex

        With BMSFileStructs(xI)
            Notes = .Notes
            NotesTemplate = .NotesTemplate

            hWAV = .hWAV
            hBPM = .hBPM
            hSTOP = .hSTOP
            hBMSCROLL = .hBMSCROLL
            hCOM = .hCOM
            wLWAV = .wLWAV

            THTitle.Text = .HeaderT(0)
            THArtist.Text = .HeaderT(1)
            THGenre.Text = .HeaderT(2)
            THPlayLevel.Text = .HeaderT(3)
            THTotal.Text = .HeaderT(4)
            THSubTitle.Text = .HeaderT(5)
            THSubArtist.Text = .HeaderT(6)
            THStageFile.Text = .HeaderT(7)
            THBanner.Text = .HeaderT(8)
            THBackBMP.Text = .HeaderT(9)
            THExRank.Text = .HeaderT(10)
            THComment.Text = .HeaderT(11)

            THBPM.Value = .HeaderN(0)

            CHPlayer.SelectedIndex = .HeaderI(0)
            CHRank.SelectedIndex = .HeaderI(1)
            CHDifficulty.SelectedIndex = .HeaderI(2)
            CHLnObj.SelectedIndex = .HeaderI(3)

            TExpansion.Text = .Expansion

            MeasureLength = .MeasureLength

            ExpansionSplit = .ExpansionSplit
            GhostMode = .GhostMode

            sUndo = .sUndo
            sRedo = .sRedo
            sI = .sI

            IsSaved = .IsSaved
            WaveformLoaded = .WaveformLoaded
        End With

        If Not WaveformLoaded AndAlso ShowWaveform Then WaveformLoadId = 1 : TimerLoadWaveform.Enabled = True
        SetIsSaved(IsSaved)

        LWAVRefresh()
        LBeatRefresh()

        LoadColorOverride(FileName)
        SortByVPositionQuick(0, UBound(Notes))
        UpdateMeasureBottom()
        UpdatePairing()
        CalculateTotalPlayableNotes()
        CalculateGreatestVPosition()
        RefreshPanelAll()
        POStatusRefresh()
    End Sub

    Private Sub AddBMSStruct(Optional xI As Integer = -1)
        If xI = -1 Then xI = BMSFileIndex

        ReDim Preserve BMSFileStructs(BMSFileStructs.Length)
        For i = UBound(BMSFileStructs) - 1 To xI Step -1
            BMSFileStructs(i + 1) = BMSFileStructs(i)
        Next

        BMSFileStructs(xI) = New BMSStruct()
    End Sub

    Private Sub RemoveBMSStruct(Optional xI As Integer = -1)
        If xI = -1 Then xI = BMSFileIndex

        For i = xI To UBound(BMSFileStructs) - 1
            BMSFileStructs(i) = BMSFileStructs(i + 1)
        Next
        ReDim Preserve BMSFileStructs(UBound(BMSFileStructs) - 1)
    End Sub

    Private Function BMSStructInitialized(Optional xI As Integer = -1) As Boolean
        If xI = -1 Then xI = BMSFileIndex

        Return BMSFileStructs(xI).Notes IsNot Nothing
    End Function

    Private Function BMSStructIsSaved(Optional xI As Integer = -1) As Boolean
        If xI = -1 Then xI = BMSFileIndex

        If BMSStructInitialized(xI) Then
            Return BMSFileStructs(xI).IsSaved
        Else
            Return True
        End If
    End Function
End Class
