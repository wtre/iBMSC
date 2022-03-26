pBMSC
=====
pBMSC is a modified version of uBMSC (which is a modified version of iBMSC) with a primary focus on quality of life functionalities such as keyboard shortcuts.
See README.md.iBMSC for the original iBMSC README file and REAME.md.uBMSC for the last uBMSC README file.

# Changes
Listed in the order added.
## Bugfixes
* Added keybindings for DP and PMS. See **Keyboard Shortcuts** for more information.
* Fixed the search function such that notes on lane A8 and D8 are now searchable.
* Fixed the mirror function such that notes between A1 and D8 are reflected locally. Supports PMS as well.
* Fixed the Statistic Label not including notes between D1-D8. Statistic window still not fixed.
* Fixed the total note count on the toolbar.
* Reorganized the sidebar so you can tab between textboxes properly (mostly).
* Prevented notes in Expansion Code from being loaded.
* Rare bug that occurs when the mouse is highlighting a long note while toggling between NT and BMSE simultaneously.

## Functionalities
* Added Random, R-Random, S-Random and H-Random. Supports PMS as well.
* Added a display for recommended #TOTAL.
* The application now saves the option "Disable Vertical Moves".
* Changed the temporary bms file extension from .bms to .bmsc.
* Added advanced statistics (Ctrl+Shift+T).
* Removed restriction for drag and dropping files, as well as opening files. Mainly for opening bms template files, not tested thoroughly.
* Added note search function (goto measure except it's goto note). One note per VPosition only.
* Added sort function. Selected notes are sorted based on their VPosition and Value.
* Added mBMplay as a default player.
* Added support for #RANDOM. Supports expansion field and main data field only. Not tested thoroughly, nested #RANDOM in "Modify Section" only. Accessible via the "Select Section" button in Expansion Code or via Ctrl+R.
* Added color overriding options where you can specify a range of notes to appear a specific color, such as red notes for drums and green notes for the piano. Accessible via the Options tab or via Shift+F12.
* Added comment notes. Comment notes will be saved as #ECMD and #ECOM within the same bms/pms file. Not tested thoroughly.
* The window will now follow notes being moved by arrow keys.
* When creating LNs in NT mode, the VPosition will snap to the highlighted note if any.
* Added "Show Waveform on Notes".

## Keyboard shortcuts
* Changed keybinding to allow note placement between D1 and D8.
  * Numpad keys are now assigned to 2P lanes.
  * QWERTYUI keys are also assigned to 2P lanes.
  * 1 to 7 are now assigned to A2 to A8, and 8 is now assigned to A1.
  * Ctrl+1 to Ctrl+8 are now assigned to D1-D8.
  * For PMS: Number keys 1-9 assign the notes to PMS lanes when a PMS theme is used.
* Added Save As keyboard shortcut (Ctrl+Alt+S)
* Added recent bms keyboard shortcuts (Alt+1 to Alt+5)
* Added shortcuts for toggling lanes.
  * Alt+B - BPM lane
  * Alt+S - Stop lane
  * Alt+R - Scroll lane
  * Alt+G - BGA/Layer/Poor
* Added shortcuts for the panel splitter (Alt+Left and Alt+Right).
* Added Options shortcut
  * F9 - Player Options
  * F10 - General Options
  * F12 - Visual Options
* Added advanced statistics (Ctrl+Shift+T).
* Added keyboard shortcuts for previewing and replacing keysounds in the Sounds List (Spacebar to preview, enter to replace).
* Added "Select Section" (Ctrl+R).
* Added color overriding options (Shift+F12).

## New dialog/option boxes

### Advanced Statistics
* Displays note statistics over individual lanes from A1 to D8.
* Displays note usages, including #WAV assigned notes with 0 note count and #WAV unassigned notes with non-zero note count.

### Select Expansion Code
* Display ghost notes: Select an #if section to display its notes in ghost form.
* Display ghost notes (All): Display all notes in ghost form.
* Modify notes: Select an #if section and jump straight to modifying them.
* Modify section: Open an instance of pBMSC, allowing you to modify the #if section individually.
* Remove ghost notes: Remove all ghost notes.

### Visual Override Options
* Creates a list of note ranges with a specified color and replaces specified notes' display color.