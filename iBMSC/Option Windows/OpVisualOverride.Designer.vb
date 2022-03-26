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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BColor = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TRangeU = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TRangeL = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LOverrides
        '
        Me.LOverrides.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LOverrides.FormattingEnabled = True
        Me.LOverrides.IntegralHeight = False
        Me.LOverrides.Items.AddRange(New Object() {"Drums", "Arps"})
        Me.LOverrides.Location = New System.Drawing.Point(12, 12)
        Me.LOverrides.Name = "LOverrides"
        Me.LOverrides.Size = New System.Drawing.Size(156, 55)
        Me.LOverrides.TabIndex = 0
        '
        'BRemove
        '
        Me.BRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BRemove.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BRemove.Location = New System.Drawing.Point(174, 41)
        Me.BRemove.Name = "BRemove"
        Me.BRemove.Size = New System.Drawing.Size(117, 23)
        Me.BRemove.TabIndex = 2
        Me.BRemove.Text = "Remove"
        Me.BRemove.UseVisualStyleBackColor = True
        '
        'BAdd
        '
        Me.BAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BAdd.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BAdd.Location = New System.Drawing.Point(174, 12)
        Me.BAdd.Name = "BAdd"
        Me.BAdd.Size = New System.Drawing.Size(117, 23)
        Me.BAdd.TabIndex = 1
        Me.BAdd.Text = "Add"
        Me.BAdd.UseVisualStyleBackColor = True
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK_Button.Location = New System.Drawing.Point(149, 187)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 100
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(222, 187)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 101
        Me.Cancel_Button.Text = "Cancel"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TName, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BColor, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 73)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(279, 100)
        Me.TableLayoutPanel1.TabIndex = 93
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 34)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Note Color"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TName
        '
        Me.TName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TName.Location = New System.Drawing.Point(142, 3)
        Me.TName.Name = "TName"
        Me.TName.Size = New System.Drawing.Size(134, 20)
        Me.TName.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label Range"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 33)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Option Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BColor
        '
        Me.BColor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BColor.Location = New System.Drawing.Point(142, 69)
        Me.BColor.Name = "BColor"
        Me.BColor.Size = New System.Drawing.Size(134, 28)
        Me.BColor.TabIndex = 30
        Me.BColor.Text = "Button1"
        Me.BColor.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.TRangeU, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TRangeL, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(139, 33)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(140, 25)
        Me.TableLayoutPanel2.TabIndex = 14
        '
        'TRangeU
        '
        Me.TRangeU.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TRangeU.Location = New System.Drawing.Point(95, 3)
        Me.TRangeU.MaxLength = 2
        Me.TRangeU.Name = "TRangeU"
        Me.TRangeU.Size = New System.Drawing.Size(42, 20)
        Me.TRangeU.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "to"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TRangeL
        '
        Me.TRangeL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TRangeL.Location = New System.Drawing.Point(3, 3)
        Me.TRangeL.MaxLength = 2
        Me.TRangeL.Name = "TRangeL"
        Me.TRangeL.Size = New System.Drawing.Size(40, 20)
        Me.TRangeL.TabIndex = 20
        '
        'OpVisualOverride
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 222)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.LOverrides)
        Me.Controls.Add(Me.BRemove)
        Me.Controls.Add(Me.BAdd)
        Me.Name = "OpVisualOverride"
        Me.Text = "Visual Override Options"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LOverrides As ListBox
    Friend WithEvents BRemove As Button
    Friend WithEvents BAdd As Button
    Friend WithEvents OK_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TName As TextBox
    Friend WithEvents BColor As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TRangeU As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TRangeL As TextBox
End Class
