# PATCH NOTE v1.2

## Bugs Found at Previous Patch v1.1:
- All sound effects still plays after pressing Universal Back Button


## Bug Fixes
- Moved the *AudioManager.StopAllSoundEffects()* function to the LoadScreen() function. [Previously at HandleNavigation]. Now the *AudioManager.StopAllSoundEffects()* gets triggered every time a new screen is loaded.

## Optimizations
- Changed the Image assets at *RecipeSelectionScreen* to enable transparent backgrounds.