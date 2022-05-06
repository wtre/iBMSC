Public Class OpVisualOverride
    Public COverrides() As MainWindow.ColorOverride
    Dim CColorOptionList() As RadioButton
    Public LoadSettings As Integer
    Dim WHeight As Integer
    Dim TLValuesHeight() As Single
    Dim hWAV(1295) As String

    Public Sub New(ByVal xColorOverrides() As MainWindow.ColorOverride, xhWAV As String(), SaveOption As Integer)
        InitializeComponent()
        CColorOptionList = {RColorSing, RColorGrad, RColorGradHSLD, RColorGradHSLU}

        LOverrides.Items.Clear()

        COverrides = CType(xColorOverrides.Clone(), MainWindow.ColorOverride())

        WHeight = Height
        ReDim TLValuesHeight(TLValues.RowStyles.Count - 1)
        For i = 0 To TLValues.RowStyles.Count - 1
            TLValuesHeight(i) = TLValues.RowStyles(i).Height
        Next

        hWAV = xhWAV
        CoBSave.SelectedIndex = SaveOption
        UpdateTLValuesDisplay()

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

    Private Sub LOverrides_Click(sender As Object, e As EventArgs) Handles LOverrides.Click
        If IsNothing(COverrides) Or LOverrides.SelectedIndex = -1 Then Exit Sub
        ShowInTextbox()
    End Sub

    Private Sub LOverrides_KeyDown(sender As Object, e As KeyEventArgs) Handles LOverrides.KeyDown
        If IsNothing(COverrides) Or LOverrides.SelectedIndex = -1 Then Exit Sub
        If e.KeyCode = Keys.Delete Then BRemove_Click(sender, New EventArgs) : Exit Sub

        ShowInTextbox()
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
            .Enabled = True
            .ColorOption = 0
            .RangeL = 1
            .RangeU = 2
            .NoteColor = 0
            .NoteColorU = 0
        End With

        LOverrides.Items.Insert(LOverrides.Items.Count, "New Item")
        LOverrides.SelectedIndex = UBound(COverrides)
        ShowInTextbox()
    End Sub

    Private Sub BUp_Click(sender As Object, e As EventArgs) Handles BUp.Click
        Dim xI = LOverrides.SelectedIndex
        If xI <= 1 Then Exit Sub

        Dim COverrideTemp = COverrides(xI - 1)
        COverrides(xI - 1) = COverrides(xI)
        COverrides(xI) = COverrideTemp

        Dim ItemTemp = LOverrides.Items(xI - 1)
        LOverrides.Items(xI - 1) = LOverrides.Items(xI)
        LOverrides.Items(xI) = ItemTemp
        LOverrides.SelectedIndex -= 1
    End Sub

    Private Sub BDown_Click(sender As Object, e As EventArgs) Handles BDown.Click
        Dim xI = LOverrides.SelectedIndex
        If xI = -1 Or xI = LOverrides.Items.Count - 1 Then Exit Sub

        Dim COverrideTemp = COverrides(xI + 1)
        COverrides(xI + 1) = COverrides(xI)
        COverrides(xI) = COverrideTemp

        Dim ItemTemp = LOverrides.Items(xI + 1)
        LOverrides.Items(xI + 1) = LOverrides.Items(xI)
        LOverrides.Items(xI) = ItemTemp
        LOverrides.SelectedIndex += 1
    End Sub

    Private Sub BDuplicate_Click(sender As Object, e As EventArgs) Handles BDuplicate.Click
        Dim xI = LOverrides.SelectedIndex
        If xI = -1 Then Exit Sub

        ReDim Preserve COverrides(COverrides.Length)
        LOverrides.Items.Add("")
        For i = UBound(COverrides) To xI + 1 Step -1
            LOverrides.Items(i) = LOverrides.Items(i - 1)
            COverrides(i) = COverrides(i - 1)
        Next
    End Sub

    Private Sub BSplit_Click(sender As Object, e As EventArgs) Handles BSplit.Click
        Dim xI = LOverrides.SelectedIndex
        If xI = -1 Then Exit Sub
        If C36to10(TRangeU.Text) - C36to10(TRangeL.Text) <= 0 Then MsgBox("Warning: Cannot split range.") : Exit Sub

        Dim xRangeLU = C36to10(InputBox("Please input the upper bound for the first range."))
        Do While xRangeLU < C36to10(TRangeL.Text) Or C36to10(TRangeU.Text) < xRangeLU
            If xRangeLU = 0 Then Exit Sub
            xRangeLU = C36to10(InputBox("Value not between the range. Please input the upper bound for the first range."))
        Loop

        BDuplicate_Click(sender, New EventArgs)
        COverrides(xI).RangeU = xRangeLU
        COverrides(xI + 1).RangeL = xRangeLU + 1
        ShowInTextbox()
    End Sub

    Private Sub BSemiAuto_Click(sender As Object, e As EventArgs) Handles BSemiAuto.Click
        Dim OptionName As String = InputBox("Assign notes with wav filenames beginning with the following:")
        Do While OptionName <> ""
            Dim RangeL As Integer = 0
            Dim RangeU As Integer = 0
            Dim i As Integer = 1
            Dim Flag As Boolean = False
            Do While i <= UBound(hWAV)
                If Not Flag AndAlso SWIC(hWAV(i), OptionName) Then
                    RangeL = i
                    Flag = True
                ElseIf Flag AndAlso Not SWIC(hWAV(i), OptionName) Then
                    RangeU = i - 1
                    Exit Do
                End If
                i += 1
            Loop

            If RangeL <> 0 Then
                ReDim Preserve COverrides(COverrides.Length)
                COverrides(UBound(COverrides)) = New MainWindow.ColorOverride(OptionName, True, 0, RangeL, RangeU, Color.FromArgb(255, CInt(Math.Floor(256 * Rnd())), CInt(Math.Floor(256 * Rnd())), CInt(Math.Floor(256 * Rnd()))).ToArgb, 0)
                LOverrides.Items.Add(OptionName)
            Else
                MsgBox("No notes found.")
            End If
            OptionName = InputBox("Assign more notes with wav filenames beginning with the following:")
        Loop
    End Sub

    Private Sub BRemove_Click(sender As Object, e As EventArgs) Handles BRemove.Click
        If LOverrides.SelectedIndex = -1 Then Exit Sub

        For i = LOverrides.SelectedIndex To UBound(COverrides) - 1
            COverrides(i) = COverrides(i + 1)
        Next
        ReDim Preserve COverrides(UBound(COverrides) - 1)

        LOverrides.Items.RemoveAt(LOverrides.SelectedIndex)
    End Sub

    Private Sub CoBLoad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CoBLoad.SelectedIndexChanged
        If CoBLoad.SelectedIndex = -1 Then Exit Sub

        Dim SaveCurrentSettings = MsgBox("Save current settings?", MsgBoxStyle.YesNoCancel)
        If SaveCurrentSettings = MsgBoxResult.Yes Then
            OK_Button_Click(sender, e)
        ElseIf SaveCurrentSettings = MsgBoxResult.No Then
            Cancel_Button_Click(sender, e)
        Else
            CoBLoad.SelectedIndex = -1
        End If
    End Sub

    Private Sub CBEnable_CheckedChanged(sender As Object, e As EventArgs) Handles CBEnable.CheckedChanged
        If LOverrides.SelectedIndex = -1 Then Exit Sub

        COverrides(LOverrides.SelectedIndex).Enabled = CBEnable.Checked
    End Sub

    Private Sub CColorList_CheckedChanged(sender As Object, e As EventArgs) Handles RColorSing.CheckedChanged, RColorGrad.CheckedChanged, RColorGradHSLD.CheckedChanged, RColorGradHSLU.CheckedChanged
        If LOverrides.SelectedIndex = -1 Then Exit Sub

        Dim RadioS As RadioButton = CType(sender, RadioButton)
        Dim COption = COverrides(LOverrides.SelectedIndex).ColorOption
        Dim COption1 = Array.IndexOf(CColorOptionList, RadioS)
        If (COption = 0 AndAlso COption1 <> 0) OrElse (COption <> 0 AndAlso COption1 = 0) Then UpdateTLValuesDisplay()
        COverrides(LOverrides.SelectedIndex).ColorOption = COption1

        RefreshPreview()
    End Sub

    Private Sub SaveCOverride(sender As Object, e As KeyEventArgs) Handles TName.KeyUp, TRangeL.KeyUp, TRangeU.KeyUp
        If IsNothing(COverrides) Then Exit Sub
        With COverrides(LOverrides.SelectedIndex)
            .Name = TName.Text
            .RangeL = C36to10(TRangeL.Text)
            .RangeU = C36to10(TRangeU.Text)
        End With
        If [Object].ReferenceEquals(sender, TName) Then LOverrides.Items.Item(LOverrides.SelectedIndex) = TName.Text
        RefreshPreview()
    End Sub

    Private Sub BColor_Click(sender As Object, e As EventArgs) Handles BColorSing.Click, BColorGradL.Click
        Dim xColorPicker As New ColorPicker
        xColorPicker.SetOrigColor(BColorSing.BackColor)
        If xColorPicker.ShowDialog(Me) = Windows.Forms.DialogResult.Cancel Then Exit Sub
        cButtonChange(BColorSing, xColorPicker.NewColor)
        cButtonChange(BColorGradL, xColorPicker.NewColor)
        COverrides(LOverrides.SelectedIndex).NoteColor = xColorPicker.NewColor.ToArgb
        RefreshPreview()
    End Sub

    Private Sub BColorGradU_Click(sender As Object, e As EventArgs) Handles BColorGradU.Click
        Dim xColorPicker As New ColorPicker
        xColorPicker.SetOrigColor(BColorGradU.BackColor)
        If xColorPicker.ShowDialog(Me) = Windows.Forms.DialogResult.Cancel Then Exit Sub
        cButtonChange(BColorGradU, xColorPicker.NewColor)
        COverrides(LOverrides.SelectedIndex).NoteColorU = xColorPicker.NewColor.ToArgb
        RefreshPreview()
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

    Private Sub ShowInTextbox() ' Referenced OpPlayer
        With COverrides(LOverrides.SelectedIndex)
            TName.Text = .Name
            CBEnable.Checked = .Enabled
            CColorOptionList(.ColorOption).Checked = True
            TRangeL.Text = C10to36(.RangeL)
            TRangeU.Text = C10to36(.RangeU)
            BColorSing.Text = .NoteColor.ToString()
            BColorGradL.Text = .NoteColor.ToString()
            BColorGradU.Text = .NoteColorU.ToString()
            cButtonChange(BColorSing, Color.FromArgb(.NoteColor))
            cButtonChange(BColorGradL, Color.FromArgb(.NoteColor))
            cButtonChange(BColorGradU, Color.FromArgb(.NoteColorU))
        End With
        RefreshPreview()
    End Sub


    Private Sub RefreshPreview()
        If Not CColorOptionList(1).Checked AndAlso Not CColorOptionList(2).Checked AndAlso Not CColorOptionList(3).Checked Then Exit Sub
        Dim e1 As BufferedGraphics = BufferedGraphicsManager.Current.Allocate(PColorGrad.CreateGraphics, PColorGrad.DisplayRectangle)
        Dim PanelW As Integer = PColorGrad.DisplayRectangle.Width
        Dim PanelH As Integer = PColorGrad.DisplayRectangle.Height
        Dim iStep As Integer
        If C36to10(TRangeU.Text) - C36to10(TRangeL.Text) < 0 Then
            iStep = PanelW
        Else
            iStep = Math.Max(CInt(PanelW / (C36to10(TRangeU.Text) - C36to10(TRangeL.Text) + 1)), 1)
        End If
        Dim ColorL As Color = BColorGradL.BackColor
        Dim ColorU As Color = BColorGradU.BackColor
        Dim ColorI As Color
        For i = 0 To PanelW Step iStep
            If CColorOptionList(1).Checked Then
                ColorI = InterpolateColorARGB(ColorL, ColorU, i / PanelW)
            ElseIf CColorOptionList(2).Checked OrElse CColorOptionList(3).Checked Then
                Dim Direction As Integer = 1
                If CColorOptionList(3).Checked Then Direction = 0
                ColorI = InterpolateColorAHSL(ColorL, ColorU, i / PanelW, Direction)
            End If
            e1.Graphics.FillRectangle(New Drawing2D.LinearGradientBrush(New Point(0, 0),
                                                                        New Point(0, PanelH),
                                                                        ColorI,
                                                                        ColorI),
                                      i, 0,
                                      i + iStep, PanelH)
        Next

        e1.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        e1.Render(PColorGrad.CreateGraphics)
        e1.Dispose()
    End Sub

    Private Function InterpolateColorARGB(ColorL As Color, ColorU As Color, Ratio As Double) As Color
        Dim A As Double = ((1 - Ratio) * Convert.ToInt32(ColorL.A)) + (Ratio * Convert.ToInt32(ColorU.A))
        Dim R As Double = ((1 - Ratio) * Convert.ToInt32(ColorL.R)) + (Ratio * Convert.ToInt32(ColorU.R))
        Dim G As Double = ((1 - Ratio) * Convert.ToInt32(ColorL.G)) + (Ratio * Convert.ToInt32(ColorU.G))
        Dim B As Double = ((1 - Ratio) * Convert.ToInt32(ColorL.B)) + (Ratio * Convert.ToInt32(ColorU.B))
        Return Color.FromArgb(Convert.ToByte(A), Convert.ToByte(R), Convert.ToByte(G), Convert.ToByte(B))
    End Function

    Private Function InterpolateColorAHSL(ColorL As Color, ColorU As Color, Ratio As Double, Optional Direction As Integer = 1) As Color
        Dim HSLL = GetHSL(ColorL)
        Dim HSLU = GetHSL(ColorU)
        If Direction = 1 AndAlso HSLL(0) > HSLU(0) Then
            HSLU(0) += 360
        ElseIf Direction = 0 AndAlso HSLL(0) < HSLU(0) Then
            HSLL(0) += 360
        End If
        Dim A As Double = Math.Min((1 - Ratio) * Convert.ToInt32(ColorL.A) + (Ratio * Convert.ToInt32(ColorU.A)), 255)
        Dim H As Double = ((1 - Ratio) * HSLL(0) + Ratio * HSLU(0)) Mod 360
        Dim S As Double = Math.Min((1 - Ratio) * HSLL(1) + Ratio * HSLU(1), 1000)
        Dim L As Double = Math.Min((1 - Ratio) * HSLL(2) + Ratio * HSLU(2), 1000)

        ' Copied from ColorPicker
        Dim xxS = S / 1000
        Dim xxB = (L - 500) / 500
        Dim R As Double
        Dim G As Double
        Dim B As Double

        If H < 60 Then
            B = -1 : R = 1 : G = (H - 30) / 30
        ElseIf H < 120 Then
            B = -1 : G = 1 : R = (90 - H) / 30
        ElseIf H < 180 Then
            R = -1 : G = 1 : B = (H - 150) / 30
        ElseIf H < 240 Then
            R = -1 : B = 1 : G = (210 - H) / 30
        ElseIf H < 300 Then
            G = -1 : B = 1 : R = (H - 270) / 30
        Else
            G = -1 : R = 1 : B = (330 - H) / 30
        End If

        R = (R * xxS * (1 - Math.Abs(xxB)) + xxB + 1) * 255 / 2
        G = (G * xxS * (1 - Math.Abs(xxB)) + xxB + 1) * 255 / 2
        B = (B * xxS * (1 - Math.Abs(xxB)) + xxB + 1) * 255 / 2

        Return Color.FromArgb(CInt(A), CInt(R), CInt(G), CInt(B))
    End Function

    Private Function GetHSL(ColorI As Color) As Integer()
        Dim R As Double = CInt(ColorI.R) / 255
        Dim G As Double = CInt(ColorI.G) / 255
        Dim B As Double = CInt(ColorI.B) / 255
        Console.WriteLine("R: " & R & vbCrLf & "G: " & G & vbCrLf & "B: " & B & vbCrLf)
        Dim CMin = Math.Min(Math.Min(R, G), B)
        Dim CMax = Math.Max(Math.Max(R, G), B)
        Dim Delta = CMax - CMin
        Dim H As Double
        Dim S As Double
        Dim L As Double
        Console.WriteLine("CMin: " & CMin & vbCrLf & "CMax: " & CMax & vbCrLf & "Delta: " & Delta & vbCrLf)
        If Delta = 0 Then
            H = 0
        ElseIf CMax = R Then
            H = (6 + ((G - B) / Delta)) Mod 6
        ElseIf CMax = G Then
            H = (B - R) / Delta + 2
        Else
            H = (R - G) / Delta + 4
        End If

        H = Math.Round(H * 60)
        If H < 0 Then H += 360

        L = (CMax + CMin) / 2

        If Delta = 0 Then S = 0 Else If L = 1 Then S = 1 Else S = Delta / (1 - Math.Abs(2 * L - 1))
        Console.WriteLine(H & vbCrLf & S & vbCrLf & L & vbCrLf)
        S *= 1000
        L *= 1000

        Return {CInt(H), CInt(S), CInt(L)}
    End Function

    Private Sub UpdateTLValuesDisplay()
        If TLValuesHeight Is Nothing Then Exit Sub
        SuspendLayout()
        TLValues.SuspendLayout()
        Height = WHeight
        TLValues.RowStyles(2).Height = TLValuesHeight(2)
        TLValues.RowStyles(3).Height = TLValuesHeight(3)
        TLValues.RowStyles(4).Height = TLValuesHeight(4)
        If CColorOptionList(0).Checked Then
            TLValues.RowStyles(3).Height = 0
            TLValues.RowStyles(4).Height = 0
            Height -= CInt(TLValuesHeight(3) + TLValuesHeight(4))
        Else
            TLValues.RowStyles(2).Height = 0
            Height -= CInt(TLValuesHeight(2))
        End If
        ResumeLayout()
        TLValues.ResumeLayout()
    End Sub

    Private Function SWIC(str As String, strHash As String) As Boolean ' StartsWith, IgnoreCase
        If str Is Nothing Then Return False
        Return str.StartsWith(strHash, StringComparison.CurrentCultureIgnoreCase)
    End Function
End Class