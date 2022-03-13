Public Class OpVisualOverride
    Dim COverrides() As MainWindow.ColorOverride
    Dim F As String
    Public Sub New(ByVal FileName As String)
        InitializeComponent()
        LOverrides.Items.Clear()

        F = "Colors\" + GetFileName(FileName) + ".xml"
        If Not My.Computer.FileSystem.FileExists(F) Then Exit Sub

        Dim Doc As New XmlDocument
        Dim FileStream As New IO.FileStream(F, FileMode.Open, FileAccess.Read)
        Doc.Load(FileStream)

        Dim Root As XmlElement = Doc.Item("ColorOverride")
        Dim n As Integer = Root.GetAttribute("Count")
        If n = -1 Then FileStream.Close() : IO.File.Delete(F) : Exit Sub
        ReDim COverrides(n)
        Dim i As Integer
        For Each eColor As XmlElement In Root.ChildNodes
            With eColor
                XMLLoadAttribute(.GetAttribute("Index"), i)
                XMLLoadAttribute(.GetAttribute("Name"), COverrides(i).Name)
                XMLLoadAttribute(.GetAttribute("RangeL"), COverrides(i).RangeL)
                XMLLoadAttribute(.GetAttribute("RangeU"), COverrides(i).RangeU)
                XMLLoadAttribute(.GetAttribute("NoteColor"), COverrides(i).NoteColor)
                XMLLoadAttribute(.GetAttribute("TextColor"), COverrides(i).TextColor)
                XMLLoadAttribute(.GetAttribute("LongNoteColor"), COverrides(i).LongNoteColor)
                XMLLoadAttribute(.GetAttribute("LongTextColor"), COverrides(i).LongTextColor)
                XMLLoadAttribute(.GetAttribute("BG"), COverrides(i).BG)
            End With
        Next
        FileStream.Close()

        ' List expansion code per line
        For Each COverride In COverrides
            LOverrides.Items.Add(COverride.Name)
        Next

        LOverrides.SelectedIndex = 0
        ShowInTextbox()
    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        DialogResult = DialogResult.OK
        Me.Close()
        If IsNothing(COverrides) Then Exit Sub

        Dim w As New XmlTextWriter(F, System.Text.Encoding.Unicode)
        With w
            .WriteStartDocument()
            .Formatting = Formatting.Indented
            .Indentation = 4

            .WriteStartElement("ColorOverride")
            .WriteAttributeString("Count", UBound(COverrides))

            For i = 0 To UBound(COverrides)
                .WriteStartElement("Color")
                .WriteAttributeString("Index", i)
                .WriteAttributeString("Name", COverrides(i).Name)
                .WriteAttributeString("RangeL", COverrides(i).RangeL)
                .WriteAttributeString("RangeU", COverrides(i).RangeU)
                .WriteAttributeString("NoteColor", COverrides(i).NoteColor)
                .WriteAttributeString("TextColor", COverrides(i).TextColor)
                .WriteAttributeString("LongNoteColor", COverrides(i).LongNoteColor)
                .WriteAttributeString("LongTextColor", COverrides(i).LongTextColor)
                .WriteAttributeString("BG", COverrides(i).BG)
                .WriteEndElement()
            Next

            .WriteEndElement()
            .WriteEndDocument()
            .Close()
        End With
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub BAdd_Click(sender As Object, e As EventArgs) Handles BAdd.Click
        If IsNothing(COverrides) Then
            ReDim COverrides(0)
        Else
            ReDim Preserve COverrides(UBound(COverrides) + 1)
        End If
        With COverrides(UBound(COverrides))
            .Name = "New Item"
            .RangeL = "01"
            .RangeU = "02"
            .NoteColor = "0"
            .LongNoteColor = "0"
            .LongTextColor = "0"
            .BG = "0"
        End With

        LOverrides.Items.Insert(LOverrides.Items.Count, "New Item")
        LOverrides.SelectedIndex = UBound(COverrides)
        ShowInTextbox()
    End Sub

    Private Sub BRemove_Click(sender As Object, e As EventArgs) Handles BRemove.Click
        If LOverrides.SelectedIndex = -1 Then Exit Sub

        For i = LOverrides.SelectedIndex To UBound(COverrides) - 1
            COverrides(i) = COverrides(i + 1)
        Next
        ReDim Preserve COverrides(UBound(COverrides) - 1)

        LOverrides.Items.RemoveAt(LOverrides.SelectedIndex)
    End Sub

    Private Sub ShowInTextbox() ' Referenced OpPlayer
        With COverrides(LOverrides.SelectedIndex)
            TName.Text = .Name
            TRangeL.Text = C10to36(.RangeL)
            TRangeU.Text = C10to36(.RangeU)
            BColor.Text = .NoteColor
            cButtonChange(BColor, Color.FromArgb(.NoteColor))
        End With

    End Sub

    Private Function GetFileName(ByVal s As String) As String ' Copied from MainWindow
        Dim fslash As Integer = InStrRev(s, "/")
        Dim bslash As Integer = InStrRev(s, "\")
        Return Mid(s, IIf(fslash > bslash, fslash, bslash) + 1)
    End Function

    Private Sub SaveCOverride(sender As Object, e As KeyEventArgs) Handles TName.KeyUp, TRangeL.KeyUp, TRangeU.KeyUp
        With COverrides(LOverrides.SelectedIndex)
            .Name = TName.Text
            .RangeL = C36to10(TRangeL.Text)
            .RangeU = C36to10(TRangeU.Text)
        End With
        If [Object].ReferenceEquals(sender, TName) Then LOverrides.Items.Item(LOverrides.SelectedIndex) = TName.Text
    End Sub

    Private Sub BColor_Click(sender As Object, e As EventArgs) Handles BColor.Click
        Dim xColorPicker As New ColorPicker
        xColorPicker.SetOrigColor(BColor.BackColor)
        If xColorPicker.ShowDialog(Me) = Windows.Forms.DialogResult.Cancel Then Exit Sub
        cButtonChange(BColor, xColorPicker.NewColor)
        COverrides(LOverrides.SelectedIndex).NoteColor = xColorPicker.NewColor.ToArgb
    End Sub

    Private Sub cButtonChange(ByVal xbutton As Button, ByVal c As Color) ' Copied from OpPlayer
        xbutton.Text = Hex(c.ToArgb)
        xbutton.BackColor = c
        xbutton.ForeColor = IIf(CInt(c.GetBrightness * 255) + 255 - c.A >= 128, Color.Black, Color.White)
    End Sub

    ' Below are copied from Utilities
    Public Function C10to36S(ByVal xStart As Integer) As Char
        If xStart < 10 Then Return CChar(CStr(xStart)) Else Return Chr(xStart + 55)
    End Function
    Public Function C36to10S(ByVal xChar As Char) As Integer
        Dim xAsc As Integer = Asc(UCase(xChar))
        If xAsc >= 48 And xAsc <= 57 Then
            Return xAsc - 48
        ElseIf xAsc >= 65 And xAsc <= 90 Then
            Return xAsc - 55
        End If
        Return 0
    End Function
    Public Function C10to36(ByVal xStart As Long) As String
        If xStart < 1 Then xStart = 1
        If xStart > 1295 Then xStart = 1295
        Return C10to36S(xStart \ 36) & C10to36S(xStart Mod 36)
    End Function
    Public Function C36to10(ByVal xStart As String) As Integer
        xStart = Mid("00" & xStart, Len(xStart) + 1)
        Return C36to10S(xStart.Chars(0)) * 36 + C36to10S(xStart.Chars(1))
    End Function

    Private Sub LOverrides_Click(sender As Object, e As EventArgs) Handles LOverrides.Click
        If IsNothing(COverrides) Or LOverrides.SelectedIndex = -1 Then Exit Sub
        ShowInTextbox()
    End Sub
End Class