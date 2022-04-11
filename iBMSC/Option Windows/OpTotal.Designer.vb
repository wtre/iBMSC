<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpTotal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CTotalIIDX1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CTotalIIDX2 = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CTotalMultiplier = New System.Windows.Forms.RadioButton()
        Me.LTotalIIDX1 = New System.Windows.Forms.Label()
        Me.LTotalIIDX2 = New System.Windows.Forms.Label()
        Me.LTotalMultiplier = New System.Windows.Forms.Label()
        Me.TMultiplier = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.CBDisplayText = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TGlobalMultiplier = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'CTotalIIDX1
        '
        Me.CTotalIIDX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CTotalIIDX1.AutoSize = True
        Me.CTotalIIDX1.Location = New System.Drawing.Point(4, 20)
        Me.CTotalIIDX1.Name = "CTotalIIDX1"
        Me.CTotalIIDX1.Size = New System.Drawing.Size(163, 19)
        Me.CTotalIIDX1.TabIndex = 1
        Me.CTotalIIDX1.TabStop = True
        Me.CTotalIIDX1.Text = "IIDX #TOTAL Supposition 1"
        Me.CTotalIIDX1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(4, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "#TOTAL Calculation Option"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CTotalIIDX2
        '
        Me.CTotalIIDX2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CTotalIIDX2.AutoSize = True
        Me.CTotalIIDX2.Location = New System.Drawing.Point(4, 46)
        Me.CTotalIIDX2.Name = "CTotalIIDX2"
        Me.CTotalIIDX2.Size = New System.Drawing.Size(163, 60)
        Me.CTotalIIDX2.TabIndex = 2
        Me.CTotalIIDX2.TabStop = True
        Me.CTotalIIDX2.Text = "IIDX #TOTAL Supposition 2"
        Me.CTotalIIDX2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CTotalIIDX1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.CTotalIIDX2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.CTotalMultiplier, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LTotalIIDX1, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LTotalIIDX2, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LTotalMultiplier, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TMultiplier, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 3, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(570, 140)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.AutoSize = True
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.Controls.Add(Me.Label9, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label10, 0, 1)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(346, 46)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(219, 60)
        Me.TableLayoutPanel4.TabIndex = 113
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Location = New System.Drawing.Point(3, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(213, 20)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Notes > 600 ? 360 + (Notes - 600) / 5"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(213, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Notes < 400 ? 200 + Notes / 5 :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Location = New System.Drawing.Point(3, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(213, 20)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Notes < 600 ? 280 + (Notes - 400) / 2.5 :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(346, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(220, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Calculation Formula"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(281, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "#TOTAL"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(174, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Parameters"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CTotalMultiplier
        '
        Me.CTotalMultiplier.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CTotalMultiplier.AutoSize = True
        Me.CTotalMultiplier.Location = New System.Drawing.Point(4, 113)
        Me.CTotalMultiplier.Name = "CTotalMultiplier"
        Me.CTotalMultiplier.Size = New System.Drawing.Size(163, 23)
        Me.CTotalMultiplier.TabIndex = 3
        Me.CTotalMultiplier.TabStop = True
        Me.CTotalMultiplier.Text = "Multiplier"
        Me.CTotalMultiplier.UseVisualStyleBackColor = True
        '
        'LTotalIIDX1
        '
        Me.LTotalIIDX1.AutoSize = True
        Me.LTotalIIDX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LTotalIIDX1.Location = New System.Drawing.Point(281, 17)
        Me.LTotalIIDX1.Name = "LTotalIIDX1"
        Me.LTotalIIDX1.Size = New System.Drawing.Size(58, 25)
        Me.LTotalIIDX1.TabIndex = 7
        Me.LTotalIIDX1.Text = "IIDX 1"
        Me.LTotalIIDX1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LTotalIIDX2
        '
        Me.LTotalIIDX2.AutoSize = True
        Me.LTotalIIDX2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LTotalIIDX2.Location = New System.Drawing.Point(281, 43)
        Me.LTotalIIDX2.Name = "LTotalIIDX2"
        Me.LTotalIIDX2.Size = New System.Drawing.Size(58, 66)
        Me.LTotalIIDX2.TabIndex = 8
        Me.LTotalIIDX2.Text = "IIDX 2"
        Me.LTotalIIDX2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LTotalMultiplier
        '
        Me.LTotalMultiplier.AutoSize = True
        Me.LTotalMultiplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LTotalMultiplier.Location = New System.Drawing.Point(281, 110)
        Me.LTotalMultiplier.Name = "LTotalMultiplier"
        Me.LTotalMultiplier.Size = New System.Drawing.Size(58, 29)
        Me.LTotalMultiplier.TabIndex = 9
        Me.LTotalMultiplier.Text = "Multiplier"
        Me.LTotalMultiplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TMultiplier
        '
        Me.TMultiplier.Location = New System.Drawing.Point(174, 113)
        Me.TMultiplier.Name = "TMultiplier"
        Me.TMultiplier.Size = New System.Drawing.Size(100, 23)
        Me.TMultiplier.TabIndex = 6
        Me.TMultiplier.Text = "0.25"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(346, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(220, 25)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "7.605 * Notes / (0.01 * Notes + 6.5)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(346, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(220, 29)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Notes * Multiplier"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(418, 180)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(170, 33)
        Me.TableLayoutPanel2.TabIndex = 100
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(78, 27)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(88, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(78, 27)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'CBDisplayText
        '
        Me.CBDisplayText.AutoSize = True
        Me.CBDisplayText.Checked = True
        Me.CBDisplayText.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBDisplayText.Location = New System.Drawing.Point(186, 158)
        Me.CBDisplayText.Name = "CBDisplayText"
        Me.CBDisplayText.Size = New System.Drawing.Size(200, 19)
        Me.CBDisplayText.TabIndex = 2
        Me.CBDisplayText.Text = "Display ""Recommended #TOTAL"""
        Me.CBDisplayText.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TGlobalMultiplier, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(12, 158)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(167, 28)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'TGlobalMultiplier
        '
        Me.TGlobalMultiplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TGlobalMultiplier.Location = New System.Drawing.Point(104, 3)
        Me.TGlobalMultiplier.Name = "TGlobalMultiplier"
        Me.TGlobalMultiplier.Size = New System.Drawing.Size(60, 23)
        Me.TGlobalMultiplier.TabIndex = 1
        Me.TGlobalMultiplier.Text = "1.0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 28)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Global Multiplier"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OpTotal
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(600, 225)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.CBDisplayText)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OpTotal"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "#TOTAL Settings"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CTotalIIDX1 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents CTotalIIDX2 As RadioButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents CTotalMultiplier As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents OK_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents LTotalIIDX1 As Label
    Friend WithEvents LTotalIIDX2 As Label
    Friend WithEvents LTotalMultiplier As Label
    Friend WithEvents CBDisplayText As CheckBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TMultiplier As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TGlobalMultiplier As TextBox
    Friend WithEvents Label5 As Label
End Class
