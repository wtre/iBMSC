Public Class Strings
    ' TODO: Add all strings for new features here...
    Public Shared OK As String = "OK"
    Public Shared Cancel As String = "Cancel"
    Public Shared None As String = "None"

    Public Class StatusBar
        Public Shared Bars As String = "Beats"
        Public Shared Length As String = "Length"
        Public Shared Note As String = "Note"
        Public Shared LongNote As String = "LongNote"
        Public Shared Hidden As String = "Hidden"
        Public Shared Landmine As String = "Landmine"
        Public Shared Comment As String = "Comment"
        Public Shared Approximate As String = "Approx."
        Public Shared Err As String = "Error"
        Public Shared ErrTechnical As String = "Technical Error"
        Public Shared RecommendedTotal As String = "Recommended #TOTAL"
    End Class

    Public Class Messages
        Public Shared Err As String = "Error"
        Public Shared SaveOnExit As String = "Do you want to save changes?"
        Public Shared SaveOnExit1 As String = "You should tell me if you want to save changes before closing the computer. -_,-"
        Public Shared SaveOnExit2 As String = "You still need to tell me if you want to save changes even though you are closing the application with task manager. -_,-"
        Public Shared SaveOnExitOther As String = "There are unsaved files. Discard changes and close the application?"
        Public Shared PromptEnter As String = "Please enter a label."
        Public Shared PromptEnterNumeric As String = "Please enter a value."
        Public Shared PromptEnterMeasure As String = "Please enter a measure (0-999)."
        Public Shared PromptEnterBPM As String = "Please enter a BPM value."
        Public Shared PromptEnterSTOP As String = "Please enter a STOP value."
        Public Shared PromptEnterSCROLL As String = "Please enter a SCROLL value."
        Public Shared PromptSlashValue As String = "When the slash key (""/"") is pressed, change grid division to:"
        Public Shared InvalidLabel As String = "Invalid label."
        Public Shared CannotFind As String = "Cannot find file {}."
        Public Shared PleaseRespecifyPath As String = "Please respecify path."
        Public Shared PlayerNotFound As String = "Player not found"
        Public Shared PreviewDelError As String = "There must exist at least one player."
        Public Shared NegativeFactorError As String = "Factor must be greater than zero."
        Public Shared NegativeDivisorError As String = "Divisor must be greater than zero."
        Public Shared PreferencePostpone As String = "The preference will take effect on the next start-up of the program."
        Public Shared EraserObsolete As String = "The eraser tool has been replaced by right-clicking on the note."
        Public Shared SaveWarning As String = "Warning: "
        Public Shared NoteOverlapError As String = "Note operlapping detected. Increasing Maximum Grid Partition will resolve this."
        Public Shared BPMOverflowError As String = "Numbers of multi-byte BPMs has exceeded supported maximum: "
        Public Shared STOPOverflowError As String = "Numbers of STOPs has exceeded supported maximum: "
        Public Shared SCROLLOverflowError As String = "Numbers of multi-byte SCROLLs has exceeded supported maximum: "
        Public Shared SavedFileWillContainErrors As String = "The saved file will contain errors."
        Public Shared FileAssociationPrompt As String = "Do you want to set iBMSC as default program to all {} files?"
        Public Shared FileAssociationError As String = "Error changing file type association:"
        Public Shared RestoreDefaultSettings As String = "Restore default settings?"
        Public Shared RestoreAutosavedFile As String = "{} autosaved file(s) have been found. Do you want to recover these files?"
        Public Shared GhostNotesShowMain As String = "The notes in the current section will be changed to ghost notes. Save current section and continue?"
        Public Shared GhostNotesModifyExpansion1 As String = "The current ghost notes will become uneditable. Continue?"
        Public Shared GhostNotesModifyExpansion2 As String = "There are unsaved changes in the ghost notes. Save current section and continue?"
    End Class

    Public Class FileType
        Public Shared _all As String = "All files (*.*)"

        Public Shared _bms As String = "Supported BMS Format (*.bms, *.bme, *.bml, *.pms, *.txt)"
        Public Shared BMS As String = "Be-Music Script (*.bms)"
        Public Shared BME As String = "Be-Music Extended Format (*.bme)"
        Public Shared BML As String = "Be-Music Longnote Format (*.bml)"
        Public Shared PMS As String = "Po-Mu Script (*.pms)"
        Public Shared TXT As String = "Text document (*.txt)"

        Public Shared SM As String = "StepMania Script (*.sm)"
        Public Shared IBMSC As String = "iBMSC Binary Format (*.ibmsc)"
        Public Shared XML As String = "Extensible Markup Language (*.xml)"
        Public Shared THEME_XML As String = "iBMSC Theme File (*.Theme.xml)"
        Public Shared TH As String = "iBMSC 2.x Theme File (*.Theme.xml)"

        Public Shared _audio As String = "Supported Audio Format (*.wav, *.ogg, *.mp3, *.mid)"
        Public Shared _wave As String = "Supported Wave Audio Format (*.wav, *.ogg, *.mp3)"
        Public Shared WAV As String = "Waveform Audio (*.wav)"
        Public Shared OGG As String = "Ogg Vorbis Audio (*.ogg)"
        Public Shared MP3 As String = "MPEG Layer-3 Audio (*.mp3)"
        Public Shared MID As String = "MIDI (*.mid)"

        Public Shared _im As String = "Supported Image and Movie Format (*.png, *.bmp, *.jpg, *.gif, *.mpg, *.mpeg, *.avi, *.m1v, *.m2v, *.m4v, *.mp4, *.webm, *.wmv)"
        Public Shared _image As String = "Supported Image Format (*.png, *.bmp, *.jpg, *.gif)"
        Public Shared _movie As String = "Supported Movie Format (*.mpg, *.mpeg, *.avi, *.m1v, *.m2v, *.m4v, *.mp4, *.webm, *.wmv)"

        Public Shared EXE As String = "Executable file (*.exe)"
    End Class

    Public Class fStatistics
        Public Shared Title As String = "Statistics"
        Public Shared lBPM As String = "BPM"
        Public Shared lSTOP As String = "STOP"
        Public Shared lSCROLL As String = "SCROLL"
        Public Shared lA As String = "A1-A8"
        Public Shared lA1 As String = "A1"
        Public Shared lA2 As String = "A2"
        Public Shared lA3 As String = "A3"
        Public Shared lA4 As String = "A4"
        Public Shared lA5 As String = "A5"
        Public Shared lA6 As String = "A6"
        Public Shared lA7 As String = "A7"
        Public Shared lA8 As String = "A8"
        Public Shared lD As String = "D1-D8"
        Public Shared lD1 As String = "D1"
        Public Shared lD2 As String = "D2"
        Public Shared lD3 As String = "D3"
        Public Shared lD4 As String = "D4"
        Public Shared lD5 As String = "D5"
        Public Shared lD6 As String = "D6"
        Public Shared lD7 As String = "D7"
        Public Shared lD8 As String = "D8"
        Public Shared lBGA As String = "BGA"
        Public Shared lBGM As String = "BGM"
        Public Shared lNotes As String = "Notes"
        Public Shared lTotal As String = "Total"
        Public Shared lShort As String = "Short"
        Public Shared lLong As String = "Long"
        Public Shared lLnObj As String = "LnObj"
        Public Shared lHidden As String = "Hidden"
        Public Shared lLandmines As String = "Landmines"
        Public Shared lErrors As String = "Errors"
    End Class

    Public Class fopPlayer
        Public Shared Title As String = "Player Arguments Options"
        Public Shared Add As String = "Add"
        Public Shared Remove As String = "Remove"
        Public Shared Path As String = "Path"
        Public Shared PlayFromBeginning As String = "Play from beginning"
        Public Shared PlayFromHere As String = "Play from current measure"
        Public Shared StopPlaying As String = "Stop"
        Public Shared References As String = "References (case-sensitive):"
        Public Shared DirectoryOfApp As String = "Directory of the application"
        Public Shared CurrMeasure As String = "Current measure"
        Public Shared FileName As String = "File Name"
        Public Shared FileNameTemplate As String = "File Name of Template"
        Public Shared RestoreDefault As String = "Restore Default"
    End Class

    Public Class fopVisual
        Public Shared Title As String = "Visual Options"
        Public Shared Width As String = "Width"
        Public Shared Caption As String = "Caption"
        Public Shared Note As String = "Note"
        Public Shared Label As String = "Label"
        Public Shared LongNote As String = "Long Note"
        Public Shared LongNoteLabel As String = "Long Note Label"
        Public Shared Bg As String = "Bg"
        Public Shared ColumnCaption As String = "Column Caption"
        Public Shared ColumnCaptionFont As String = "Column Caption Font"
        Public Shared Background As String = "Background"
        Public Shared Grid As String = "Grid"
        Public Shared SubGrid As String = "Sub"
        Public Shared VerticalLine As String = "Vertical Line"
        Public Shared MeasureBarLine As String = "Measure BarLine"
        Public Shared BGMWaveform As String = "BGM Waveform"
        Public Shared NoteHeight As String = "Note Height"
        Public Shared NoteLabel As String = "Note Label"
        Public Shared MeasureLabel As String = "Measure Label"
        Public Shared LabelVerticalShift As String = "Note Label Vertical Shift"
        Public Shared LabelHorizontalShift As String = "Note Label Horizontal Shift"
        Public Shared LongNoteLabelHorizontalShift As String = "LongNote Label Horizontal Shift"
        Public Shared HiddenNoteOpacity As String = "Hidden Note Opacity"
        Public Shared NoteBorderOnMouseOver As String = "Note Border on MouseOver"
        Public Shared NoteBorderOnSelection As String = "Note Border on Selection"
        Public Shared NoteBorderOnAdjustingLength As String = "Note Border on Adjusting Length"
        Public Shared SelectionBoxBorder As String = "Selection Box Border"
        Public Shared TSCursor As String = "Time Selection Cursor"
        Public Shared TSSplitter As String = "Time Selection Splitter"
        Public Shared TSCursorSensitivity As String = "Time Selection Cursor Sensitivity"
        Public Shared TSMouseOverBorder As String = "Time Selection MouseOver Border"
        Public Shared TSFill As String = "Time Selection Fill"
        Public Shared TSBPM As String = "Time Selection BPM"
        Public Shared TSBPMFont As String = "Time Selection BPM Font"
        Public Shared MiddleSensitivity As String = "Middle Button Release Sensitivity"
    End Class

    Public Class fopGeneral
        Public Shared Title As String = "General Options"
        Public Shared MouseWheel As String = "Mouse Wheel"
        Public Shared TextEncoding As String = "Text Encoding"
        'Public Shared SortingMethod As String = "Sorting Method"
        'Public Shared sortBubble As String = "One-directional Bubble Sort"
        'Public Shared sortInsertion As String = "Insertion Sort"
        'Public Shared sortQuick As String = "Quick Sort"
        'Public Shared sortQuickD3 As String = "Quick Sort d3"
        'Public Shared sortHeap As String = "Heap Sort"
        Public Shared PageUpDown As String = "PageUp / PageDown"
        Public Shared MiddleButton As String = "Mouse Middle Button"
        Public Shared MiddleButtonAuto As String = "Click and Auto Scroll"
        Public Shared MiddleButtonDrag As String = "Click and Drag"
        Public Shared AssociateFileType As String = "Associate Filetype"
        Public Shared MaxGridPartition As String = "Max Grid Partition in BMS"
        Public Shared BeepWhileSaved As String = "Beep while saved"
        Public Shared ExtendBPM As String = "Extend number of multi-byte BPMs to 1296"
        Public Shared ExtendSTOP As String = "Extend number of STOPs to 1296"
        Public Shared AutoFocusOnMouseEnter As String = "Automatically set focus to editing panel on mouse enter"
        Public Shared DisableFirstClick As String = "Disable first click if the editing panel is not focused"
        Public Shared AutoSave As String = "AutoSave"
        Public Shared minutes As String = "minutes"
        Public Shared StopPreviewOnClick As String = "Stop preview if clicked on the editing panel"
    End Class

    Public Class fopVisualOverride
        Public Shared Title As String = "Visual Override Options"
        Public Shared Add As String = "Add"
        Public Shared Up As String = "Up"
        Public Shared Down As String = "Down"
        Public Shared Duplicate As String = "Duplicate"
        Public Shared Split As String = "Split"
        Public Shared SemiAutoAssign As String = "Semi-auto assign"
        Public Shared Remove As String = "Remove"
        Public Shared LoadSettingsFrom As String = "Load Settings From"
        Public Shared SaveSettingsTo As String = "Save Settings To"
        Public Shared EnableItem As String = "Enable Item"
        Public Shared ColorS As String = "Singular color"
        Public Shared ColorG As String = "Color gradient"
        Public Shared ColorGHSLU As String = "Color gradient (HSL��)"
        Public Shared ColorGHSLD As String = "Color gradient (HSL��)"
        Public Shared OptionName As String = "Option Name"
        Public Shared LabelRange As String = "Label Range"
        Public Shared ToText As String = "To"
        Public Shared NoteColor As String = "Note Color"
        Public Shared NoteColorRange As String = "Note Color Range"
        Public Shared Preview As String = "Preview"

        Public Shared Chart As String = "Chart"
        Public Shared Song As String = "Song"
        Public Shared Editor As String = "Editor"

        Public Shared SplitMsgCannot As String = "Warning: Cannot split range."
        Public Shared SplitMsgUpper As String = "Please input the upper bound for the first range."
        Public Shared SplitMsgNotBetweenRange As String = "Value not between the range. Please input the upper bound for the first range."

        Public Shared SemiAutoMsgAssign As String = "Assign notes with wav filenames beginning with the following:"
        Public Shared SemiAutoMsgNone As String = "No notes found."
        Public Shared SemiAutoMsgAssignMore As String = "Assign more notes with wav filenames beginning with the following:"

        Public Shared SaveCurrentSettings As String = "Save current settings?"
    End Class

    Public Class fopKeybinding
        Public Shared Title As String = "Keybinding Options"
        Public Shared BindingName As String = "Binding Name"
        Public Shared Description As String = "Description"
        Public Shared Keybindings As String = "Keybindings"

        Public Shared MoveTo As String = "Move to {}"
        Public Shared MoveToDescription As String = "Move note to {1} Lane {2}"
        Public Shared MoveToScratchDescription As String = "Move note to {} Scratch Lane"
        Public Shared MoveToBGMDescription As String = "Move note to BGM Lane"
        Public Shared MoveToTemplate As String = "Move to Template Position"
        Public Shared MoveToTemplateDescription As String = "Move note to template position if available"
        Public Shared CheckTechnicalError As String = "Check for technical errors such as impossible scratches in DP or impossible chords in PMS"
        Public Shared SelectExpansionSection As String = "Select #IF sections in the Expansion field"
        Public Shared PastePattern As String = "Apply pattern of the notes on the clipboard to the highlighted notes."
        Public Shared SelectHovered As String = "Select all with hovered note label"

        Public Shared ErrorUnavailable As String = "Error: {} is unavailable for custom keybinding."
        Public Shared ErrorAssigned As String = "Error: {} has been assigned to other functions."
        Public Shared ErrorNoteAssignment As String = "{1} has been assigned to {2}. Remove keybinding for {2}?"
    End Class

    Public Class fopExpand
        Public Shared Title As String = "#RANDOM Editor"
        Public Shared SelectExpansionCode As String = "Select Expansion Code"
        Public Shared DisplayGhostNotes As String = "Display Ghost Notes"
        Public Shared DisplayGhostNotesAll As String = "Display Ghost Notes (All)"
        Public Shared ModifyNotes As String = "Modify Notes"
        Public Shared ModifySection As String = "Modify Section"
        Public Shared RemoveGhostNotes As String = "Remove Ghost Notes"
        Public Shared ErrorEmpty As String = "Error: Expansion code is empty."
        Public Shared ErrorNoLineSelected As String = "Error: No line selected."
        Public Shared ErrorNotDetected As String = "Error: #IF Section not detected."
    End Class

    Public Class fFind
            Public Shared NoteRange As String = "Note Range"
            Public Shared MeasureRange As String = "Measure Range"
            Public Shared LabelRange As String = "Label Range"
            Public Shared ValueRange As String = "Value Range"
            Public Shared to_ As String = "to"
            Public Shared Selected As String = "Selected"
            Public Shared UnSelected As String = "Unselected"
            Public Shared ShortNote As String = "Short"
            Public Shared LongNote As String = "Long"
            Public Shared Hidden As String = "Hidden"
            Public Shared Visible As String = "Visible"
            Public Shared Column As String = "Column"
            Public Shared SelectAll As String = "Select All"
            Public Shared SelectInverse As String = "Select Inverse"
            Public Shared UnselectAll As String = "Unselect All"
            Public Shared Operation As String = "Operation"
            Public Shared ReplaceWithLabel As String = "Replace with Label:"
            Public Shared ReplaceWithValue As String = "Replace with Value:"
            Public Shared Select_ As String = "Select"
            Public Shared Unselect_ As String = "Unselect"
            Public Shared Delete_ As String = "Delete"
            Public Shared Close_ As String = "Close"
        End Class

        Public Class fImportSM
            Public Shared Title As String = "Import *.SM file"
            Public Shared Difficulty As String = "Difficulty"
            Public Shared Note As String = "Please note that bg musics and STOP values will not be imported."
        End Class

        Public Class FileAssociation
            Public Shared BMS As String = "Be-Music Script"
            Public Shared BME As String = "Be-Music Extended Format"
            Public Shared BML As String = "Be-Music Longnote Format"
            Public Shared PMS As String = "Po-Mu Script"
            Public Shared IBMSC As String = "iBMSC Binary Format"
            Public Shared Open As String = "Open"
            Public Shared Preview As String = "Preview"
            Public Shared ViewCode As String = "View Code"
        End Class
    End Class
