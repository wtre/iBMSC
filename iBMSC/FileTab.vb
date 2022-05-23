Imports System.Linq
Imports iBMSC.Editor

Partial Public Class MainWindow

    ' BMS File tabs
    ''' <summary>
    ''' Everything related to file tabs are put here.
    ''' 
    ''' BMSFileStructs is to an array of BMSStruct with each BMSStruct referring to each BMS file in the tab list.
    ''' BMSFileIndex is the current BMS file index in the tab list.
    ''' BMSFileList is the list of BMS files in the tab list.
    ''' BMSFileTSBList is the list of ToolStripButtons in the tab list.
    ''' 
    ''' Currently, Untitled.bms must be at the last of the tab list.
    ''' </summary>

    Dim BMSFileStructs As BMSStruct()
    Dim BMSFileIndex As Integer = 0
    Dim BMSFileList(-1) As String
    Dim BMSFileColor(-1) As Color
    Dim BMSFileTSBList As ToolStripButton()

    Structure BMSStruct
        Public Notes() As Note
        Public NotesTemplate() As Note
        Public hWAV() As String
        Public hBMP() As String
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
        Public FileNameTemplate As String

        Public RandomSource As String
        Public ExpansionSplit() As String
        Public GhostMode As Integer

        Public sUndo() As UndoRedo.LinkedURCmd
        Public sRedo() As UndoRedo.LinkedURCmd
        Public sI As Integer

        Public ExpansionEnabled As Boolean
        Public IsSaved As Boolean
        Public NTInput As Boolean
        Public WaveformLoaded As Boolean

        Public Sub New(xNotes() As Note, xNotesTemplate() As Note,
                       xWAV() As String, xBMP() As String, xBPM() As Long, xSTOP() As Long, xBMSCROLL() As Long, xCOM() As String, xLWAV() As WavSample,
                       xHeaderT() As String, xHeaderN() As Decimal, xHeaderI() As Integer, xExpansion As String, xMeasureLength() As Double, xFileNameTemplate As String,
                       xExpansionSplit() As String, xGhostMode As Integer,
                       xUndo() As UndoRedo.LinkedURCmd, xRedo() As UndoRedo.LinkedURCmd, xSI As Integer,
                       xExpansionEnabled As Boolean, xIsSaved As Boolean, xNTInput As Boolean, xWaveformLoaded As Boolean)

            Notes = xNotes
            NotesTemplate = xNotesTemplate
            hWAV = xWAV
            hBMP = xBMP
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
            FileNameTemplate = xFileNameTemplate

            ExpansionSplit = xExpansionSplit
            GhostMode = xGhostMode

            sUndo = xUndo
            sRedo = xRedo
            sI = xSI

            ExpansionEnabled = xExpansionEnabled
            IsSaved = xIsSaved
            NTInput = xNTInput
            WaveformLoaded = xWaveformLoaded
        End Sub

        Public Sub AddRandomSource(xPath As String)
            RandomSource = xPath
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
    End Sub

    Private Sub TBTab_MouseDown(sender As Object, e As MouseEventArgs)
        Dim xITemp = BMSFileIndex
        Dim xTSB = CType(sender, ToolStripButton)
        Dim xIClicked = Array.IndexOf(BMSFileTSBList, xTSB)

        If e.Button = MouseButtons.Middle Then
            Dim xExit As Boolean
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
                    xExit = ClosingPopSave()
                    TBTab_Click(BMSFileTSBList(xITemp), New EventArgs)
                    If xExit Then Exit Sub
                End If
                RemoveBMSFile(xIClicked)

            End If

        ElseIf e.Button = MouseButtons.Right Then
            Dim xColorPicker As New ColorPicker
            xColorPicker.SetOrigColor(xTSB.BackColor)
            If xColorPicker.ShowDialog(Me) = Windows.Forms.DialogResult.Cancel Then Exit Sub
            ColorTSBChange(xTSB, xColorPicker.NewColor)
            BMSFileColor(xIClicked) = xColorPicker.NewColor
        End If
    End Sub

    Private Sub TBTab_MouseMove(sender As Object, e As MouseEventArgs)
        Dim TSBS = CType(sender, ToolStripButton)
        Dim xITab = Array.IndexOf(BMSFileTSBList, TSBS)
        If Not BMSStructIsInitialized(xITab) Then Exit Sub
        Dim BannerDir = ExcludeFileName(BMSFileList(xITab)) & "\" & BMSFileStructs(xITab).HeaderT(8)
        If Not My.Computer.FileSystem.FileExists(BannerDir) Then
            BannerDir = ExcludeFileName(BMSFileList(xITab)) & "\" & BMSFileStructs(xITab).HeaderT(7)
            If Not My.Computer.FileSystem.FileExists(BannerDir) Then Exit Sub
        End If

        With PBOnTabHover
            .Image = New Bitmap(BannerDir)
            .Size = .Image.Size
            ' .Location = e.Location
            ' .Parent = Me
            .Visible = True
        End With
    End Sub

    Private Sub TBTab_MouseLeave(sender As Object, e As EventArgs)
        PBOnTabHover.Visible = False
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
            AddBMSFileToListAndColorAndTBTabAndStruct(xPaths(xI))
        Next
    End Sub

    Private Sub AddBMSFileToListAndColorAndTBTabAndStruct(xPath As String)
        If BMSFileList.Contains(xPath) Then
            SetBMSFileIndex(Array.IndexOf(BMSFileList, xPath))

        Else
            If BMSFileIndex = UBound(BMSFileList) AndAlso xPath <> FileNameInit Then BMSFileIndex -= 1
            ReDim Preserve BMSFileList(BMSFileList.Length)
            ReDim Preserve BMSFileTSBList(BMSFileTSBList.Length)
            ReDim Preserve BMSFileColor(BMSFileColor.Length)

            For xI = UBound(BMSFileList) - 1 To BMSFileIndex + 1 Step -1
                BMSFileList(xI + 1) = BMSFileList(xI)
                BMSFileColor(xI + 1) = BMSFileColor(xI)
                BMSFileTSBList(xI + 1) = BMSFileTSBList(xI)
            Next

            BMSFileIndex += 1
            ' Add to BMSFileList
            BMSFileList(BMSFileIndex) = xPath
            ' Add to BMSFileColor
            BMSFileColor(BMSFileIndex) = System.Drawing.SystemColors.Control
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

    Private Sub ColorTSBChange(ByVal xTSB As ToolStripButton, ByVal c As Color) ' Copied from OpPlayer
        xTSB.BackColor = c
        xTSB.ForeColor = CType(IIf(CInt(c.GetBrightness * 255) + 255 - c.A >= 128, Color.Black, Color.White), Color)
    End Sub

    Private Function NewBMSTab(xPath As String) As ToolStripButton
        Dim xTSB As New ToolStripButton
        With xTSB
            .Image = My.Resources.x16Blank
            .Name = GetFileName(xPath)
            .Text = GetFileName(xPath)
            For i = 0 To UBound(BMSFileColor)
                If BMSFileList(i) = xPath Then
                    .BackColor = BMSFileColor(i)
                    .ForeColor = CType(IIf(CInt(.BackColor.GetBrightness * 255) + 255 - .BackColor.A >= 128, Color.Black, Color.White), Color)
                End If
            Next
        End With
        AddHandler xTSB.Click, AddressOf TBTab_Click
        AddHandler xTSB.MouseDown, AddressOf TBTab_MouseDown
        AddHandler xTSB.MouseMove, AddressOf TBTab_MouseMove
        AddHandler xTSB.MouseLeave, AddressOf TBTab_MouseLeave
        Return xTSB
    End Function

    Private Sub RemoveBMSFile(xI As Integer)
        For i = xI To UBound(BMSFileList) - 1
            BMSFileList(i) = BMSFileList(i + 1)
            BMSFileColor(i) = BMSFileColor(i + 1)
            BMSFileTSBList(i) = BMSFileTSBList(i + 1)
        Next
        ReDim Preserve BMSFileList(UBound(BMSFileList) - 1)
        ReDim Preserve BMSFileColor(UBound(BMSFileColor) - 1)
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
        ' Console.WriteLine(FileName)
        ' Console.WriteLine(MeasureLength(0))
        ' If BMSFileStructs(0).MeasureLength IsNot Nothing Then Console.WriteLine("BMSStruct 0, MeasureLength 0: " & BMSFileStructs(0).MeasureLength(0))
        Dim HeaderT() As String = {THTitle.Text, THArtist.Text, THGenre.Text, THPlayLevel.Text, THTotal.Text,
                                   THSubTitle.Text, THSubArtist.Text, THStageFile.Text, THBanner.Text, THBackBMP.Text, THExRank.Text, THComment.Text}
        Dim HeaderN() As Decimal = {THBPM.Value}
        Dim HeaderI() As Integer = {CHPlayer.SelectedIndex, CHRank.SelectedIndex, CHDifficulty.SelectedIndex, CHLnObj.SelectedIndex}

        BMSFileStructs(xI) = New BMSStruct(Notes, NotesTemplate,
                                           hWAV, hBMP, hBPM, hSTOP, hBMSCROLL, hCOM, wLWAV,
                                           HeaderT, HeaderN, HeaderI, TExpansion.Text, MeasureLength, FileNameTemplate,
                                           ExpansionSplit, GhostMode,
                                           sUndo, sRedo, sI,
                                           TExpansion.Enabled, IsSaved, NTInput, WaveformLoaded)

    End Sub

    Private Sub SaveAllBMSStruct()
        For i = 0 To UBound(BMSFileList) - 1
            ReadFile(BMSFileList(i), False)
            SaveBMSStruct(i)
        Next
    End Sub

    Private Sub LoadBMSStruct(Optional xI As Integer = -1)
        If xI = -1 Then xI = BMSFileIndex

        With BMSFileStructs(xI)
            Notes = .Notes
            NotesTemplate = .NotesTemplate

            hWAV = .hWAV
            hBMP = .hBMP
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
            FileNameTemplate = .FileNameTemplate

            ExpansionSplit = .ExpansionSplit
            GhostMode = .GhostMode

            sUndo = .sUndo
            sRedo = .sRedo
            sI = .sI

            TExpansion.Enabled = .ExpansionEnabled
            IsSaved = .IsSaved
            NTInput = .NTInput
            WaveformLoaded = .WaveformLoaded
        End With

        If Not WaveformLoaded AndAlso ShowWaveform Then WaveformLoadId = 1 : TimerLoadWaveform.Enabled = True
        SetIsSaved(IsSaved)

        LWAVRefresh() ' P: Wow why does refreshing this list take so damn long
        LBMPRefresh() ' P: Likely this too
        LBeatRefresh()
        RefreshItemsByNTInput()

        LoadColorOverride(FileName)
        UpdateMeasureBottom()
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

    Private Function BMSStructIsInitialized(Optional xI As Integer = -1) As Boolean
        If xI = -1 Then xI = BMSFileIndex

        Return BMSFileStructs(xI).Notes IsNot Nothing
    End Function

    Private Function BMSStructIsSaved(Optional xI As Integer = -1) As Boolean
        If xI = -1 Then xI = BMSFileIndex

        If BMSStructIsInitialized(xI) Then
            Return BMSFileStructs(xI).IsSaved
        Else
            Return True
        End If
    End Function
End Class
