Public Class OpExpand

    Dim TExpansionTextSplit() As String = Split(MainWindow.TExpansion.Text, vbCrLf, , CompareMethod.Text)
    Dim CurrSelection As Integer = -1
    Dim RangeL As Integer = -1
    Dim RangeU As Integer = -1
    Dim xStack As Integer = 0
    Public Sub New()
        InitializeComponent()

        ' If no expansion text
        If MainWindow.TExpansion.Text = "" Then
            MsgBox("Error: Expansion code is empty.")
            Me.Close()
            Exit Sub
        End If

        ' List expansion code per line
        LExpansionCode.Items.Clear()
        For Each xStrLine In TExpansionTextSplit
            LExpansionCode.Items.Add(xStrLine)
        Next
    End Sub

    Private Sub BDisplayGhost_Click(sender As Object, e As EventArgs) Handles BDisplayGhost.Click
        Select_Section()
        If MainWindow.ExpansionSplit(1) = "-" Then Exit Sub
        Me.Close()
        MainWindow.Expand_DisplayGhostNotes(1)
    End Sub

    Private Sub BDisplayGhostAll_Click(sender As Object, e As EventArgs) Handles BDisplayGhostAll.Click
        MainWindow.ExpansionSplit(1) = MainWindow.TExpansion.Text
        Me.Close()
        MainWindow.Expand_DisplayGhostNotes()
    End Sub

    Private Sub BModifyNotes_Click(sender As Object, e As EventArgs) Handles BModifyNotes.Click
        Select_Section()
        If MainWindow.ExpansionSplit(1) = "-" Then Exit Sub
        Me.Close()
        MainWindow.Expand_ModifyNotes()
    End Sub

    Private Sub BModifySection_Click(sender As Object, e As EventArgs) Handles BModifySection.Click ', LExpansionCode.DoubleClick
        Select_Section()
        If MainWindow.ExpansionSplit(1) = "-" Then Exit Sub
        Me.Close()
        MainWindow.Expand_ModifySection()
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ExpansionCodeList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LExpansionCode.Click
        CurrSelection = LExpansionCode.SelectedIndex
    End Sub

    Private Function SWIC(str As String, strHash As String) As Boolean ' Copied from ChartIO.vb
        Return str.StartsWith(strHash, StringComparison.CurrentCultureIgnoreCase)
    End Function

    Private Function ExcludeFileName(ByVal s As String) As String ' Copied from MainWindow.vb
        Dim fslash As Integer = InStrRev(s, "/")
        Dim bslash As Integer = InStrRev(s, "\")
        If (bslash Or fslash) = 0 Then Return ""
        Return Mid(s, 1, IIf(fslash > bslash, fslash, bslash) - 1)
    End Function

    Private Sub BRemoveGhostNotes_Click(sender As Object, e As EventArgs) Handles BRemoveGhostNotes.Click
        Me.Close()
        MainWindow.Expand_RemoveGhostNotes()
    End Sub

    Private Sub Select_Section() ' Select #if section
        ' If no line selected
        If CurrSelection = -1 Then
            MsgBox("Error: No line selected.")
            MainWindow.ExpansionSplit(1) = "-"
            Exit Sub
        End If

        ' Find the first line of the currect #if section, right after #if
        For L = CurrSelection To 0 Step -1
            If SWIC(LExpansionCode.Items(L), "#ENDIF") AndAlso L <> CurrSelection Then
                xStack += 1
            End If

            If SWIC(LExpansionCode.Items(L), "#IF") Then
                If xStack > 0 Then
                    xStack -= 1
                Else
                    RangeL = L + 1
                    Exit For
                End If

            End If
        Next
        ' Find the last line of the currect #if section, right before #endif
        For U = CurrSelection To TExpansionTextSplit.Length - 1
            If SWIC(LExpansionCode.Items(U), "#IF") AndAlso U <> CurrSelection Then
                xStack += 1
            End If

            If SWIC(LExpansionCode.Items(U), "#ENDIF") Then
                If xStack > 0 Then
                    xStack -= 1
                Else
                    RangeU = U - 1
                    Exit For
                End If

            End If
        Next

        ' If RangeL or RangeU's values have not been found
        If RangeL = -1 Or RangeU = -1 Then
            MsgBox("Error: #IF Section not detected.")
            MainWindow.ExpansionSplit(1) = "-"
            Exit Sub
        End If

        ' Split expansion code into 3 parts
        Dim TExpansionTextSelected(RangeL - 1) As String
        For i = 0 To RangeL - 1
            TExpansionTextSelected(i) = TExpansionTextSplit(i)
        Next
        MainWindow.ExpansionSplit(0) = Join(TExpansionTextSelected, vbCrLf)
        ReDim TExpansionTextSelected(RangeU - RangeL)
        For i = RangeL To RangeU
            TExpansionTextSelected(i - RangeL) = TExpansionTextSplit(i)
        Next
        MainWindow.ExpansionSplit(1) = Join(TExpansionTextSelected, vbCrLf)
        ReDim TExpansionTextSelected(TExpansionTextSplit.Length - 1 - RangeU - 1)
        For i = RangeU + 1 To TExpansionTextSplit.Length - 1
            TExpansionTextSelected(i - RangeU - 1) = TExpansionTextSplit(i)
        Next
        MainWindow.ExpansionSplit(2) = Join(TExpansionTextSelected, vbCrLf)
    End Sub
End Class