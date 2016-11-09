# Rich Languages Editing

* Trigger suggestion, Ctrl+ space
* Trigger parameter hints, Ctrl+ Shift+ Space (issue: sometimes the up/down arrows do not work)
* Emmet expand abbreviation, Tab
    * E.g. prop Tab
    * E.g. ctor Tab
    * E.g. div*5 Tab
    * E.g. div#myid.myclass>p*5
* Format document, Shift+ Alt+ F
* Format selection, Ctrl+ K Ctrl+ F (!vim)
* Go to definition, F12
* Peak definition, Alt+ F12
* Open definition to the side, Ctrl+ K F12 (!vim)
* Quick fix, Ctrl+ . (issue: sometimes OmniSharp is `null`)
* Show references, Shift F12
* Rename symbol, F2
* Replace with next/previous value, Ctrl+ Shift+ ./
* Trim trailing whitespace, Ctrl+K Ctrl+ X (!vim)
* Change file language, Ctrl+ K M (!vim)
    * This breaks "format document"
    * Restart Vs Code.

## Notes

* Many of these require the root directory to have a project file like project.json