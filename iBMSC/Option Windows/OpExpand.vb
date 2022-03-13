Public Class OpExpand

    Dim TExpansionTextSplit() As String = Split(MainWindow.TExpansion.Text, vbCrLf, , CompareMethod.Text)
    Dim CurrSelection As Integer = -1
    Dim RangeL As Integer = -1
    Dim RangeU As Integer = -1
    Dim xStack As Integer = 0
    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click, ExpansionCodeList.DoubleClick
        ' If no line selected
        If CurrSelection = -1 Then
            MsgBox("Error: No line selected.")
            Exit Sub
        End If

        ' Find the first line of the currect #if section, right after #if
        For L = CurrSelection To 0 Step -1
            If SWIC(ExpansionCodeList.Items(L), "#ENDIF") AndAlso L <> CurrSelection Then
                xStack += 1
            End If

            If SWIC(ExpansionCodeList.Items(L), "#IF") Then
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
            If SWIC(ExpansionCodeList.Items(U), "#IF") AndAlso U <> CurrSelection Then
                xStack += 1
            End If

            If SWIC(ExpansionCodeList.Items(U), "#ENDIF") Then
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
            Exit Sub
        End If

        ' Split expansion code into 3 parts
        Dim TExpansionTextSelected(RangeL - 1) As String
        For i = 0 To RangeL - 1
            TExpansionTextSelected(i) = TExpansionTextSplit(i)
        Next
        MainWindow.RandomFile(0) = Join(TExpansionTextSelected, vbCrLf)
        ReDim TExpansionTextSelected(RangeU - RangeL)
        For i = RangeL To RangeU
            TExpansionTextSelected(i - RangeL) = TExpansionTextSplit(i)
        Next
        MainWindow.RandomFile(1) = Join(TExpansionTextSelected, vbCrLf)
        ReDim TExpansionTextSelected(TExpansionTextSplit.Length - 1 - RangeU - 1)
        For i = RangeU + 1 To TExpansionTextSplit.Length - 1
            TExpansionTextSelected(i - RangeU - 1) = TExpansionTextSplit(i)
        Next
        MainWindow.RandomFile(2) = Join(TExpansionTextSelected, vbCrLf)
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub New()
        InitializeComponent()

        ' If no expansion text
        If MainWindow.TExpansion.Text = "" Then
            MsgBox("Error: Expansion code is empty.")
            Me.Close()
            Exit Sub
        End If

        ' List expansion code per line
        ExpansionCodeList.Items.Clear()
        For Each xStrLine In TExpansionTextSplit
            ExpansionCodeList.Items.Add(xStrLine)
        Next
    End Sub

    Private Sub ExpansionCodeList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExpansionCodeList.Click
        CurrSelection = ExpansionCodeList.SelectedIndex
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

End Class