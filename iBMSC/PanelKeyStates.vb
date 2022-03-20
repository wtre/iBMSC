Module PanelKeyStates
    Public Function ModifierLongNoteActive() As Boolean
        With My.Computer.Keyboard
            Return .ShiftKeyDown And Not .CtrlKeyDown
        End With
    End Function

    Public Function ModifierHiddenActive() As Boolean
        With My.Computer.Keyboard
            Return .CtrlKeyDown And Not .ShiftKeyDown
        End With
    End Function

    Public Function ModifierLandmineActive() As Boolean
        Return ModifierMultiselectVisibleActive()
    End Function

    Public Function ModifierMultiselectVisibleActive() As Boolean
        With My.Computer.Keyboard
            Return .ShiftKeyDown And .CtrlKeyDown
        End With
    End Function

    Public Function ModifierMultiselectNoteActive() As Boolean
        With My.Computer.Keyboard
            Return .AltKeyDown And .CtrlKeyDown
        End With
    End Function

    Public Function ModifierCtrlOnlyActive() As Boolean
        With My.Computer.Keyboard
            Return .CtrlKeyDown And Not .ShiftKeyDown And Not .AltKeyDown
        End With
    End Function
End Module
