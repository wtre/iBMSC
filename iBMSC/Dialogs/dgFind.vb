Imports System.Windows.Forms

Public Class dgFind
    Dim bCol As Integer = 46
    Dim msg1 As String = "Error"
    Dim msg2 As String = "Invalid label."

    Public Sub New(ByVal xbCol As Integer, ByVal xmsg1 As String, ByVal xmsg2 As String)
        InitializeComponent()
        bCol = xbCol
        msg1 = xmsg1
        msg2 = xmsg2
    End Sub

    Private Sub CloseDialog(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBClose.Click
        Me.Close()
    End Sub

    Private Sub BSAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSAll.Click
        For Each xCB As CheckBox In Panel1.Controls
            xCB.Checked = True
        Next
    End Sub
    Private Sub BSInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSInv.Click
        For Each xCB As CheckBox In Panel1.Controls
            xCB.Checked = Not xCB.Checked
        Next
    End Sub
    Private Sub BSNone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSNone.Click
        For Each xCB As CheckBox In Panel1.Controls
            xCB.Checked = False
        Next
    End Sub

    Private Sub diagFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Font = MainWindow.Font
        Dim xBold As New Font(Me.Font, FontStyle.Bold)

        TBSelect.Font = xBold
        Label8.Font = xBold
        Label9.Font = xBold

        'Dim xS() As String = Form1.lpfdr
        Me.Text = MainWindow.TBFind.Text

        Label1.Text = Strings.fFind.NoteRange
        Label2.Text = Strings.fFind.MeasureRange
        Label3.Text = Strings.fFind.LabelRange
        Label4.Text = Strings.fFind.ValueRange
        Label5.Text = Strings.fFind.to_
        Label6.Text = Strings.fFind.to_
        Label7.Text = Strings.fFind.to_

        cbx1.Text = Strings.fFind.Selected
        cbx2.Text = Strings.fFind.UnSelected
        cbx3.Text = Strings.fFind.ShortNote
        cbx4.Text = Strings.fFind.LongNote
        cbx5.Text = Strings.fFind.Hidden
        cbx6.Text = Strings.fFind.Visible

        Label8.Text = Strings.fFind.Column
        BSAll.Text = Strings.fFind.SelectAll
        BSInv.Text = Strings.fFind.SelectInverse
        BSNone.Text = Strings.fFind.UnselectAll

        Label9.Text = Strings.fFind.Operation
        TBrl.Text = Strings.fFind.ReplaceWithLabel
        TBrv.Text = Strings.fFind.ReplaceWithValue
        TBSelect.Text = Strings.fFind.Select_
        TBUnselect.Text = Strings.fFind.Unselect_
        TBDelete.Text = Strings.fFind.Delete_
        TBClose.Text = Strings.fFind.Close_

        For xI1 As Integer = 27 To bCol
            Dim xCB As New CheckBox
            With xCB
                .Appearance = Appearance.Button
                .Checked = True
                .FlatStyle = FlatStyle.System
                .Location = New Point(((xI1 - 26) Mod 8) * 35 + 3, ((xI1 - 26) \ 8) * 25 + 103)
                .Size = New Size(35, 25)
                .Tag = xI1
                .Text = "B" & (xI1 - 25).ToString
                .TextAlign = ContentAlignment.MiddleCenter
                .UseVisualStyleBackColor = True
            End With
            Panel1.Controls.Add(xCB)
        Next

        AddHandler lr1.KeyDown, AddressOf lblKeyDown
        AddHandler lr2.KeyDown, AddressOf lblKeyDown
        AddHandler Ttl.KeyDown, AddressOf lblKeyDown
    End Sub

    Private Function ValidLabel(ByVal xStr As String) As Boolean
        xStr = UCase(Trim(xStr))

        If Len(xStr) = 0 Then Return False
        If xStr = "00" Or xStr = "0" Then Return False
        If Not Len(xStr) = 1 And Not Len(xStr) = 2 Then Return False

        Dim xI3 As Integer = Asc(Mid(xStr, 1, 1))
        If Not ((xI3 >= 48 And xI3 <= 57) Or (xI3 >= 65 And xI3 <= 90)) Then Return False
        If Len(xStr) = 2 Then
            Dim xI4 As Integer = Asc(Mid(xStr, 2, 1))
            If Not ((xI4 >= 48 And xI4 <= 57) Or (xI4 >= 65 And xI4 <= 90)) Then Return False
        End If
        Return True
        MsgBox(msg2, MsgBoxStyle.Critical, msg1)
    End Function

    Private Sub lblKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not e.KeyCode = Keys.Enter Then Exit Sub
        ValidateLabel(sender)
    End Sub

    Private Function ValidateLabel(ByVal sender As Object) As Boolean
        Dim TextboxS As TextBox = CType(sender, TextBox)
        Dim xBool As Boolean = ValidLabel(TextboxS.Text)
        If Not xBool Then
            MsgBox(msg2, MsgBoxStyle.Critical, msg1)
            TextboxS.Focus()
            TextboxS.SelectAll()
        End If
        Return xBool
    End Function

    Private Sub NoteFunction(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBSelect.Click, TBUnselect.Click, FNotePrevious.Click, FNoteNext.Click, TBrl.Click, TBrv.Click, TBDelete.Click
        If Not ValidateLabel(lr1) Or Not ValidateLabel(lr2) Then Exit Sub

        Dim LabelS As String = CType(sender, Button).Name
        Dim xCol() As Integer = {}
        For Each xCB As CheckBox In Panel1.Controls
            If xCB.Checked Then
                ReDim Preserve xCol(UBound(xCol) + 1)
                xCol(UBound(xCol)) = CInt(xCB.Tag)
            End If
        Next

        Dim ArrCB() As CheckBox = {cbx1, cbx2, cbx3, cbx4, cbx5, cbx6}
        Dim xRange(UBound(ArrCB)) As Boolean
        For i = 0 To UBound(ArrCB)
            xRange(i) = ArrCB(i).Checked
        Next

        Dim xReplaceLbl As String = Ttl.Text
        Dim xReplaceVal As Integer = CInt(Ttv.Value * 10000)

        MainWindow.fdrFind(xRange,
                        CInt(mr1.Value), CInt(mr2.Value),
                        lr1.Text, lr2.Text,
                        CInt(vr1.Value * 10000), CInt(vr2.Value * 10000),
                        xCol, LabelS, xReplaceLbl, xReplaceVal)
    End Sub
End Class
