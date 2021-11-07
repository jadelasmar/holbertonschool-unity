# 0x08. Unity - Audio

# Learning Objectives

* What is an Audio Source
* What is an Audio Listener
* What is an Audio Filter
* What is an Audio Mixer
* What are snapshots
* What is a channel
* What is attenuation
* What is ducking
* How to control audio elements with scripts

# Tasks

## 0. Sound check, one two 
Duplicate ```0x07-unity-animation``` and rename it ```0x08-unity-audio```.

In the ```MainMenu``` scene, create an empty GameObject named ```MenuSFX```. Make ```button-rollover.ogg``` a child object of ```MenuSFX```.

Add the ```button-rollover``` sound clip to all menu buttons (all three level select buttons, Options, Exit) so that when the player’s mouse hovers over a button, it plays the sound clip.

## 1. Click
In the ```MainMenu``` scene, make ```button-click.ogg``` a child object of ```MenuSFX```.

Add the ```button-click``` sound clip to all menu buttons (all three level select buttons, Options, Exit) so that when the player’s mouse hovers over a button, it plays the sound clip.

## 2. The sound of music 
In the ```MainMenu``` scene, add ```Wallpaper``` as background music. It should start playing when the scene loads and stop when the player loads a different scene.

## 3. Tap-tap-tap
In the ```Level01``` scene, add footstep sound clips to the Player so that when the Player is running, the sound plays in a loop until the Player stops running.

## 4. Thump 
In the ```Level01``` scene, add a landing sound clip to play when the player hits the ground from falling off the platforms and restarting. If the player lands on a grassy platform, ```footsteps_landing_grass``` should play. If the player lands on a stone platform, ```footsteps_landing_rock``` should play.

## 5. Cheery Monday
In the ```Level01``` scene, add ```CheeryMonday``` as background music. It should start playing when the level loads and stop when the player touches the WinFlag or returns to the ```MainMenu``` scene. The player sound effects should still play while the BGM plays.

## 6. Victory fanfare
In the ```Level01``` scene, add ```VictoryPiano``` as a win sting that plays once when the Player touches the ```WinFlag```. The background music ```CheeryMonday``` should stop playing when ```VictoryPiano``` starts.

## 7. Ambience 
Add ambient audio to at least one tree (```birds```) or at least one rock/grass/flower (```crickets```). This audio should be quiet or muted from a distance and grow louder as the player gets closer to the GameObject.

## 8. Shhh
Using Snapshots, create functionality so that when the Player pauses the game, the BGM should become muffled. (Check the playable demo to hear the desired effect.) When the player returns to the game, the sound should return to its original settings.

## 9. Volume control #0 
In the ```Options``` scene, make sure the ```OptionsButton``` and ```ExitButton``` prefabs are updated to have the ```button-rollover``` and ```button-click``` sound effect events applied.

## 10. Volume control #1
In the ```Options``` scene and ```OptionsMenu.cs```, script the ```SFXSlider``` so that when the slider’s value is changed by dragging the slider handle, the SFX audio decreases and increases from fully muted to max volume. These values should persist through all levels and when the game is quit and re-opened.

## 11. Sound system gonna bring me back up
Add music and sound effects to scenes ```Level02``` and ```Level03```, using the same Audio Mixer you created for ```Level01```. Make sure your player sounds, options, etc. work in these scenes as well.

## 12. We're done! 
Scenes in Build:

1. ```MainMenu```
2. ```Options```
3. ```Level01```
4. ```Level02```
5. ```Level03```

Create three builds of all scenes above in the ```Builds``` directory.

* Windows and Linux builds should be set to ```x86_64``` architecture

**Build Folder Hierarchy:**

* Builds
  * Linux
    * Platformer_Data
    * Platformer.x86_64
  * Mac
    * Platformer.app
  * Windows
    * Platformer_Data
    * Platformer.exe
    * UnityPlayer.dll



## Credits:

**Graphics**

Skyboxes: Farland Skies - [Cloudy Crown](https://assetstore.unity.com/packages/2d/textures-materials/sky/farland-skies-cloudy-crown-60004)

Models: Kenney's - [Nature Pack Extended](https://kenney.nl/assets/nature-pack-extended)

**Audio clips**

* Kenney: https://kenney.nl/
* Oculus Audio Pack: https://developer.oculus.com/downloads/package/oculus-audio-pack-1/
* Mindful Audio: https://mindful-audio.com/
* “Wallpaper”, “Cheery Monday” Kevin MacLeod (incompetech.com)
Licensed under Creative Commons: By Attribution 3.0
http://creativecommons.org/licenses/by/3.0/