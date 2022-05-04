Imports System.Linq

Public Class OpKeybinding
    Public Keybinds() As MainWindow.Keybinding
    Dim KeybindsHidden() As MainWindow.Keybinding
    Dim keyComboEvent() As String
    Dim keyComboOK As Boolean

    Public Sub New(ByVal xKeybindings() As MainWindow.Keybinding)
        Try
            InitializeComponent()
            OK_Button.Text = Strings.OK
            Cancel_Button.Text = Strings.Cancel
            BDefault.Text = Strings.fopPlayer.RestoreDefault
            Keybinds = CType(xKeybindings.Clone(), MainWindow.Keybinding())
            InitializeKeybindings()
        Catch ex As Exception
            MsgBox("New OpKeybinding Error" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        ' Do not close window if textbox is being focused on
        If TComboInput.Focused Then
            If TComboInput.Text <> "" Then BAdd_Click(sender, New EventArgs)
            Exit Sub
        End If

        DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub LVKeybinding_Click(sender As Object, e As EventArgs) Handles LVKeybinding.Click, LVKeybinding.KeyUp
        ' List keybindings in LCombos
        LCombos.Items.Clear()
        With Keybinds(LVKeybinding.FocusedItem.Index)
            If .Combo.Length = 0 OrElse .Combo(0) = "" Then Exit Sub
            For Each keyComboIndividual In .Combo
                LCombos.Items.Add(keyComboIndividual)
            Next
        End With
    End Sub

    Private Sub LVKeybinding_DoubleClick(sender As Object, e As EventArgs) Handles LVKeybinding.DoubleClick
        LVKeybinding_Click(sender, e)
        TComboInput.Focus()
    End Sub

    Private Sub LCombos_KeyDown(sender As Object, e As KeyEventArgs) Handles LCombos.KeyDown
        If e.KeyCode = Keys.Delete Then BRemove_Click(sender, New EventArgs) : Exit Sub
    End Sub

    Private Sub TComboInput_KeyDown(sender As Object, e As KeyEventArgs) Handles TComboInput.KeyDown
        If e.KeyCode = Keys.ControlKey Or e.KeyCode = Keys.ShiftKey Or e.KeyCode = Keys.Menu Then Exit Sub

        If e.KeyCode = Keys.Delete Then BRemove_Click(sender, New EventArgs) : Exit Sub

        ReDim keyComboEvent(-1)
        If e.Control Then
            ReDim Preserve keyComboEvent(keyComboEvent.Length)
            keyComboEvent(UBound(keyComboEvent)) = "Ctrl"
        End If
        If e.Shift Then
            ReDim Preserve keyComboEvent(keyComboEvent.Length)
            keyComboEvent(UBound(keyComboEvent)) = "Shift"
        End If
        If e.Alt Then
            ReDim Preserve keyComboEvent(keyComboEvent.Length)
            keyComboEvent(UBound(keyComboEvent)) = "Alt"
        End If
        ReDim Preserve keyComboEvent(keyComboEvent.Length)
        keyComboEvent(UBound(keyComboEvent)) = e.KeyCode.ToString

        TComboInput.Text = Join(keyComboEvent, "+")
    End Sub

    Private Sub BAdd_Click(sender As Object, e As EventArgs) Handles BAdd.Click
        If TComboInput.Text <> "" Then
            keyComboOK = True
            ' TODO: Check existing keybindings
            CheckConflictWithOtherFunctions()
            CheckConflictWithOtherKeybindings()
            If Not keyComboOK Then Exit Sub

            With Keybinds(LVKeybinding.FocusedItem.Index)
                If .Combo.Length = 0 Then ReDim .Combo(0)
                If .Combo(0) <> "" Then ReDim Preserve .Combo(.Combo.Length)
                .Combo(UBound(.Combo)) = TComboInput.Text

                LCombos.Items.Add(TComboInput.Text)
                LVKeybinding.FocusedItem.SubItems(2).Text = Join(.Combo, ", ")
            End With
            TComboInput.Text = ""
        End If
    End Sub

    Private Sub BRemove_Click(sender As Object, e As EventArgs) Handles BRemove.Click
        If LCombos.SelectedIndex <> -1 Then
            Dim xIndices(LCombos.SelectedIndices.Count - 1) As Integer
            LCombos.SelectedIndices.CopyTo(xIndices, 0)

            Dim TempCombos(-1) As String
            For i = 0 To UBound(Keybinds(LVKeybinding.FocusedItem.Index).Combo)
                If Not xIndices.Contains(i) Then
                    ReDim Preserve TempCombos(TempCombos.Length)
                    TempCombos(UBound(TempCombos)) = LCombos.Items(i).ToString()
                End If
            Next

            Keybinds(LVKeybinding.FocusedItem.Index).Combo = TempCombos
            LVKeybinding.FocusedItem.SubItems(2).Text = Join(TempCombos, ", ")

            LVKeybinding_Click(sender, e)
        End If

        TComboInput.Text = ""
    End Sub

    ' This causes the application to crash on other PCs. what
    ' Private Sub LVKeybinding_ColumnWidthChanged(sender As Object, e As ColumnWidthChangedEventArgs) Handles LVKeybinding.ColumnWidthChanged
    '     BindingKey.Width = LVKeybinding.Width - BindingName.Width - Description.Width - 25
    ' End Sub

    Private Sub BDefault_Click(sender As Object, e As EventArgs) Handles BDefault.Click
        Keybinds = CType(MainWindow.KeybindingsInit.Clone(), MainWindow.Keybinding())
        InitializeKeybindings()
    End Sub

    Private Sub CheckConflictWithOtherFunctions()
        ' Check with hidden functions
        For Each keybindHidden In KeybindsHidden
            If keyComboEvent(UBound(keyComboEvent)) = keybindHidden.Combo(0) Then
                keyComboOK = False
                MsgBox("Error: " & keyComboEvent(UBound(keyComboEvent)) & " is unavailable for custom keybinding.")
                Exit Sub
            End If
        Next

        ' Check with other miscellaneous keys
        Dim OtherFunctionKeys() As String = {"F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12"}
        If OtherFunctionKeys.Contains(keyComboEvent(UBound(keyComboEvent))) Then
            keyComboOK = False
            MsgBox("Error: " & keyComboEvent(UBound(keyComboEvent)) & " is unavailable for custom keybinding.")
            Exit Sub
        End If

        ' Check with other key combos
        Dim OtherFunctionKeyCombos() As String = {"Ctrl+N", "Ctrl+O", "Ctrl+Alt+O", "Ctrl+S", "Ctrl+Alt+S", "Ctrl+Shift+E", "Alt+D1", "Alt+D2", "Alt+D3", "Alt+D4", "Alt+D5",
                                                  "Ctrl+F", "Ctrl+G", "Ctrl+T", "Ctrl+Shift+T",
                                                  "Alt+B", "Alt+S", "Alt+R", "Alt+G"}
        If OtherFunctionKeyCombos.Contains(TComboInput.Text) Then
            keyComboOK = False
            MsgBox("Error: " & TComboInput.Text & " has been assigned to other functions.")
            Exit Sub
        End If

        ' Check for category restrictions
        Select Case Keybinds(LVKeybinding.FocusedItem.Index).Category
            ' If note assignment option, check if there is shift
            Case MainWindow.KbCategorySP, MainWindow.KbCategoryDP, MainWindow.KbCategoryPMS
                If keyComboEvent.Contains("Shift") Then
                    keyComboOK = False
                    MsgBox("Error: Shift cannot be used for note assignment keybindings.")
                    Exit Sub
                End If
        End Select
    End Sub

    Private Sub CheckConflictWithOtherKeybindings()
        Dim CategoryToIgnore() As Integer = {}
        Select Case Keybinds(LVKeybinding.FocusedItem.Index).Category
            ' If note assignment option, check with each other in the same category
            Case MainWindow.KbCategorySP
                CategoryToIgnore = {MainWindow.KbCategoryDP, MainWindow.KbCategoryPMS}
            Case MainWindow.KbCategoryDP
                CategoryToIgnore = {MainWindow.KbCategorySP, MainWindow.KbCategoryPMS}
            Case MainWindow.KbCategoryPMS
                CategoryToIgnore = {MainWindow.KbCategorySP, MainWindow.KbCategoryDP}

        End Select

        For i = 0 To UBound(Keybinds)
            If CategoryToIgnore.Contains(Keybinds(i).Category) Then Continue For

            Dim keybind = Keybinds(i)
            For j = 0 To UBound(keybind.Combo)
                If keybind.Combo(j) = TComboInput.Text Then
                    If MsgBox(TComboInput.Text & " has been assigned to " & keybind.OpName & ". Remove keybinding for " & keybind.OpName & "?", MsgBoxStyle.YesNo) = DialogResult.Yes Then
                        For k = j To UBound(Keybinds(i).Combo) - 1
                            Keybinds(i).Combo(k) = Keybinds(i).Combo(k + 1)
                        Next
                        ReDim Preserve Keybinds(i).Combo(UBound(Keybinds(i).Combo) - 1)

                        LVKeybinding.Items(i).SubItems(2).Text = Join(Keybinds(i).Combo, ", ")
                        Exit For
                    Else
                        keyComboOK = False
                        Exit Sub
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub InitializeKeybindings()
        LVKeybinding.Items.Clear()

        ' Remove hidden options
        Dim KeybindsBackup As MainWindow.Keybinding() = CType(Keybinds.Clone(), MainWindow.Keybinding())
        ReDim KeybindsHidden(UBound(KeybindsBackup))
        Dim i As Integer = -1
        Dim j As Integer = -1 ' TODO: Setup another array for hidden keybinds, and create sub CheckConflictWithHiddenFunctions
        For Each keybind In KeybindsBackup
            If keybind.Category <> MainWindow.KbCategoryAllMod AndAlso
                keybind.Category <> MainWindow.KbCategoryHidden Then
                i += 1
                Keybinds(i) = keybind
                Continue For
            Else
                j += 1
                KeybindsHidden(j) = keybind
                Continue For
            End If
        Next
        ReDim Preserve Keybinds(i)
        ReDim Preserve KeybindsHidden(j)

        ' List view array initialization
        Dim LVArray(UBound(Keybinds)) As ListViewItem
        i = -1
        For Each keybind In Keybinds
            i += 1

            LVArray(i) = New ListViewItem
            ' Option name
            LVArray(i).SubItems(0).Text = (keybind.OpName)
            ' Add description
            LVArray(i).SubItems.Add(keybind.Description)

            ' Add keybindings combined into 1 string
            Dim keybindStrings() As String
            If Not IsNothing(keybind.Combo) Then
                ReDim keybindStrings(UBound(keybind.Combo))
                For xI = 0 To UBound(keybind.Combo)
                    keybindStrings(xI) = keybind.Combo(xI)
                Next
            Else
                keybindStrings = {""}
            End If
            LVArray(i).SubItems.Add(Join(keybindStrings, ", "))
            Dim x = CInt("&HF9")
            If i Mod 2 = 1 Then LVArray(i).BackColor = Color.FromArgb(x, x, x)
        Next

        LVKeybinding.Items.AddRange(LVArray)
    End Sub
End Class