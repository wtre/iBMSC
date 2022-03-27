<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OpExpand
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.BModifyNotes = New System.Windows.Forms.Button()
        Me.LExpansionCode = New System.Windows.Forms.ListBox()
        Me.BDisplayGhostAll = New System.Windows.Forms.Button()
        Me.BDisplayGhost = New System.Windows.Forms.Button()
        Me.BModifySection = New System.Windows.Forms.Button()
        Me.BRemoveGhostNotes = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 10)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Current Expansion Code:"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel_Button.AutoSize = True
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cancel_Button.Location = New System.Drawing.Point(164, 69)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(153, 28)
        Me.Cancel_Button.TabIndex = 5
        Me.Cancel_Button.Text = "Cancel"
        '
        'BModifyNotes
        '
        Me.BModifyNotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BModifyNotes.AutoSize = True
        Me.BModifyNotes.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BModifyNotes.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BModifyNotes.Location = New System.Drawing.Point(4, 36)
        Me.BModifyNotes.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BModifyNotes.Name = "BModifyNotes"
        Me.BModifyNotes.Size = New System.Drawing.Size(152, 27)
        Me.BModifyNotes.TabIndex = 2
        Me.BModifyNotes.Text = "Modify Notes"
        '
        'LExpansionCode
        '
        Me.LExpansionCode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LExpansionCode.FormattingEnabled = True
        Me.LExpansionCode.ItemHeight = 15
        Me.LExpansionCode.Location = New System.Drawing.Point(14, 29)
        Me.LExpansionCode.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LExpansionCode.Name = "LExpansionCode"
        Me.LExpansionCode.Size = New System.Drawing.Size(321, 499)
        Me.LExpansionCode.TabIndex = 1
        '
        'BDisplayGhostAll
        '
        Me.BDisplayGhostAll.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BDisplayGhostAll.AutoSize = True
        Me.BDisplayGhostAll.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BDisplayGhostAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BDisplayGhostAll.Location = New System.Drawing.Point(164, 3)
        Me.BDisplayGhostAll.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BDisplayGhostAll.Name = "BDisplayGhostAll"
        Me.BDisplayGhostAll.Size = New System.Drawing.Size(153, 27)
        Me.BDisplayGhostAll.TabIndex = 1
        Me.BDisplayGhostAll.Text = "DisplayGhostNotes (All)"
        '
        'BDisplayGhost
        '
        Me.BDisplayGhost.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BDisplayGhost.AutoSize = True
        Me.BDisplayGhost.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BDisplayGhost.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BDisplayGhost.Location = New System.Drawing.Point(4, 3)
        Me.BDisplayGhost.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BDisplayGhost.Name = "BDisplayGhost"
        Me.BDisplayGhost.Size = New System.Drawing.Size(152, 27)
        Me.BDisplayGhost.TabIndex = 0
        Me.BDisplayGhost.Text = "Display Ghost Notes"
        '
        'BModifySection
        '
        Me.BModifySection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BModifySection.AutoSize = True
        Me.BModifySection.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.BModifySection.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BModifySection.Location = New System.Drawing.Point(164, 36)
        Me.BModifySection.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BModifySection.Name = "BModifySection"
        Me.BModifySection.Size = New System.Drawing.Size(153, 27)
        Me.BModifySection.TabIndex = 3
        Me.BModifySection.Text = "Modify Section"
        '
        'BRemoveGhostNotes
        '
        Me.BRemoveGhostNotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BRemoveGhostNotes.AutoSize = True
        Me.BRemoveGhostNotes.DialogResult = System.Windows.Forms.DialogResult.No
        Me.BRemoveGhostNotes.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BRemoveGhostNotes.Location = New System.Drawing.Point(4, 69)
        Me.BRemoveGhostNotes.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BRemoveGhostNotes.Name = "BRemoveGhostNotes"
        Me.BRemoveGhostNotes.Size = New System.Drawing.Size(152, 28)
        Me.BRemoveGhostNotes.TabIndex = 4
        Me.BRemoveGhostNotes.Text = "Remove Ghost Notes"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BDisplayGhost, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BRemoveGhostNotes, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.BDisplayGhostAll, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.BModifySection, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BModifyNotes, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(14, 537)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(321, 100)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'OpExpand
        '
        Me.AcceptButton = Me.BDisplayGhost
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(349, 647)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.LExpansionCode)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OpExpand"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select Expansion Code"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents BModifyNotes As Button
    Friend WithEvents LExpansionCode As ListBox
    Friend WithEvents BDisplayGhostAll As Button
    Friend WithEvents BDisplayGhost As Button
    Friend WithEvents BModifySection As Button
    Friend WithEvents BRemoveGhostNotes As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
