Public Class ColorPicker
    Public OrigColor As Color = Color.Black
    Public NewColor As Color = Color.Black
    Dim DrawingIndex As Integer = 1
    Dim PassiveValueChange As Boolean = False

    Dim mMain As Point = New Point(0, 255)
    Dim mAlpha As Integer = 255
    Dim m1 As Integer = 255

    Public Sub SetOrigColor(ByVal xColor As Color)
        OrigColor = xColor
        SetNewColor(xColor)
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub SetNewColor(ByVal xColor As Color, Optional ByVal xSetText As Boolean = True)
        NewColor = xColor
        RefreshPrev(pPrev.DisplayRectangle)
        If xSetText Then tStr.Text = Mid("0000000" & Hex(xColor.ToArgb), Len(Hex(xColor.ToArgb)))
    End Sub

    Private Sub SetCursor()
        Select Case DrawingIndex
            Case 0
                mMain = New Point(CInt(inS.Value / 1000 * 255), CInt((1000 - inL.Value) / 1000 * 255))
                m1 = CInt((360 - inH.Value) * 255 / 360)
            Case 1
                mMain = New Point(CInt(inH.Value * 255 / 360), CInt((1000 - inL.Value) / 1000 * 255))
                m1 = CInt((1000 - inS.Value) * 255 / 1000)
            Case 2
                mMain = New Point(CInt(inH.Value * 255 / 360), CInt((1000 - inS.Value) * 255 / 1000))
                m1 = CInt((1000 - inL.Value) * 255 / 1000)
            Case 3
                mMain = New Point(CInt(inB.Value), CInt(255 - inG.Value))
                m1 = CInt(255 - inR.Value)
            Case 4
                mMain = New Point(CInt(inB.Value), CInt(255 - inR.Value))
                m1 = CInt(255 - inG.Value)
            Case 5
                mMain = New Point(CInt(inG.Value), CInt(255 - inR.Value))
                m1 = CInt(255 - inB.Value)
        End Select
        mAlpha = CInt(inA.Value)

    End Sub

    ''' <param name="xH">Hue (0-359)</param>
    ''' <param name="xS">Saturation (0-1000)</param>
    ''' <param name="xL">Lightness (0-1000)</param>
    ''' <param name="xA">Alpha (0-255)</param>
    Private Function HSL2RGB(ByVal xH As Integer, ByVal xS As Integer, ByVal xL As Integer, Optional ByVal xA As Integer = 255) As Color
        If xH > 360 Or xS > 1000 Or xL > 1000 Or xA > 255 Then Return Color.Black

        'Dim xxH As Double = xH
        Dim xxS As Double = xS / 1000
        Dim xxB As Double = (xL - 500) / 500
        Dim xR As Double
        Dim xG As Double
        Dim xB As Double

        If xH < 60 Then
            xB = -1 : xR = 1 : xG = (xH - 30) / 30
        ElseIf xH < 120 Then
            xB = -1 : xG = 1 : xR = (90 - xH) / 30
        ElseIf xH < 180 Then
            xR = -1 : xG = 1 : xB = (xH - 150) / 30
        ElseIf xH < 240 Then
            xR = -1 : xB = 1 : xG = (210 - xH) / 30
        ElseIf xH < 300 Then
            xG = -1 : xB = 1 : xR = (xH - 270) / 30
        Else
            xG = -1 : xR = 1 : xB = (330 - xH) / 30
        End If

        xR = (xR * xxS * (1 - Math.Abs(xxB)) + xxB + 1) * 255 / 2
        xG = (xG * xxS * (1 - Math.Abs(xxB)) + xxB + 1) * 255 / 2
        xB = (xB * xxS * (1 - Math.Abs(xxB)) + xxB + 1) * 255 / 2

        Return Color.FromArgb(xA, CInt(xR), CInt(xG), CInt(xB))
    End Function

    Private Sub PCMain_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PCMain.MouseDown
        PCMain_MouseMove(sender, e)
    End Sub

    Private Sub PCMain_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PCMain.MouseMove
        If Not e.Button = Windows.Forms.MouseButtons.Left Then Exit Sub
        mMain = e.Location
        If mMain.X < 0 Then mMain.X = 0
        If mMain.X > 255 Then mMain.X = 255
        If mMain.Y < 0 Then mMain.Y = 0
        If mMain.Y > 255 Then mMain.Y = 255

        Select Case DrawingIndex
            Case 0
                inL.Value = CDec(1000 - mMain.Y / 255 * 1000)
                inS.Value = CDec(mMain.X / 255 * 1000)
            Case 1
                inL.Value = CDec(1000 - mMain.Y / 255 * 1000)
                inH.Value = CDec(mMain.X / 255 * 360)
            Case 2
                inS.Value = CDec(1000 - mMain.Y / 255 * 1000)
                inH.Value = CDec(mMain.X / 255 * 360)
            Case 3
                inG.Value = 255 - mMain.Y
                inB.Value = mMain.X
            Case 4
                inR.Value = 255 - mMain.Y
                inB.Value = mMain.X
            Case 5
                inR.Value = 255 - mMain.Y
                inG.Value = mMain.X
        End Select
    End Sub

    Private Sub PCMain_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PCMain.Paint
        RefreshMain(e.ClipRectangle)
    End Sub

    Private Sub RefreshMain(ByVal xRegion As Rectangle)
        Dim e1 As BufferedGraphics = BufferedGraphicsManager.Current.Allocate(PCMain.CreateGraphics, xRegion)
        Dim xI1 As Integer
        'Dim xWidth As Integer = PCMain.DisplayRectangle.Width
        'Dim xHeight As Integer = PCMain.DisplayRectangle.Height
        Dim xPrecision As Integer = tbPrecision.Value

        Select Case DrawingIndex
            Case 0
                Dim xHue As Integer = CInt(inH.Value)
                For xI1 = 0 To 255 Step xPrecision
                    e1.Graphics.FillRectangle(New Drawing2D.LinearGradientBrush(
                                                    New Point(0, 0),
                                                    New Point(0, 128),
                                                    Color.White,
                                                    HSL2RGB(xHue, CInt(xI1 / 255 * 1000), 500)),
                                              xI1,
                                              0,
                                              xPrecision,
                                              128)
                    e1.Graphics.FillRectangle(New Drawing2D.LinearGradientBrush(
                                                    New Point(0, 128),
                                                    New Point(0, 256),
                                                    HSL2RGB(xHue, CInt(xI1 / 255 * 1000), 500),
                                                    Color.Black),
                                              xI1,
                                              128,
                                              xPrecision,
                                              128)
                Next
            Case 1
                Dim xSaturation As Integer = CInt(inS.Value)
                For xI1 = 0 To 255 Step xPrecision
                    e1.Graphics.FillRectangle(New Drawing2D.LinearGradientBrush(
                                                    New Point(0, 0),
                                                    New Point(0, 128),
                                                    Color.White,
                                                    HSL2RGB(CInt(xI1 / 255 * 360), xSaturation, 500)),
                                              xI1,
                                              0,
                                              xPrecision,
                                              128)
                    e1.Graphics.FillRectangle(New Drawing2D.LinearGradientBrush(
                                                    New Point(0, 128),
                                                    New Point(0, 256),
                                                    HSL2RGB(CInt(xI1 / 255 * 360), xSaturation, 500),
                                                    Color.Black),
                                              xI1,
                                              128,
                                              xPrecision,
                                              128)
                Next
            Case 2
                Dim xLightness As Integer = CInt(inL.Value)
                For xI1 = 0 To 255 Step xPrecision
                    e1.Graphics.FillRectangle(New Drawing2D.LinearGradientBrush(
                                                    New Point(0, 0),
                                                    New Point(0, 256),
                                                    HSL2RGB(CInt(xI1 / 255 * 360), 1000, xLightness),
                                                    HSL2RGB(CInt(xI1 / 255 * 360), 0, xLightness)),
                                              xI1,
                                              0,
                                              xPrecision,
                                              256)
                Next
            Case 3
                Dim xRed As Integer = CInt(inR.Value)
                For xI1 = 0 To 255 Step xPrecision
                    e1.Graphics.FillRectangle(New Drawing2D.LinearGradientBrush(
                                                    New Point(0, 0),
                                                    New Point(0, 256),
                                                    Color.FromArgb(xRed, 255, xI1),
                                                    Color.FromArgb(xRed, 0, xI1)),
                                              xI1,
                                              0,
                                              xPrecision,
                                              256)
                Next
            Case 4
                Dim xGreen As Integer = CInt(inG.Value)
                For xI1 = 0 To 255 Step xPrecision
                    e1.Graphics.FillRectangle(New Drawing2D.LinearGradientBrush(
                                                    New Point(0, 0),
                                                    New Point(0, 256),
                                                    Color.FromArgb(255, xGreen, xI1),
                                                    Color.FromArgb(0, xGreen, xI1)),
                                              xI1,
                                              0,
                                              xPrecision,
                                              256)
                Next
            Case 5
                Dim xBlue As Integer = CInt(inB.Value)
                For xI1 = 0 To 255 Step xPrecision
                    e1.Graphics.FillRectangle(New Drawing2D.LinearGradientBrush(
                                                    New Point(0, 0),
                                                    New Point(0, 256),
                                                    Color.FromArgb(255, xI1, xBlue),
                                                    Color.FromArgb(0, xI1, xBlue)),
                                              xI1,
                                              0,
                                              xPrecision,
                                              256)
                Next
        End Select

        e1.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        e1.Graphics.DrawEllipse(CType(IIf(inL.Value > 500, Pens.Black, Pens.White), Pen), mMain.X - 4, mMain.Y - 4, 8, 8)

        e1.Render(PCMain.CreateGraphics)
        e1.Dispose()
    End Sub

    Private Sub rbH_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbH.CheckedChanged
        If rbH.Checked Then DrawingIndex = 0 : SetCursor() : RefreshMain(PCMain.DisplayRectangle) : Refresh1(PC1.DisplayRectangle) : RefreshA(PCA.DisplayRectangle)
    End Sub

    Private Sub rbS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbS.CheckedChanged
        If rbS.Checked Then DrawingIndex = 1 : SetCursor() : RefreshMain(PCMain.DisplayRectangle) : Refresh1(PC1.DisplayRectangle) : RefreshA(PCA.DisplayRectangle)
    End Sub

    Private Sub rbL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbL.CheckedChanged
        If rbL.Checked Then DrawingIndex = 2 : SetCursor() : RefreshMain(PCMain.DisplayRectangle) : Refresh1(PC1.DisplayRectangle) : RefreshA(PCA.DisplayRectangle)
    End Sub

    Private Sub rbR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbR.CheckedChanged
        If rbR.Checked Then DrawingIndex = 3 : SetCursor() : RefreshMain(PCMain.DisplayRectangle) : Refresh1(PC1.DisplayRectangle) : RefreshA(PCA.DisplayRectangle)
    End Sub

    Private Sub rbG_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbG.CheckedChanged
        If rbG.Checked Then DrawingIndex = 4 : SetCursor() : RefreshMain(PCMain.DisplayRectangle) : Refresh1(PC1.DisplayRectangle) : RefreshA(PCA.DisplayRectangle)
    End Sub

    Private Sub rbB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbB.CheckedChanged
        If rbB.Checked Then DrawingIndex = 5 : SetCursor() : RefreshMain(PCMain.DisplayRectangle) : Refresh1(PC1.DisplayRectangle) : RefreshA(PCA.DisplayRectangle)
    End Sub

    Private Sub inH_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inH.ValueChanged
        If inH.Value = 360 Then inH.Value = 0

        If PassiveValueChange Then Exit Sub
        PassiveValueChange = True
        SetNewColor(HSL2RGB(CInt(inH.Value), CInt(inS.Value), CInt(inL.Value), CInt(inA.Value)))
        inR.Value = NewColor.R
        inG.Value = NewColor.G
        inB.Value = NewColor.B

        RefreshMain(PCMain.DisplayRectangle)
        Refresh1(PC1.DisplayRectangle)
        RefreshA(PCA.DisplayRectangle)
        PassiveValueChange = False
    End Sub

    Private Sub inS_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inS.ValueChanged
        If PassiveValueChange Then Exit Sub
        PassiveValueChange = True
        SetNewColor(HSL2RGB(CInt(inH.Value), CInt(inS.Value), CInt(inL.Value), CInt(inA.Value)))
        inR.Value = NewColor.R
        inG.Value = NewColor.G
        inB.Value = NewColor.B

        RefreshMain(PCMain.DisplayRectangle)
        Refresh1(PC1.DisplayRectangle)
        RefreshA(PCA.DisplayRectangle)
        PassiveValueChange = False
    End Sub

    Private Sub inL_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inL.ValueChanged
        If PassiveValueChange Then Exit Sub
        PassiveValueChange = True
        SetNewColor(HSL2RGB(CInt(inH.Value), CInt(inS.Value), CInt(inL.Value), CInt(inA.Value)))
        inR.Value = NewColor.R
        inG.Value = NewColor.G
        inB.Value = NewColor.B

        RefreshMain(PCMain.DisplayRectangle)
        Refresh1(PC1.DisplayRectangle)
        RefreshA(PCA.DisplayRectangle)
        PassiveValueChange = False
    End Sub

    Private Sub inR_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inR.ValueChanged
        If PassiveValueChange Then Exit Sub
        PassiveValueChange = True
        SetNewColor(Color.FromArgb(CInt(inA.Value), CInt(inR.Value), CInt(inG.Value), CInt(inB.Value)))
        inH.Value = CDec(NewColor.GetHue)
        inS.Value = CDec(NewColor.GetSaturation * 1000)
        inL.Value = CDec(NewColor.GetBrightness * 1000)

        RefreshMain(PCMain.DisplayRectangle)
        Refresh1(PC1.DisplayRectangle)
        RefreshA(PCA.DisplayRectangle)
        PassiveValueChange = False
    End Sub

    Private Sub inG_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inG.ValueChanged
        If PassiveValueChange Then Exit Sub
        PassiveValueChange = True
        SetNewColor(Color.FromArgb(CInt(inA.Value), CInt(inR.Value), CInt(inG.Value), CInt(inB.Value)))
        inH.Value = CDec(NewColor.GetHue)
        inS.Value = CDec(NewColor.GetSaturation * 1000)
        inL.Value = CDec(NewColor.GetBrightness * 1000)

        RefreshMain(PCMain.DisplayRectangle)
        Refresh1(PC1.DisplayRectangle)
        RefreshA(PCA.DisplayRectangle)
        PassiveValueChange = False
    End Sub

    Private Sub inB_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inB.ValueChanged
        If PassiveValueChange Then Exit Sub
        PassiveValueChange = True
        SetNewColor(Color.FromArgb(CInt(inA.Value), CInt(inR.Value), CInt(inG.Value), CInt(inB.Value)))
        inH.Value = CDec(NewColor.GetHue)
        inS.Value = CDec(NewColor.GetSaturation * 1000)
        inL.Value = CDec(NewColor.GetBrightness * 1000)

        RefreshMain(PCMain.DisplayRectangle)
        Refresh1(PC1.DisplayRectangle)
        RefreshA(PCA.DisplayRectangle)
        PassiveValueChange = False
    End Sub

    Private Sub inA_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inA.ValueChanged
        If PassiveValueChange Then Exit Sub
        PassiveValueChange = True
        SetNewColor(Color.FromArgb(CInt(inA.Value), CInt(inR.Value), CInt(inG.Value), CInt(inB.Value)))

        'RefreshMain(PCMain.DisplayRectangle)
        'Refresh1(PC1.DisplayRectangle)
        RefreshA(PCA.DisplayRectangle)
        PassiveValueChange = False
    End Sub

    Private Sub PC1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PC1.MouseDown
        PC1_MouseMove(sender, e)
    End Sub

    Private Sub PC1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PC1.MouseMove
        If Not e.Button = Windows.Forms.MouseButtons.Left Then Exit Sub
        m1 = e.Y
        If m1 < 0 Then m1 = 0
        If m1 > 255 Then m1 = 255

        Select Case DrawingIndex
            Case 0
                inH.Value = CDec(360 - m1 / 255 * 360)
            Case 1
                inS.Value = CDec(1000 - m1 / 255 * 1000)
            Case 2
                inL.Value = CDec(1000 - m1 / 255 * 1000)
            Case 3
                inR.Value = 255 - m1
            Case 4
                inG.Value = 255 - m1
            Case 5
                inB.Value = 255 - m1
        End Select
    End Sub

    Private Sub PC1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PC1.Paint
        Refresh1(e.ClipRectangle)
    End Sub

    Private Sub Refresh1(ByVal xRegion As Rectangle)
        Dim e1 As BufferedGraphics = BufferedGraphicsManager.Current.Allocate(PC1.CreateGraphics, xRegion)
        Dim xI1 As Integer
        Dim xWidth As Integer = PC1.DisplayRectangle.Width
        Dim xPrecision As Integer = tbPrecision.Value

        Select Case DrawingIndex
            Case 0
                Dim xxS As Integer = CInt(inS.Value)
                Dim xxL As Integer = CInt(inL.Value)
                For xI1 = 0 To 255 Step xPrecision
                    e1.Graphics.FillRectangle(New Drawing.SolidBrush(HSL2RGB(CInt((255 - xI1) / 255 * 360), xxS, xxL)), 0, xI1, xWidth, xPrecision)
                Next
            Case 1
                Dim xxH As Integer = CInt(inH.Value)
                Dim xxL As Integer = CInt(inL.Value)
                e1.Graphics.FillRectangle(New Drawing2D.LinearGradientBrush(
                                                New Point(0, 0),
                                                New Point(0, 256),
                                                HSL2RGB(xxH, 1000, xxL),
                                                HSL2RGB(xxH, 0, xxL)),
                                            0, 0, xWidth, 256)
            Case 2
                Dim xxH As Integer = CInt(inH.Value)
                Dim xxS As Integer = CInt(inS.Value)
                e1.Graphics.FillRectangle(New Drawing2D.LinearGradientBrush(
                                                     New Point(0, 0),
                                                     New Point(0, 128),
                                                     HSL2RGB(xxH, xxS, 1000),
                                                     HSL2RGB(xxH, xxS, 500)),
                                                 0, 0, xWidth, 128)
                e1.Graphics.FillRectangle(New Drawing2D.LinearGradientBrush(
                                                     New Point(0, 128),
                                                     New Point(0, 256),
                                                     HSL2RGB(xxH, xxS, 500),
                                                     HSL2RGB(xxH, xxS, 0)),
                                                 0, 128, xWidth, 128)
            Case 3
                Dim xxG As Integer = CInt(inG.Value)
                Dim xxB As Integer = CInt(inB.Value)
                e1.Graphics.FillRectangle(New Drawing2D.LinearGradientBrush(
                                                New Point(0, 0),
                                                New Point(0, 256),
                                                Color.FromArgb(255, xxG, xxB),
                                                Color.FromArgb(0, xxG, xxB)),
                                            0, 0, xWidth, 256)
            Case 4
                Dim xxR As Integer = CInt(inR.Value)
                Dim xxB As Integer = CInt(inB.Value)
                e1.Graphics.FillRectangle(New Drawing2D.LinearGradientBrush(
                                                New Point(0, 0),
                                                New Point(0, 256),
                                                Color.FromArgb(xxR, 255, xxB),
                                                Color.FromArgb(xxR, 0, xxB)),
                                            0, 0, xWidth, 256)
            Case 5
                Dim xxR As Integer = CInt(inR.Value)
                Dim xxG As Integer = CInt(inG.Value)
                e1.Graphics.FillRectangle(New Drawing2D.LinearGradientBrush(
                                                New Point(0, 0),
                                                New Point(0, 256),
                                                Color.FromArgb(xxR, xxG, 255),
                                                Color.FromArgb(xxR, xxG, 0)),
                                            0, 0, xWidth, 256)
        End Select

        Dim xTri1() As Point = {New Point(4, m1), New Point(-1, m1 - 2), New Point(-1, m1 + 2)}
        Dim xTri2() As Point = {New Point(xWidth - 5, m1), New Point(xWidth, m1 - 2), New Point(xWidth, m1 + 2)}

        e1.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        e1.Graphics.FillPolygon(CType(IIf(inL.Value > 500, Brushes.Black, Brushes.White), Brush), xTri1)
        e1.Graphics.FillPolygon(CType(IIf(inL.Value > 500, Brushes.Black, Brushes.White), Brush), xTri2)

        e1.Render(PC1.CreateGraphics)
        e1.Dispose()
    End Sub

    Private Sub PCA_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PCA.MouseDown
        PCA_MouseMove(sender, e)
    End Sub

    Private Sub PCA_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PCA.MouseMove
        If Not e.Button = Windows.Forms.MouseButtons.Left Then Exit Sub
        mAlpha = e.X
        If mAlpha < 0 Then mAlpha = 0
        If mAlpha > 255 Then mAlpha = 255

        inA.Value = mAlpha
    End Sub

    Private Sub PCA_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PCA.Paint
        RefreshA(e.ClipRectangle)
    End Sub

    Private Sub RefreshA(ByVal xRegion As Rectangle)
        Dim e1 As BufferedGraphics = BufferedGraphicsManager.Current.Allocate(PCA.CreateGraphics, xRegion)
        Dim xI1 As Integer
        Dim xHeight As Integer = PCA.DisplayRectangle.Height
        Dim xPrecision As Integer = tbPrecision.Value
        Dim xColor As Color = Color.FromArgb(CInt(inR.Value), CInt(inG.Value), CInt(inB.Value))
        'Dim xAlphaRect(314) As Rectangle

        'e1.Graphics.FillRectangle(Brushes.White, PCA.DisplayRectangle)
        'For xI1 = 0 To 62
        '    xAlphaRect(xI1 * 5) = New Rectangle(xI1 * 8, 0, 4, 4)
        '    xAlphaRect(xI1 * 5 + 1) = New Rectangle(xI1 * 8 + 4, 4, 4, 4)
        '    xAlphaRect(xI1 * 5 + 2) = New Rectangle(xI1 * 8, 8, 4, 4)
        '    xAlphaRect(xI1 * 5 + 3) = New Rectangle(xI1 * 8 + 4, 12, 4, 4)
        '    xAlphaRect(xI1 * 5 + 4) = New Rectangle(xI1 * 8, 16, 4, 4)
        'Next
        'e1.Graphics.FillRectangles(New Drawing.SolidBrush(Color.FromArgb(235, 235, 235)), xAlphaRect)
        e1.Graphics.DrawImageUnscaledAndClipped(My.Resources.TransparentBG, xRegion)

        For xI1 = 0 To 255 Step xPrecision
            e1.Graphics.FillRectangle(New Drawing.SolidBrush(Color.FromArgb(xI1, xColor)), xI1, 0, xPrecision, xHeight)
        Next

        Dim xTri1() As Point = {New Point(mAlpha, 4), New Point(mAlpha - 2, -1), New Point(mAlpha + 2, -1)}
        Dim xTri2() As Point = {New Point(mAlpha, xHeight - 5), New Point(mAlpha - 2, xHeight), New Point(mAlpha + 2, xHeight)}
        xI1 = CInt(inL.Value + (255 - inA.Value) * 1000 / 255)

        e1.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        e1.Graphics.FillPolygon(CType(IIf(xI1 > 500, Brushes.Black, Brushes.White), Brush), xTri1)
        e1.Graphics.FillPolygon(CType(IIf(xI1 > 500, Brushes.Black, Brushes.White), Brush), xTri2)

        e1.Render(PCA.CreateGraphics)
        e1.Dispose()
    End Sub

    Private Sub tbPrecision_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbPrecision.ValueChanged
        RefreshMain(PCMain.DisplayRectangle)
        Refresh1(PC1.DisplayRectangle)
        RefreshA(PCA.DisplayRectangle)
    End Sub

    Private Sub pPrev_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pPrev.Paint
        RefreshPrev(e.ClipRectangle)
    End Sub

    Private Sub RefreshPrev(ByVal xRegion As Rectangle)
        Dim e1 As BufferedGraphics = BufferedGraphicsManager.Current.Allocate(pPrev.CreateGraphics, xRegion)
        Dim xFont As Font = pPrev.Font
        e1.Graphics.DrawImageUnscaledAndClipped(My.Resources.TransparentBG, xRegion)

        If xRegion.X < 62 Then
            e1.Graphics.FillRectangle(New Drawing.SolidBrush(OrigColor), 0, 0, 61, 28)
            e1.Graphics.DrawLine(New Pen(Color.FromKnownColor(KnownColor.WindowFrame)), 61, 0, 61, 28)
            e1.Graphics.DrawString("Orig", xFont, CType(IIf(OrigColor.GetBrightness + (255 - OrigColor.A) / 255 > 0.5, Brushes.Black, Brushes.White), Brush),
                                      31 - e1.Graphics.MeasureString("Orig", xFont).Width / 2,
                                      14 - e1.Graphics.MeasureString("Orig", xFont).Height / 2)
        End If

        e1.Graphics.FillRectangle(New Drawing.SolidBrush(NewColor), 62, 0, 61, 28)
        e1.Graphics.DrawString("New", xFont, CType(IIf(NewColor.GetBrightness + (255 - NewColor.A) / 255 > 0.5, Brushes.Black, Brushes.White), Brush),
                               93 - e1.Graphics.MeasureString("New", xFont).Width / 2,
                               14 - e1.Graphics.MeasureString("New", xFont).Height / 2)

        e1.Render(pPrev.CreateGraphics)
        e1.Dispose()
    End Sub

    Private Sub tStr_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tStr.GotFocus
        tStr.SelectAll()
    End Sub

    Private Sub tStr_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tStr.LostFocus
        Dim xI1 As Integer

        Try
            xI1 = Convert.ToInt32(tStr.Text, 16)
            SetNewColor(Color.FromArgb(xI1))

            PassiveValueChange = True
            inR.Value = NewColor.R
            inG.Value = NewColor.G
            inB.Value = NewColor.B
            inH.Value = CDec(NewColor.GetHue)
            inS.Value = CDec(NewColor.GetSaturation * 1000)
            inL.Value = CDec(NewColor.GetBrightness * 1000)
            inA.Value = NewColor.A
            SetCursor()

            RefreshMain(PCMain.DisplayRectangle)
            Refresh1(PC1.DisplayRectangle)
            RefreshA(PCA.DisplayRectangle)
            PassiveValueChange = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            tStr.Text = Mid("0000000" & Hex(NewColor.ToArgb), Len(Hex(NewColor.ToArgb)))
        End Try

    End Sub

    Private Sub tStr_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tStr.TextChanged
        If PassiveValueChange Then Exit Sub
        Dim xI1 As Integer

        Try
            xI1 = Convert.ToInt32(tStr.Text, 16)
            SetNewColor(Color.FromArgb(xI1), False)

            PassiveValueChange = True
            inR.Value = NewColor.R
            inG.Value = NewColor.G
            inB.Value = NewColor.B
            inH.Value = CDec(NewColor.GetHue)
            inS.Value = CDec(NewColor.GetSaturation * 1000)
            inL.Value = CDec(NewColor.GetBrightness * 1000)
            inA.Value = NewColor.A
            SetCursor()

            RefreshMain(PCMain.DisplayRectangle)
            Refresh1(PC1.DisplayRectangle)
            RefreshA(PCA.DisplayRectangle)
            PassiveValueChange = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ColorPicker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Font = MainWindow.Font
    End Sub
End Class
