Public Class OpTotal
    Dim NoteCount As Integer
    Public TotalOption As Integer
    Dim CTotalList() As RadioButton

    Public Sub New(ByVal xNoteCount As Integer, ByVal xTotalOption As Integer, ByVal xMultiplier As Double, ByVal xGlobalMultiplier As Double, ByVal xRecommendedTextDisplay As Boolean)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CTotalList = {CTotalIIDX1, CTotalIIDX2, CTotalMultiplier}
        NoteCount = xNoteCount
        TotalOption = xTotalOption
        TMultiplier.Text = xMultiplier.ToString()
        TGlobalMultiplier.Text = xGlobalMultiplier.ToString()
        CBDisplayText.Checked = xRecommendedTextDisplay
        CTotalList(TotalOption).Checked = True

        CalculateTotal()
    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub CTotalIIDX1_Click(sender As Object, e As EventArgs) Handles CTotalIIDX1.Click, CTotalIIDX2.Click, CTotalMultiplier.Click
        Dim RadioS As RadioButton = CType(sender, RadioButton)
        TotalOption = Array.IndexOf(Of RadioButton)(CTotalList, RadioS)
    End Sub

    Private Sub TMultiplier_TextChanged(sender As Object, e As EventArgs) Handles TMultiplier.TextChanged, TGlobalMultiplier.TextChanged
        CalculateTotal()
    End Sub

    Private Sub CalculateTotal()
        LTotalIIDX1.Text = Math.Round(NoteCount * 7.605 / (0.01 * NoteCount + 6.5) * Val(TGlobalMultiplier.Text), 3).ToString()
        LTotalIIDX2.Text = Math.Round(CDbl(IIf(NoteCount < 400, 200 + NoteCount / 5, IIf(NoteCount < 600, 280 + (NoteCount - 400) / 2.5, 360 + (NoteCount - 600) / 5))) * Val(TGlobalMultiplier.Text), 3).ToString()
        LTotalMultiplier.Text = Math.Round(NoteCount * Val(TMultiplier.Text) * Val(TGlobalMultiplier.Text), 3).ToString()
    End Sub
End Class