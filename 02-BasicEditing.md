# Basic Editing (no Vim conflicts, no other problems)

* Cut line, Ctrl+ X
* Copy line, Ctrl+ C
* Move line up/down, Alt up/down
* Copy line up/down, Shift+ Alt+ up/down
* Delete line, Ctrl+ Shift+ K (does not go into the clipboard)
* Insert line below, Ctrl+ Enter
* Insert line above, Ctrl+ Shift+ Enter
* Jump to matching bracket, Ctrl+ Shift+ Backslash
* Indent/outdent line, Ctrl+ [/]
* Toggle word wrap, Alt+ Z

This is a test of toggling the word wrap. That means that we need to type quite a long sentence. Sometimes, it makes sense to think before acting. 

## Goto (no Vim conflicts, no other problem)

* Go to beginning of line, Home (must not be in Fn mode)
* Go to end of line, End
* Go to beginning of file, Ctrl+ Home
* Go to end of file, Ctrl+ End
* Scroll line up/down, Ctrl+ up/down
* Scroll page up/down, Alt+ Page up/down
    * This is a page-sized scroll instead of a line-sized scroll

## Regions (has Vim conflicts, no other problems)

* Fold region, Ctrl+ Shift+ [
* Unfold region, Ctrl+ Shift+ ]

* Fold all subregions, Ctrl+ K Ctrl+ [ (!vim)
* Unfold all subregions, Ctrl+ K Ctrl+ ] (!vim)

* Fold all regions, Ctrl+ K, Ctrl+ 0 (zero) (!vim)
* Unfold all regions, Ctrl+ K, Ctrl+ J (!vim)

### Notes

* This is file extension/language specific.
* Also...
* Fold region folds the region but NOT its subregions... 
* Fold all subregions folds the region and its subregions...
* The difference is apparent only on unfolding.
* Try folding all regions and then expanding one region.
    1. Ctrl+ K, Ctrl+ 0
    2. Ctrl+ Shift+ [

## Comments (has Vim conflicts, no other problems)

* Add line comment, Ctrl+ K, Ctrl+ C (!vim)
* Remove line comment,  Ctrl+ K, Ctrl+ U (!vim)
* Toggle line comment, Ctrl+ /
* Toggle block comment, Shift+ Alt+ A