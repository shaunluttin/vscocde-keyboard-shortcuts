# Basic Editing - Regions (has Vim conflicts, no other problems)

* Fold region, Ctrl+ Shift+ [
* Unfold region, Ctrl+ Shift+ ]

* Fold all subregions, Ctrl+ K Ctrl+ [ (!vim)
* Unfold all subregions, Ctrl+ K Ctrl+ ] (!vim)

* Fold all regions, Ctrl+ K, Ctrl+ 0 (zero) (!vim)
* Unfold all regions, Ctrl+ K, Ctrl+ J (!vim)

## Notes

* This is file extension/language specific.
* Also...
* Fold region folds the region but NOT its subregions... 
* Fold all subregions folds the region and its subregions...
* The difference is apparent only on unfolding.
* Try folding all regions and then expanding one region.
    1. Ctrl+ K, Ctrl+ 0
    2. Ctrl+ Shift+ [
