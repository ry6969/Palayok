# PATCH NOTE v1.3

## Bugs Found at Previous Patch v1.1:
- TimerEnd sound effect still triggers after moving to another screen

## Bug Fixes
- Added *PlayLoopingSoundEffect()* and *StopLoopingSoundEffect()* to handle the looping TimerEnd and ensure to only stop if the audio is playing to avoid pre-emptive stopping
