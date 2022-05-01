<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpVisualOverride
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
        Me.components = New System.ComponentModel.Container()
        Me.LOverrides = New System.Windows.Forms.ListBox()
        Me.BRemove = New System.Windows.Forms.Button()
        Me.BAdd = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TLValues = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.BColorGradL = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BColorGradU = New System.Windows.Forms.Button()
        Me.TName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BColorSing = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TRangeU = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TRangeL = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PColorGrad = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.RColorGradHSLU = New System.Windows.Forms.RadioButton()
        Me.RColorSing = New System.Windows.Forms.RadioButton()
        Me.RColorGrad = New System.Windows.Forms.RadioButton()
        Me.RColorGradHSLD = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.BUp = New System.Windows.Forms.Button()
        Me.BDown = New System.Windows.Forms.Button()
        Me.BDuplicate = New System.Windows.Forms.Button()
        Me.BSplit = New System.Windows.Forms.Button()
        Me.BSemiAuto = New System.Windows.Forms.Button()
        Me.CBEnable = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CoBLoad = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CoBSave = New System.Windows.Forms.ComboBox()
        Me.TLValues.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'LOverrides
        '
        Me.LOverrides.FormattingEnabled = True
        Me.LOverrides.IntegralHeight = False
        Me.LOverrides.ItemHeight = 15
        Me.LOverrides.Items.AddRange(New Object() {"Drums", "Arps"})
        Me.LOverrides.Location = New System.Drawing.Point(14, 14)
        Me.LOverrides.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LOverrides.Name = "LOverrides"
        Me.LOverrides.Size = New System.Drawing.Size(133, 147)
        Me.LOverrides.TabIndex = 0
        '
        'BRemove
        '
        Me.BRemove.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BRemove.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BRemove.Location = New System.Drawing.Point(4, 120)
        Me.BRemove.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BRemove.Name = "BRemove"
        Me.BRemove.Size = New System.Drawing.Size(190, 27)
        Me.BRemove.TabIndex = 3
        Me.BRemove.Text = "Remove"
        Me.BRemove.UseVisualStyleBackColor = True
        '
        'BAdd
        '
        Me.BAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BAdd.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BAdd.Location = New System.Drawing.Point(4, 3)
        Me.BAdd.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BAdd.Name = "BAdd"
        Me.BAdd.Size = New System.Drawing.Size(190, 27)
        Me.BAdd.TabIndex = 0
        Me.BAdd.Text = "Add"
        Me.BAdd.UseVisualStyleBackColor = True
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK_Button.Location = New System.Drawing.Point(187, 472)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(78, 27)
        Me.OK_Button.TabIndex = 3
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(272, 472)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(78, 27)
        Me.Cancel_Button.TabIndex = 4
        Me.Cancel_Button.Text = "Cancel"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'TLValues
        '
        Me.TLValues.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TLValues.ColumnCount = 2
        Me.TLValues.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142.0!))
        Me.TLValues.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLValues.Controls.Add(Me.TableLayoutPanel7, 1, 3)
        Me.TLValues.Controls.Add(Me.TName, 1, 0)
        Me.TLValues.Controls.Add(Me.Label1, 0, 1)
        Me.TLValues.Controls.Add(Me.Label3, 0, 0)
        Me.TLValues.Controls.Add(Me.BColorSing, 1, 2)
        Me.TLValues.Controls.Add(Me.TableLayoutPanel2, 1, 1)
        Me.TLValues.Controls.Add(Me.Label4, 0, 2)
        Me.TLValues.Controls.Add(Me.Label2, 0, 3)
        Me.TLValues.Controls.Add(Me.Label6, 0, 4)
        Me.TLValues.Controls.Add(Me.PColorGrad, 1, 4)
        Me.TLValues.Location = New System.Drawing.Point(14, 305)
        Me.TLValues.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TLValues.Name = "TLValues"
        Me.TLValues.RowCount = 6
        Me.TLValues.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLValues.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLValues.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLValues.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLValues.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TLValues.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLValues.Size = New System.Drawing.Size(339, 161)
        Me.TLValues.TabIndex = 2
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel7.ColumnCount = 3
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.BColorGradL, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label8, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.BColorGradU, 2, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(142, 90)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(197, 30)
        Me.TableLayoutPanel7.TabIndex = 7
        '
        'BColorGradL
        '
        Me.BColorGradL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BColorGradL.Location = New System.Drawing.Point(4, 3)
        Me.BColorGradL.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BColorGradL.Name = "BColorGradL"
        Me.BColorGradL.Size = New System.Drawing.Size(74, 24)
        Me.BColorGradL.TabIndex = 6
        Me.BColorGradL.Text = "Button1"
        Me.BColorGradL.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(86, 0)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 30)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "to"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BColorGradU
        '
        Me.BColorGradU.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BColorGradU.Location = New System.Drawing.Point(117, 3)
        Me.BColorGradU.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BColorGradU.Name = "BColorGradU"
        Me.BColorGradU.Size = New System.Drawing.Size(76, 24)
        Me.BColorGradU.TabIndex = 6
        Me.BColorGradU.Text = "Button1"
        Me.BColorGradU.UseVisualStyleBackColor = True
        '
        'TName
        '
        Me.TName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TName.Location = New System.Drawing.Point(146, 3)
        Me.TName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TName.Name = "TName"
        Me.TName.Size = New System.Drawing.Size(189, 23)
        Me.TName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 30)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label Range"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 30)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Option Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BColorSing
        '
        Me.BColorSing.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BColorSing.Location = New System.Drawing.Point(146, 63)
        Me.BColorSing.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BColorSing.Name = "BColorSing"
        Me.BColorSing.Size = New System.Drawing.Size(189, 24)
        Me.BColorSing.TabIndex = 5
        Me.BColorSing.Text = "Button1"
        Me.BColorSing.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.TRangeU, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TRangeL, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(142, 30)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(197, 30)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'TRangeU
        '
        Me.TRangeU.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TRangeU.Location = New System.Drawing.Point(134, 3)
        Me.TRangeU.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TRangeU.MaxLength = 2
        Me.TRangeU.Name = "TRangeU"
        Me.TRangeU.Size = New System.Drawing.Size(59, 23)
        Me.TRangeU.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(69, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 30)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "to"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TRangeL
        '
        Me.TRangeL.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TRangeL.Location = New System.Drawing.Point(4, 3)
        Me.TRangeL.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TRangeL.MaxLength = 2
        Me.TRangeL.Name = "TRangeL"
        Me.TRangeL.Size = New System.Drawing.Size(57, 23)
        Me.TRangeL.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(4, 60)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 30)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Note Color"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(4, 90)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 30)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Note Color Range"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(4, 120)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 30)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Preview"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PColorGrad
        '
        Me.PColorGrad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PColorGrad.Location = New System.Drawing.Point(145, 123)
        Me.PColorGrad.Name = "PColorGrad"
        Me.PColorGrad.Size = New System.Drawing.Size(191, 24)
        Me.PColorGrad.TabIndex = 9
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel5, 0, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.BAdd, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BRemove, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.BSemiAuto, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.CBEnable, 0, 4)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(155, 14)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 6
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(198, 285)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.RColorGradHSLU, 0, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.RColorSing, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.RColorGrad, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.RColorGradHSLD, 0, 2)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 178)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 4
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(192, 104)
        Me.TableLayoutPanel5.TabIndex = 5
        '
        'RColorGradHSLU
        '
        Me.RColorGradHSLU.AutoSize = True
        Me.RColorGradHSLU.Location = New System.Drawing.Point(3, 81)
        Me.RColorGradHSLU.Name = "RColorGradHSLU"
        Me.RColorGradHSLU.Size = New System.Drawing.Size(139, 19)
        Me.RColorGradHSLU.TabIndex = 8
        Me.RColorGradHSLU.TabStop = True
        Me.RColorGradHSLU.Text = "Color gradient (HSL↓)"
        Me.RColorGradHSLU.UseVisualStyleBackColor = True
        '
        'RColorSing
        '
        Me.RColorSing.AutoSize = True
        Me.RColorSing.Location = New System.Drawing.Point(3, 3)
        Me.RColorSing.Name = "RColorSing"
        Me.RColorSing.Size = New System.Drawing.Size(98, 19)
        Me.RColorSing.TabIndex = 5
        Me.RColorSing.TabStop = True
        Me.RColorSing.Text = "Singular color"
        Me.RColorSing.UseVisualStyleBackColor = True
        '
        'RColorGrad
        '
        Me.RColorGrad.AutoSize = True
        Me.RColorGrad.Location = New System.Drawing.Point(3, 29)
        Me.RColorGrad.Name = "RColorGrad"
        Me.RColorGrad.Size = New System.Drawing.Size(101, 19)
        Me.RColorGrad.TabIndex = 6
        Me.RColorGrad.TabStop = True
        Me.RColorGrad.Text = "Color gradient"
        Me.RColorGrad.UseVisualStyleBackColor = True
        '
        'RColorGradHSLD
        '
        Me.RColorGradHSLD.AutoSize = True
        Me.RColorGradHSLD.Location = New System.Drawing.Point(3, 55)
        Me.RColorGradHSLD.Name = "RColorGradHSLD"
        Me.RColorGradHSLD.Size = New System.Drawing.Size(139, 19)
        Me.RColorGradHSLD.TabIndex = 7
        Me.RColorGradHSLD.TabStop = True
        Me.RColorGradHSLD.Text = "Color gradient (HSL↑)"
        Me.RColorGradHSLD.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.BUp, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.BDown, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.BDuplicate, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.BSplit, 1, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 36)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(192, 45)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'BUp
        '
        Me.BUp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BUp.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BUp.Location = New System.Drawing.Point(4, 3)
        Me.BUp.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BUp.Name = "BUp"
        Me.BUp.Size = New System.Drawing.Size(88, 16)
        Me.BUp.TabIndex = 0
        Me.BUp.Text = "Up"
        Me.BUp.UseVisualStyleBackColor = True
        '
        'BDown
        '
        Me.BDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BDown.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BDown.Location = New System.Drawing.Point(4, 25)
        Me.BDown.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BDown.Name = "BDown"
        Me.BDown.Size = New System.Drawing.Size(88, 17)
        Me.BDown.TabIndex = 0
        Me.BDown.Text = "Down"
        Me.BDown.UseVisualStyleBackColor = True
        '
        'BDuplicate
        '
        Me.BDuplicate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BDuplicate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BDuplicate.Location = New System.Drawing.Point(100, 3)
        Me.BDuplicate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BDuplicate.Name = "BDuplicate"
        Me.BDuplicate.Size = New System.Drawing.Size(88, 16)
        Me.BDuplicate.TabIndex = 0
        Me.BDuplicate.Text = "Duplicate"
        Me.BDuplicate.UseVisualStyleBackColor = True
        '
        'BSplit
        '
        Me.BSplit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BSplit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BSplit.Location = New System.Drawing.Point(100, 25)
        Me.BSplit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BSplit.Name = "BSplit"
        Me.BSplit.Size = New System.Drawing.Size(88, 17)
        Me.BSplit.TabIndex = 0
        Me.BSplit.Text = "Split"
        Me.BSplit.UseVisualStyleBackColor = True
        '
        'BSemiAuto
        '
        Me.BSemiAuto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BSemiAuto.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BSemiAuto.Location = New System.Drawing.Point(4, 87)
        Me.BSemiAuto.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BSemiAuto.Name = "BSemiAuto"
        Me.BSemiAuto.Size = New System.Drawing.Size(190, 27)
        Me.BSemiAuto.TabIndex = 2
        Me.BSemiAuto.Text = "Semi-auto assign"
        Me.BSemiAuto.UseVisualStyleBackColor = True
        '
        'CBEnable
        '
        Me.CBEnable.AutoSize = True
        Me.CBEnable.Location = New System.Drawing.Point(3, 153)
        Me.CBEnable.Name = "CBEnable"
        Me.CBEnable.Size = New System.Drawing.Size(88, 19)
        Me.CBEnable.TabIndex = 4
        Me.CBEnable.Text = "Enable Item"
        Me.CBEnable.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 168)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Load Settings From:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CoBLoad
        '
        Me.CoBLoad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CoBLoad.FormattingEnabled = True
        Me.CoBLoad.Items.AddRange(New Object() {"Editor", "Chart", "Song"})
        Me.CoBLoad.Location = New System.Drawing.Point(14, 191)
        Me.CoBLoad.Name = "CoBLoad"
        Me.CoBLoad.Size = New System.Drawing.Size(133, 23)
        Me.CoBLoad.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 221)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 15)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Save Settings To:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CoBSave
        '
        Me.CoBSave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CoBSave.FormattingEnabled = True
        Me.CoBSave.Items.AddRange(New Object() {"Editor", "Chart", "Song"})
        Me.CoBSave.Location = New System.Drawing.Point(14, 243)
        Me.CoBSave.Name = "CoBSave"
        Me.CoBSave.Size = New System.Drawing.Size(133, 23)
        Me.CoBSave.TabIndex = 5
        '
        'OpVisualOverride
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(364, 513)
        Me.Controls.Add(Me.CoBSave)
        Me.Controls.Add(Me.CoBLoad)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LOverrides)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TLValues)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OpVisualOverride"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Visual Override Options"
        Me.TLValues.ResumeLayout(False)
        Me.TLValues.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LOverrides As ListBox
    Friend WithEvents BRemove As Button
    Friend WithEvents BAdd As Button
    Friend WithEvents OK_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TLValues As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TName As TextBox
    Friend WithEvents BColorSing As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TRangeU As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TRangeL As TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents RColorSing As RadioButton
    Friend WithEvents RColorGrad As RadioButton
    Friend WithEvents RColorGradHSLD As RadioButton
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents BUp As Button
    Friend WithEvents BDown As Button
    Friend WithEvents BDuplicate As Button
    Friend WithEvents BSplit As Button
    Friend WithEvents BSemiAuto As Button
    Friend WithEvents CBEnable As CheckBox
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BColorGradL As Button
    Friend WithEvents BColorGradU As Button
    Friend WithEvents PColorGrad As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents CoBLoad As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CoBSave As ComboBox
    Friend WithEvents RColorGradHSLU As RadioButton
End Class
