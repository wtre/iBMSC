<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OpKeybinding
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Demo Option", "Option Description", "Ctrl+Shift+Esc"}, -1)
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.LVKeybinding = New System.Windows.Forms.ListView()
        Me.BindingName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BindingKey = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BAdd = New System.Windows.Forms.Button()
        Me.BRemove = New System.Windows.Forms.Button()
        Me.BDefault = New System.Windows.Forms.Button()
        Me.LCombos = New System.Windows.Forms.ListBox()
        Me.TComboInput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK_Button.Location = New System.Drawing.Point(469, 680)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(78, 27)
        Me.OK_Button.TabIndex = 100
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(554, 680)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(78, 27)
        Me.Cancel_Button.TabIndex = 101
        Me.Cancel_Button.Text = "Cancel"
        '
        'LVKeybinding
        '
        Me.LVKeybinding.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LVKeybinding.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.BindingName, Me.Description, Me.BindingKey})
        Me.LVKeybinding.FullRowSelect = True
        Me.LVKeybinding.GridLines = True
        Me.LVKeybinding.HideSelection = False
        Me.LVKeybinding.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.LVKeybinding.Location = New System.Drawing.Point(12, 12)
        Me.LVKeybinding.MultiSelect = False
        Me.LVKeybinding.Name = "LVKeybinding"
        Me.LVKeybinding.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LVKeybinding.Size = New System.Drawing.Size(620, 548)
        Me.LVKeybinding.TabIndex = 0
        Me.LVKeybinding.UseCompatibleStateImageBehavior = False
        Me.LVKeybinding.View = System.Windows.Forms.View.Details
        '
        'BindingName
        '
        Me.BindingName.Text = "Binding Name"
        Me.BindingName.Width = 200
        '
        'Description
        '
        Me.Description.Text = "Description"
        Me.Description.Width = 250
        '
        'BindingKey
        '
        Me.BindingKey.Text = "Keybindings"
        Me.BindingKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BindingKey.Width = 150
        '
        'BAdd
        '
        Me.BAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BAdd.Location = New System.Drawing.Point(12, 680)
        Me.BAdd.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BAdd.Name = "BAdd"
        Me.BAdd.Size = New System.Drawing.Size(78, 27)
        Me.BAdd.TabIndex = 3
        Me.BAdd.Text = "Add"
        '
        'BRemove
        '
        Me.BRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BRemove.Location = New System.Drawing.Point(98, 680)
        Me.BRemove.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BRemove.Name = "BRemove"
        Me.BRemove.Size = New System.Drawing.Size(78, 27)
        Me.BRemove.TabIndex = 4
        Me.BRemove.Text = "Remove"
        '
        'BDefault
        '
        Me.BDefault.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BDefault.Location = New System.Drawing.Point(245, 680)
        Me.BDefault.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BDefault.Name = "BDefault"
        Me.BDefault.Size = New System.Drawing.Size(156, 27)
        Me.BDefault.TabIndex = 10
        Me.BDefault.Text = "Restore Default"
        '
        'LCombos
        '
        Me.LCombos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LCombos.FormattingEnabled = True
        Me.LCombos.ItemHeight = 15
        Me.LCombos.Location = New System.Drawing.Point(12, 566)
        Me.LCombos.Name = "LCombos"
        Me.LCombos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.LCombos.Size = New System.Drawing.Size(163, 79)
        Me.LCombos.TabIndex = 1
        '
        'TComboInput
        '
        Me.TComboInput.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TComboInput.Location = New System.Drawing.Point(12, 651)
        Me.TComboInput.Name = "TComboInput"
        Me.TComboInput.ReadOnly = True
        Me.TComboInput.Size = New System.Drawing.Size(163, 23)
        Me.TComboInput.TabIndex = 2
        '
        'OpKeybinding
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(645, 719)
        Me.Controls.Add(Me.TComboInput)
        Me.Controls.Add(Me.LCombos)
        Me.Controls.Add(Me.BDefault)
        Me.Controls.Add(Me.BRemove)
        Me.Controls.Add(Me.BAdd)
        Me.Controls.Add(Me.LVKeybinding)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OpKeybinding"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Keybinding Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OK_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents LVKeybinding As ListView
    Friend WithEvents BindingName As ColumnHeader
    Friend WithEvents BindingKey As ColumnHeader
    Friend WithEvents Description As ColumnHeader
    Friend WithEvents BAdd As Button
    Friend WithEvents BRemove As Button
    Friend WithEvents BDefault As Button
    Friend WithEvents LCombos As ListBox
    Friend WithEvents TComboInput As TextBox
End Class
