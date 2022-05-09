<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dgFind
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dgFind))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mr1 = New System.Windows.Forms.NumericUpDown()
        Me.mr2 = New System.Windows.Forms.NumericUpDown()
        Me.lr1 = New System.Windows.Forms.TextBox()
        Me.lr2 = New System.Windows.Forms.TextBox()
        Me.vr2 = New System.Windows.Forms.NumericUpDown()
        Me.vr1 = New System.Windows.Forms.NumericUpDown()
        Me.cb1 = New System.Windows.Forms.CheckBox()
        Me.cb2 = New System.Windows.Forms.CheckBox()
        Me.cba1 = New System.Windows.Forms.CheckBox()
        Me.cba2 = New System.Windows.Forms.CheckBox()
        Me.cba3 = New System.Windows.Forms.CheckBox()
        Me.cba4 = New System.Windows.Forms.CheckBox()
        Me.cba5 = New System.Windows.Forms.CheckBox()
        Me.cba6 = New System.Windows.Forms.CheckBox()
        Me.cba7 = New System.Windows.Forms.CheckBox()
        Me.cba8 = New System.Windows.Forms.CheckBox()
        Me.cbd1 = New System.Windows.Forms.CheckBox()
        Me.cbd2 = New System.Windows.Forms.CheckBox()
        Me.cbd3 = New System.Windows.Forms.CheckBox()
        Me.cbd4 = New System.Windows.Forms.CheckBox()
        Me.cbd5 = New System.Windows.Forms.CheckBox()
        Me.cbd6 = New System.Windows.Forms.CheckBox()
        Me.cbd7 = New System.Windows.Forms.CheckBox()
        Me.cbd8 = New System.Windows.Forms.CheckBox()
        Me.cb3 = New System.Windows.Forms.CheckBox()
        Me.cb4 = New System.Windows.Forms.CheckBox()
        Me.cb5 = New System.Windows.Forms.CheckBox()
        Me.cbb1 = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BSAll = New System.Windows.Forms.Button()
        Me.BSInv = New System.Windows.Forms.Button()
        Me.BSNone = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBSelect = New System.Windows.Forms.Button()
        Me.TBClose = New System.Windows.Forms.Button()
        Me.TBDelete = New System.Windows.Forms.Button()
        Me.TBrl = New System.Windows.Forms.Button()
        Me.TBrv = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Ttv = New System.Windows.Forms.NumericUpDown()
        Me.Ttl = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CBSelected = New System.Windows.Forms.CheckBox()
        Me.CBUnselected = New System.Windows.Forms.CheckBox()
        Me.CBShort = New System.Windows.Forms.CheckBox()
        Me.TBUnselect = New System.Windows.Forms.Button()
        Me.CBLong = New System.Windows.Forms.CheckBox()
        Me.CBHidden = New System.Windows.Forms.CheckBox()
        Me.CBVisible = New System.Windows.Forms.CheckBox()
        Me.FNotePrevious = New System.Windows.Forms.Button()
        Me.FNoteNext = New System.Windows.Forms.Button()
        Me.TLNoteRange = New System.Windows.Forms.TableLayoutPanel()
        Me.CBError = New System.Windows.Forms.CheckBox()
        Me.CBNoError = New System.Windows.Forms.CheckBox()
        Me.CBComment = New System.Windows.Forms.CheckBox()
        Me.CBNotComment = New System.Windows.Forms.CheckBox()
        CType(Me.mr1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mr2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vr2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vr1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Ttv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLNoteRange.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Note Type"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Measure Range"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mr1
        '
        Me.mr1.Location = New System.Drawing.Point(134, 72)
        Me.mr1.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.mr1.Name = "mr1"
        Me.mr1.Size = New System.Drawing.Size(70, 23)
        Me.mr1.TabIndex = 3
        '
        'mr2
        '
        Me.mr2.Location = New System.Drawing.Point(240, 72)
        Me.mr2.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.mr2.Name = "mr2"
        Me.mr2.Size = New System.Drawing.Size(70, 23)
        Me.mr2.TabIndex = 5
        Me.mr2.Value = New Decimal(New Integer() {999, 0, 0, 0})
        '
        'lr1
        '
        Me.lr1.Location = New System.Drawing.Point(134, 101)
        Me.lr1.MaxLength = 2
        Me.lr1.Name = "lr1"
        Me.lr1.Size = New System.Drawing.Size(70, 23)
        Me.lr1.TabIndex = 7
        Me.lr1.Text = "01"
        '
        'lr2
        '
        Me.lr2.Location = New System.Drawing.Point(240, 101)
        Me.lr2.MaxLength = 2
        Me.lr2.Name = "lr2"
        Me.lr2.Size = New System.Drawing.Size(70, 23)
        Me.lr2.TabIndex = 9
        Me.lr2.Text = "ZZ"
        '
        'vr2
        '
        Me.vr2.DecimalPlaces = 4
        Me.vr2.Location = New System.Drawing.Point(240, 130)
        Me.vr2.Maximum = New Decimal(New Integer() {655359999, 0, 0, 262144})
        Me.vr2.Minimum = New Decimal(New Integer() {1, 0, 0, 262144})
        Me.vr2.Name = "vr2"
        Me.vr2.Size = New System.Drawing.Size(100, 23)
        Me.vr2.TabIndex = 13
        Me.vr2.Value = New Decimal(New Integer() {655359999, 0, 0, 262144})
        '
        'vr1
        '
        Me.vr1.DecimalPlaces = 4
        Me.vr1.Location = New System.Drawing.Point(134, 130)
        Me.vr1.Maximum = New Decimal(New Integer() {655359999, 0, 0, 262144})
        Me.vr1.Minimum = New Decimal(New Integer() {1, 0, 0, 262144})
        Me.vr1.Name = "vr1"
        Me.vr1.Size = New System.Drawing.Size(70, 23)
        Me.vr1.TabIndex = 11
        Me.vr1.Value = New Decimal(New Integer() {1, 0, 0, 262144})
        '
        'cb1
        '
        Me.cb1.Appearance = System.Windows.Forms.Appearance.Button
        Me.cb1.Checked = True
        Me.cb1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb1.Location = New System.Drawing.Point(3, 2)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(50, 25)
        Me.cb1.TabIndex = 0
        Me.cb1.Tag = "1"
        Me.cb1.Text = "BPM"
        Me.cb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cb1.UseVisualStyleBackColor = False
        '
        'cb2
        '
        Me.cb2.Appearance = System.Windows.Forms.Appearance.Button
        Me.cb2.Checked = True
        Me.cb2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb2.Location = New System.Drawing.Point(53, 2)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(50, 25)
        Me.cb2.TabIndex = 1
        Me.cb2.Tag = "2"
        Me.cb2.Text = "STOP"
        Me.cb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cb2.UseVisualStyleBackColor = True
        '
        'cba1
        '
        Me.cba1.Appearance = System.Windows.Forms.Appearance.Button
        Me.cba1.Checked = True
        Me.cba1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cba1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cba1.Location = New System.Drawing.Point(3, 27)
        Me.cba1.Name = "cba1"
        Me.cba1.Size = New System.Drawing.Size(35, 25)
        Me.cba1.TabIndex = 2
        Me.cba1.Tag = "4"
        Me.cba1.Text = "A1"
        Me.cba1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cba1.UseVisualStyleBackColor = True
        '
        'cba2
        '
        Me.cba2.Appearance = System.Windows.Forms.Appearance.Button
        Me.cba2.Checked = True
        Me.cba2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cba2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cba2.Location = New System.Drawing.Point(38, 27)
        Me.cba2.Name = "cba2"
        Me.cba2.Size = New System.Drawing.Size(35, 25)
        Me.cba2.TabIndex = 3
        Me.cba2.Tag = "5"
        Me.cba2.Text = "A2"
        Me.cba2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cba2.UseVisualStyleBackColor = True
        '
        'cba3
        '
        Me.cba3.Appearance = System.Windows.Forms.Appearance.Button
        Me.cba3.Checked = True
        Me.cba3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cba3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cba3.Location = New System.Drawing.Point(73, 27)
        Me.cba3.Name = "cba3"
        Me.cba3.Size = New System.Drawing.Size(35, 25)
        Me.cba3.TabIndex = 4
        Me.cba3.Tag = "6"
        Me.cba3.Text = "A3"
        Me.cba3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cba3.UseVisualStyleBackColor = True
        '
        'cba4
        '
        Me.cba4.Appearance = System.Windows.Forms.Appearance.Button
        Me.cba4.Checked = True
        Me.cba4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cba4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cba4.Location = New System.Drawing.Point(108, 27)
        Me.cba4.Name = "cba4"
        Me.cba4.Size = New System.Drawing.Size(35, 25)
        Me.cba4.TabIndex = 5
        Me.cba4.Tag = "7"
        Me.cba4.Text = "A4"
        Me.cba4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cba4.UseVisualStyleBackColor = True
        '
        'cba5
        '
        Me.cba5.Appearance = System.Windows.Forms.Appearance.Button
        Me.cba5.Checked = True
        Me.cba5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cba5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cba5.Location = New System.Drawing.Point(143, 27)
        Me.cba5.Name = "cba5"
        Me.cba5.Size = New System.Drawing.Size(35, 25)
        Me.cba5.TabIndex = 6
        Me.cba5.Tag = "8"
        Me.cba5.Text = "A5"
        Me.cba5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cba5.UseVisualStyleBackColor = True
        '
        'cba6
        '
        Me.cba6.Appearance = System.Windows.Forms.Appearance.Button
        Me.cba6.Checked = True
        Me.cba6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cba6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cba6.Location = New System.Drawing.Point(178, 27)
        Me.cba6.Name = "cba6"
        Me.cba6.Size = New System.Drawing.Size(35, 25)
        Me.cba6.TabIndex = 7
        Me.cba6.Tag = "9"
        Me.cba6.Text = "A6"
        Me.cba6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cba6.UseVisualStyleBackColor = True
        '
        'cba7
        '
        Me.cba7.Appearance = System.Windows.Forms.Appearance.Button
        Me.cba7.Checked = True
        Me.cba7.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cba7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cba7.Location = New System.Drawing.Point(213, 27)
        Me.cba7.Name = "cba7"
        Me.cba7.Size = New System.Drawing.Size(35, 25)
        Me.cba7.TabIndex = 8
        Me.cba7.Tag = "10"
        Me.cba7.Text = "A7"
        Me.cba7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cba7.UseVisualStyleBackColor = True
        '
        'cba8
        '
        Me.cba8.Appearance = System.Windows.Forms.Appearance.Button
        Me.cba8.Checked = True
        Me.cba8.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cba8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cba8.Location = New System.Drawing.Point(248, 27)
        Me.cba8.Name = "cba8"
        Me.cba8.Size = New System.Drawing.Size(35, 25)
        Me.cba8.TabIndex = 9
        Me.cba8.Tag = "11"
        Me.cba8.Text = "A8"
        Me.cba8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cba8.UseVisualStyleBackColor = True
        '
        'cbd1
        '
        Me.cbd1.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbd1.Checked = True
        Me.cbd1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbd1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbd1.Location = New System.Drawing.Point(3, 52)
        Me.cbd1.Name = "cbd1"
        Me.cbd1.Size = New System.Drawing.Size(35, 25)
        Me.cbd1.TabIndex = 10
        Me.cbd1.Tag = "13"
        Me.cbd1.Text = "D1"
        Me.cbd1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbd1.UseVisualStyleBackColor = True
        '
        'cbd2
        '
        Me.cbd2.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbd2.Checked = True
        Me.cbd2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbd2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbd2.Location = New System.Drawing.Point(38, 52)
        Me.cbd2.Name = "cbd2"
        Me.cbd2.Size = New System.Drawing.Size(35, 25)
        Me.cbd2.TabIndex = 11
        Me.cbd2.Tag = "14"
        Me.cbd2.Text = "D2"
        Me.cbd2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbd2.UseVisualStyleBackColor = True
        '
        'cbd3
        '
        Me.cbd3.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbd3.Checked = True
        Me.cbd3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbd3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbd3.Location = New System.Drawing.Point(73, 52)
        Me.cbd3.Name = "cbd3"
        Me.cbd3.Size = New System.Drawing.Size(35, 25)
        Me.cbd3.TabIndex = 12
        Me.cbd3.Tag = "15"
        Me.cbd3.Text = "D3"
        Me.cbd3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbd3.UseVisualStyleBackColor = True
        '
        'cbd4
        '
        Me.cbd4.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbd4.Checked = True
        Me.cbd4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbd4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbd4.Location = New System.Drawing.Point(108, 52)
        Me.cbd4.Name = "cbd4"
        Me.cbd4.Size = New System.Drawing.Size(35, 25)
        Me.cbd4.TabIndex = 13
        Me.cbd4.Tag = "16"
        Me.cbd4.Text = "D4"
        Me.cbd4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbd4.UseVisualStyleBackColor = True
        '
        'cbd5
        '
        Me.cbd5.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbd5.Checked = True
        Me.cbd5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbd5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbd5.Location = New System.Drawing.Point(143, 52)
        Me.cbd5.Name = "cbd5"
        Me.cbd5.Size = New System.Drawing.Size(35, 25)
        Me.cbd5.TabIndex = 14
        Me.cbd5.Tag = "17"
        Me.cbd5.Text = "D5"
        Me.cbd5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbd5.UseVisualStyleBackColor = True
        '
        'cbd6
        '
        Me.cbd6.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbd6.Checked = True
        Me.cbd6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbd6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbd6.Location = New System.Drawing.Point(178, 52)
        Me.cbd6.Name = "cbd6"
        Me.cbd6.Size = New System.Drawing.Size(35, 25)
        Me.cbd6.TabIndex = 15
        Me.cbd6.Tag = "18"
        Me.cbd6.Text = "D6"
        Me.cbd6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbd6.UseVisualStyleBackColor = True
        '
        'cbd7
        '
        Me.cbd7.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbd7.Checked = True
        Me.cbd7.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbd7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbd7.Location = New System.Drawing.Point(213, 52)
        Me.cbd7.Name = "cbd7"
        Me.cbd7.Size = New System.Drawing.Size(35, 25)
        Me.cbd7.TabIndex = 16
        Me.cbd7.Tag = "19"
        Me.cbd7.Text = "D7"
        Me.cbd7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbd7.UseVisualStyleBackColor = True
        '
        'cbd8
        '
        Me.cbd8.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbd8.Checked = True
        Me.cbd8.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbd8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbd8.Location = New System.Drawing.Point(248, 52)
        Me.cbd8.Name = "cbd8"
        Me.cbd8.Size = New System.Drawing.Size(35, 25)
        Me.cbd8.TabIndex = 17
        Me.cbd8.Tag = "20"
        Me.cbd8.Text = "D8"
        Me.cbd8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbd8.UseVisualStyleBackColor = True
        '
        'cb3
        '
        Me.cb3.Appearance = System.Windows.Forms.Appearance.Button
        Me.cb3.Checked = True
        Me.cb3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb3.Location = New System.Drawing.Point(3, 77)
        Me.cb3.Name = "cb3"
        Me.cb3.Size = New System.Drawing.Size(55, 25)
        Me.cb3.TabIndex = 18
        Me.cb3.Tag = "22"
        Me.cb3.Text = "BGA"
        Me.cb3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cb3.UseVisualStyleBackColor = True
        '
        'cb4
        '
        Me.cb4.Appearance = System.Windows.Forms.Appearance.Button
        Me.cb4.Checked = True
        Me.cb4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb4.Location = New System.Drawing.Point(58, 77)
        Me.cb4.Name = "cb4"
        Me.cb4.Size = New System.Drawing.Size(55, 25)
        Me.cb4.TabIndex = 19
        Me.cb4.Tag = "23"
        Me.cb4.Text = "LAYER"
        Me.cb4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cb4.UseVisualStyleBackColor = True
        '
        'cb5
        '
        Me.cb5.Appearance = System.Windows.Forms.Appearance.Button
        Me.cb5.Checked = True
        Me.cb5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb5.Location = New System.Drawing.Point(113, 77)
        Me.cb5.Name = "cb5"
        Me.cb5.Size = New System.Drawing.Size(55, 25)
        Me.cb5.TabIndex = 20
        Me.cb5.Tag = "24"
        Me.cb5.Text = "POOR"
        Me.cb5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cb5.UseVisualStyleBackColor = True
        '
        'cbb1
        '
        Me.cbb1.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbb1.Checked = True
        Me.cbb1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbb1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbb1.Location = New System.Drawing.Point(3, 102)
        Me.cbb1.Name = "cbb1"
        Me.cbb1.Size = New System.Drawing.Size(35, 25)
        Me.cbb1.TabIndex = 21
        Me.cbb1.Tag = "26"
        Me.cbb1.Text = "B1"
        Me.cbb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbb1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.cb1)
        Me.Panel1.Controls.Add(Me.cbd8)
        Me.Panel1.Controls.Add(Me.cb2)
        Me.Panel1.Controls.Add(Me.cb3)
        Me.Panel1.Controls.Add(Me.cba1)
        Me.Panel1.Controls.Add(Me.cbd7)
        Me.Panel1.Controls.Add(Me.cb4)
        Me.Panel1.Controls.Add(Me.cba2)
        Me.Panel1.Controls.Add(Me.cbd6)
        Me.Panel1.Controls.Add(Me.cb5)
        Me.Panel1.Controls.Add(Me.cba3)
        Me.Panel1.Controls.Add(Me.cbd5)
        Me.Panel1.Controls.Add(Me.cbb1)
        Me.Panel1.Controls.Add(Me.cba4)
        Me.Panel1.Controls.Add(Me.cbd4)
        Me.Panel1.Controls.Add(Me.cbd3)
        Me.Panel1.Controls.Add(Me.cba5)
        Me.Panel1.Controls.Add(Me.cbd2)
        Me.Panel1.Controls.Add(Me.cbd1)
        Me.Panel1.Controls.Add(Me.cba6)
        Me.Panel1.Controls.Add(Me.cba8)
        Me.Panel1.Controls.Add(Me.cba7)
        Me.Panel1.Location = New System.Drawing.Point(26, 186)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(302, 131)
        Me.Panel1.TabIndex = 14
        '
        'BSAll
        '
        Me.BSAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BSAll.Location = New System.Drawing.Point(334, 189)
        Me.BSAll.Name = "BSAll"
        Me.BSAll.Size = New System.Drawing.Size(120, 23)
        Me.BSAll.TabIndex = 15
        Me.BSAll.Text = "Select All"
        Me.BSAll.UseVisualStyleBackColor = True
        '
        'BSInv
        '
        Me.BSInv.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BSInv.Location = New System.Drawing.Point(334, 218)
        Me.BSInv.Name = "BSInv"
        Me.BSInv.Size = New System.Drawing.Size(120, 23)
        Me.BSInv.TabIndex = 16
        Me.BSInv.Text = "Select Inverse"
        Me.BSInv.UseVisualStyleBackColor = True
        '
        'BSNone
        '
        Me.BSNone.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BSNone.Location = New System.Drawing.Point(334, 247)
        Me.BSNone.Name = "BSNone"
        Me.BSNone.Size = New System.Drawing.Size(120, 23)
        Me.BSNone.TabIndex = 17
        Me.BSNone.Text = "Unselect All"
        Me.BSNone.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Label Range"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Value Range"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TBSelect
        '
        Me.TBSelect.Location = New System.Drawing.Point(298, 354)
        Me.TBSelect.Name = "TBSelect"
        Me.TBSelect.Size = New System.Drawing.Size(75, 23)
        Me.TBSelect.TabIndex = 40
        Me.TBSelect.Text = "Select"
        Me.TBSelect.UseVisualStyleBackColor = True
        '
        'TBClose
        '
        Me.TBClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.TBClose.Location = New System.Drawing.Point(379, 412)
        Me.TBClose.Name = "TBClose"
        Me.TBClose.Size = New System.Drawing.Size(75, 23)
        Me.TBClose.TabIndex = 45
        Me.TBClose.Text = "Close"
        Me.TBClose.UseVisualStyleBackColor = True
        '
        'TBDelete
        '
        Me.TBDelete.Location = New System.Drawing.Point(298, 412)
        Me.TBDelete.Name = "TBDelete"
        Me.TBDelete.Size = New System.Drawing.Size(75, 23)
        Me.TBDelete.TabIndex = 44
        Me.TBDelete.Text = "Delete"
        Me.TBDelete.UseVisualStyleBackColor = True
        '
        'TBrl
        '
        Me.TBrl.Location = New System.Drawing.Point(26, 354)
        Me.TBrl.Name = "TBrl"
        Me.TBrl.Size = New System.Drawing.Size(178, 23)
        Me.TBrl.TabIndex = 30
        Me.TBrl.Text = "Replace with Label:"
        Me.TBrl.UseVisualStyleBackColor = True
        '
        'TBrv
        '
        Me.TBrv.Location = New System.Drawing.Point(26, 383)
        Me.TBrv.Name = "TBrv"
        Me.TBrv.Size = New System.Drawing.Size(178, 23)
        Me.TBrv.TabIndex = 32
        Me.TBrv.Text = "Replace with Value:"
        Me.TBrv.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(203, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "to"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(203, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "to"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(203, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "to"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ttv
        '
        Me.Ttv.DecimalPlaces = 4
        Me.Ttv.Location = New System.Drawing.Point(210, 383)
        Me.Ttv.Maximum = New Decimal(New Integer() {655359999, 0, 0, 262144})
        Me.Ttv.Minimum = New Decimal(New Integer() {1, 0, 0, 262144})
        Me.Ttv.Name = "Ttv"
        Me.Ttv.Size = New System.Drawing.Size(70, 23)
        Me.Ttv.TabIndex = 33
        Me.Ttv.Value = New Decimal(New Integer() {120, 0, 0, 0})
        '
        'Ttl
        '
        Me.Ttl.Location = New System.Drawing.Point(210, 354)
        Me.Ttl.MaxLength = 2
        Me.Ttl.Name = "Ttl"
        Me.Ttl.Size = New System.Drawing.Size(70, 23)
        Me.Ttl.TabIndex = 31
        Me.Ttl.Text = "01"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 165)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 15)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Column"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 327)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 15)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Operation"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox3.Location = New System.Drawing.Point(289, 354)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1, 81)
        Me.PictureBox3.TabIndex = 55
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(12, 335)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(450, 1)
        Me.PictureBox2.TabIndex = 49
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(12, 173)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(450, 1)
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'CBSelected
        '
        Me.CBSelected.Appearance = System.Windows.Forms.Appearance.Button
        Me.CBSelected.Checked = True
        Me.CBSelected.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBSelected.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CBSelected.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CBSelected.Location = New System.Drawing.Point(3, 3)
        Me.CBSelected.Name = "CBSelected"
        Me.CBSelected.Size = New System.Drawing.Size(64, 21)
        Me.CBSelected.TabIndex = 0
        Me.CBSelected.Tag = "1"
        Me.CBSelected.Text = "Selected"
        Me.CBSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CBSelected.UseVisualStyleBackColor = False
        '
        'CBUnselected
        '
        Me.CBUnselected.Appearance = System.Windows.Forms.Appearance.Button
        Me.CBUnselected.Checked = True
        Me.CBUnselected.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBUnselected.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CBUnselected.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CBUnselected.Location = New System.Drawing.Point(3, 30)
        Me.CBUnselected.Name = "CBUnselected"
        Me.CBUnselected.Size = New System.Drawing.Size(64, 21)
        Me.CBUnselected.TabIndex = 1
        Me.CBUnselected.Tag = "1"
        Me.CBUnselected.Text = "Unselected"
        Me.CBUnselected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CBUnselected.UseVisualStyleBackColor = False
        '
        'CBShort
        '
        Me.CBShort.Appearance = System.Windows.Forms.Appearance.Button
        Me.CBShort.Checked = True
        Me.CBShort.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBShort.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CBShort.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CBShort.Location = New System.Drawing.Point(73, 3)
        Me.CBShort.Name = "CBShort"
        Me.CBShort.Size = New System.Drawing.Size(38, 21)
        Me.CBShort.TabIndex = 2
        Me.CBShort.Tag = "1"
        Me.CBShort.Text = "Short"
        Me.CBShort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CBShort.UseVisualStyleBackColor = False
        '
        'TBUnselect
        '
        Me.TBUnselect.Location = New System.Drawing.Point(379, 354)
        Me.TBUnselect.Name = "TBUnselect"
        Me.TBUnselect.Size = New System.Drawing.Size(75, 23)
        Me.TBUnselect.TabIndex = 41
        Me.TBUnselect.Text = "Unselect"
        Me.TBUnselect.UseVisualStyleBackColor = True
        '
        'CBLong
        '
        Me.CBLong.Appearance = System.Windows.Forms.Appearance.Button
        Me.CBLong.Checked = True
        Me.CBLong.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBLong.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CBLong.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CBLong.Location = New System.Drawing.Point(73, 30)
        Me.CBLong.Name = "CBLong"
        Me.CBLong.Size = New System.Drawing.Size(38, 21)
        Me.CBLong.TabIndex = 3
        Me.CBLong.Tag = "1"
        Me.CBLong.Text = "Long"
        Me.CBLong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CBLong.UseVisualStyleBackColor = False
        '
        'CBHidden
        '
        Me.CBHidden.Appearance = System.Windows.Forms.Appearance.Button
        Me.CBHidden.Checked = True
        Me.CBHidden.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBHidden.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CBHidden.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CBHidden.Location = New System.Drawing.Point(117, 3)
        Me.CBHidden.Name = "CBHidden"
        Me.CBHidden.Size = New System.Drawing.Size(49, 21)
        Me.CBHidden.TabIndex = 4
        Me.CBHidden.Tag = "1"
        Me.CBHidden.Text = "Hidden"
        Me.CBHidden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CBHidden.UseVisualStyleBackColor = False
        '
        'CBVisible
        '
        Me.CBVisible.Appearance = System.Windows.Forms.Appearance.Button
        Me.CBVisible.Checked = True
        Me.CBVisible.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBVisible.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CBVisible.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CBVisible.Location = New System.Drawing.Point(117, 30)
        Me.CBVisible.Name = "CBVisible"
        Me.CBVisible.Size = New System.Drawing.Size(49, 21)
        Me.CBVisible.TabIndex = 5
        Me.CBVisible.Tag = "1"
        Me.CBVisible.Text = "Visible"
        Me.CBVisible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CBVisible.UseVisualStyleBackColor = False
        '
        'FNotePrevious
        '
        Me.FNotePrevious.Location = New System.Drawing.Point(298, 383)
        Me.FNotePrevious.Name = "FNotePrevious"
        Me.FNotePrevious.Size = New System.Drawing.Size(75, 23)
        Me.FNotePrevious.TabIndex = 42
        Me.FNotePrevious.Text = "Previous"
        Me.FNotePrevious.UseVisualStyleBackColor = True
        '
        'FNoteNext
        '
        Me.FNoteNext.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.FNoteNext.Location = New System.Drawing.Point(379, 383)
        Me.FNoteNext.Name = "FNoteNext"
        Me.FNoteNext.Size = New System.Drawing.Size(75, 23)
        Me.FNoteNext.TabIndex = 43
        Me.FNoteNext.Text = "Next"
        Me.FNoteNext.UseVisualStyleBackColor = True
        '
        'TLNoteRange
        '
        Me.TLNoteRange.ColumnCount = 5
        Me.TLNoteRange.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TLNoteRange.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TLNoteRange.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TLNoteRange.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TLNoteRange.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TLNoteRange.Controls.Add(Me.CBError, 3, 1)
        Me.TLNoteRange.Controls.Add(Me.CBSelected, 0, 0)
        Me.TLNoteRange.Controls.Add(Me.CBUnselected, 0, 1)
        Me.TLNoteRange.Controls.Add(Me.CBShort, 1, 0)
        Me.TLNoteRange.Controls.Add(Me.CBVisible, 2, 1)
        Me.TLNoteRange.Controls.Add(Me.CBLong, 1, 1)
        Me.TLNoteRange.Controls.Add(Me.CBHidden, 2, 0)
        Me.TLNoteRange.Controls.Add(Me.CBNoError, 3, 0)
        Me.TLNoteRange.Controls.Add(Me.CBComment, 4, 1)
        Me.TLNoteRange.Controls.Add(Me.CBNotComment, 4, 0)
        Me.TLNoteRange.Location = New System.Drawing.Point(134, 12)
        Me.TLNoteRange.Name = "TLNoteRange"
        Me.TLNoteRange.RowCount = 2
        Me.TLNoteRange.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLNoteRange.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLNoteRange.Size = New System.Drawing.Size(328, 54)
        Me.TLNoteRange.TabIndex = 1
        '
        'CBError
        '
        Me.CBError.Appearance = System.Windows.Forms.Appearance.Button
        Me.CBError.BackColor = System.Drawing.SystemColors.Control
        Me.CBError.Checked = True
        Me.CBError.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBError.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CBError.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CBError.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.CBError.Location = New System.Drawing.Point(172, 30)
        Me.CBError.Name = "CBError"
        Me.CBError.Size = New System.Drawing.Size(64, 21)
        Me.CBError.TabIndex = 7
        Me.CBError.Tag = "1"
        Me.CBError.Text = "Error"
        Me.CBError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CBError.UseVisualStyleBackColor = False
        '
        'CBNoError
        '
        Me.CBNoError.Appearance = System.Windows.Forms.Appearance.Button
        Me.CBNoError.BackColor = System.Drawing.SystemColors.Control
        Me.CBNoError.Checked = True
        Me.CBNoError.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBNoError.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CBNoError.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CBNoError.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.CBNoError.Location = New System.Drawing.Point(172, 3)
        Me.CBNoError.Name = "CBNoError"
        Me.CBNoError.Size = New System.Drawing.Size(64, 21)
        Me.CBNoError.TabIndex = 6
        Me.CBNoError.Tag = "1"
        Me.CBNoError.Text = "No Error"
        Me.CBNoError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CBNoError.UseVisualStyleBackColor = False
        '
        'CBComment
        '
        Me.CBComment.Appearance = System.Windows.Forms.Appearance.Button
        Me.CBComment.BackColor = System.Drawing.SystemColors.Control
        Me.CBComment.Checked = True
        Me.CBComment.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBComment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CBComment.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CBComment.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.CBComment.Location = New System.Drawing.Point(242, 30)
        Me.CBComment.Name = "CBComment"
        Me.CBComment.Size = New System.Drawing.Size(83, 21)
        Me.CBComment.TabIndex = 9
        Me.CBComment.Tag = "1"
        Me.CBComment.Text = "Comment"
        Me.CBComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CBComment.UseVisualStyleBackColor = False
        '
        'CBNotComment
        '
        Me.CBNotComment.Appearance = System.Windows.Forms.Appearance.Button
        Me.CBNotComment.BackColor = System.Drawing.SystemColors.Control
        Me.CBNotComment.Checked = True
        Me.CBNotComment.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBNotComment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CBNotComment.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CBNotComment.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.CBNotComment.Location = New System.Drawing.Point(242, 3)
        Me.CBNotComment.Name = "CBNotComment"
        Me.CBNotComment.Size = New System.Drawing.Size(83, 21)
        Me.CBNotComment.TabIndex = 8
        Me.CBNotComment.Tag = "1"
        Me.CBNotComment.Text = "Not Comment"
        Me.CBNotComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CBNotComment.UseVisualStyleBackColor = False
        '
        'dgFind
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.TBClose
        Me.ClientSize = New System.Drawing.Size(474, 451)
        Me.Controls.Add(Me.TLNoteRange)
        Me.Controls.Add(Me.FNoteNext)
        Me.Controls.Add(Me.FNotePrevious)
        Me.Controls.Add(Me.TBUnselect)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Ttv)
        Me.Controls.Add(Me.Ttl)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TBrv)
        Me.Controls.Add(Me.TBrl)
        Me.Controls.Add(Me.TBDelete)
        Me.Controls.Add(Me.TBClose)
        Me.Controls.Add(Me.TBSelect)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BSNone)
        Me.Controls.Add(Me.BSInv)
        Me.Controls.Add(Me.BSAll)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.vr2)
        Me.Controls.Add(Me.vr1)
        Me.Controls.Add(Me.lr2)
        Me.Controls.Add(Me.lr1)
        Me.Controls.Add(Me.mr2)
        Me.Controls.Add(Me.mr1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dgFind"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Find / Delete / Replace"
        Me.TopMost = True
        CType(Me.mr1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mr2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vr2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vr1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Ttv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLNoteRange.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mr1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents mr2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lr1 As System.Windows.Forms.TextBox
    Friend WithEvents lr2 As System.Windows.Forms.TextBox
    Friend WithEvents vr2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents vr1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents cb1 As System.Windows.Forms.CheckBox
    Friend WithEvents cb2 As System.Windows.Forms.CheckBox
    Friend WithEvents cba1 As System.Windows.Forms.CheckBox
    Friend WithEvents cba2 As System.Windows.Forms.CheckBox
    Friend WithEvents cba3 As System.Windows.Forms.CheckBox
    Friend WithEvents cba4 As System.Windows.Forms.CheckBox
    Friend WithEvents cba5 As System.Windows.Forms.CheckBox
    Friend WithEvents cba6 As System.Windows.Forms.CheckBox
    Friend WithEvents cba7 As System.Windows.Forms.CheckBox
    Friend WithEvents cba8 As System.Windows.Forms.CheckBox
    Friend WithEvents cbd1 As System.Windows.Forms.CheckBox
    Friend WithEvents cbd2 As System.Windows.Forms.CheckBox
    Friend WithEvents cbd3 As System.Windows.Forms.CheckBox
    Friend WithEvents cbd4 As System.Windows.Forms.CheckBox
    Friend WithEvents cbd5 As System.Windows.Forms.CheckBox
    Friend WithEvents cbd6 As System.Windows.Forms.CheckBox
    Friend WithEvents cbd7 As System.Windows.Forms.CheckBox
    Friend WithEvents cbd8 As System.Windows.Forms.CheckBox
    Friend WithEvents cb3 As System.Windows.Forms.CheckBox
    Friend WithEvents cb4 As System.Windows.Forms.CheckBox
    Friend WithEvents cb5 As System.Windows.Forms.CheckBox
    Friend WithEvents cbb1 As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BSAll As System.Windows.Forms.Button
    Friend WithEvents BSInv As System.Windows.Forms.Button
    Friend WithEvents BSNone As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBSelect As System.Windows.Forms.Button
    Friend WithEvents TBClose As System.Windows.Forms.Button
    Friend WithEvents TBDelete As System.Windows.Forms.Button
    Friend WithEvents TBrl As System.Windows.Forms.Button
    Friend WithEvents TBrv As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Ttv As System.Windows.Forms.NumericUpDown
    Friend WithEvents Ttl As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CBSelected As System.Windows.Forms.CheckBox
    Friend WithEvents CBUnselected As System.Windows.Forms.CheckBox
    Friend WithEvents CBShort As System.Windows.Forms.CheckBox
    Friend WithEvents TBUnselect As System.Windows.Forms.Button
    Friend WithEvents CBLong As System.Windows.Forms.CheckBox
    Friend WithEvents CBHidden As System.Windows.Forms.CheckBox
    Friend WithEvents CBVisible As System.Windows.Forms.CheckBox
    Friend WithEvents FNotePrevious As Button
    Friend WithEvents FNoteNext As Button
    Friend WithEvents TLNoteRange As TableLayoutPanel
    Friend WithEvents CBNoError As CheckBox
    Friend WithEvents CBNotComment As CheckBox
    Friend WithEvents CBComment As CheckBox
    Friend WithEvents CBError As CheckBox
End Class
