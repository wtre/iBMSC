Public Class OpVisualOverride
    Public COverrides() As MainWindow.ColorOverride
    Dim F As String
    Public Sub New(ByVal xColorOverrides() As MainWindow.ColorOverride)
        InitializeComponent()
        LOverrides.Items.Clear()

        COverrides = xColorOverrides

        If Not IsNothing(COverrides) Then
            ' List expansion code per line
            For Each COverride In COverrides
                LOverrides.Items.Add(COverride.Name)
            Next

            If COverrides.Length > 0 Then
                LOverrides.SelectedIndex = 0
                ShowInTextbox()
            End If
        End If

    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        DialogResult = DialogResult.OK
        Me.Close()
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
            .RangeL = 1
            .RangeU = 2
            .NoteColor = 0
            .LongNoteColor = 0
            .LongTextColor = 0
            .BG = 0
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
            BColor.Text = .NoteColor.ToString()
            cButtonChange(BColor, Color.FromArgb(.NoteColor))
        End With

    End Sub

    Private Function GetFileName(ByVal s As String) As String ' Copied from MainWindow
        Dim fslash As Integer = InStrRev(s, "/")
        Dim bslash As Integer = InStrRev(s, "\")
        Return Mid(s, CInt(IIf(fslash > bslash, fslash, bslash)) + 1)
    End Function

    Private Sub SaveCOverride(sender As Object, e As KeyEventArgs) Handles TName.KeyUp, TRangeL.KeyUp, TRangeU.KeyUp
        If IsNothing(COverrides) Then Exit Sub
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
        xbutton.ForeColor = CType(IIf(CInt(c.GetBrightness * 255) + 255 - c.A >= 128, Color.Black, Color.White), Color)
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
        Return C10to36S(CInt(xStart \ 36)) & C10to36S(CInt(xStart Mod 36))
    End Function
    Public Function C36to10(ByVal xStart As String) As Integer
        xStart = Mid("00" & xStart, Len(xStart) + 1)
        Return C36to10S(xStart.Chars(0)) * 36 + C36to10S(xStart.Chars(1))
    End Function

    Private Sub LOverrides_Click(sender As Object, e As EventArgs) Handles LOverrides.Click, LOverrides.KeyUp
        If IsNothing(COverrides) Or LOverrides.SelectedIndex = -1 Then Exit Sub
        ShowInTextbox()
    End Sub
End Class