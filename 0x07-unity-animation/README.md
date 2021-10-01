# 0x07. Unity - Animation

# Learning Objectives

* What is a keyframe
* What are Dopesheets and how to use them
* What are Curves and how to use them
* How to import and use Animation Clips
* What are Animator Controllers and how to use them
* What is a State Machine
* What is a Sub-State Machine
* What is Root Motion

# Tasks

## 0. Cinematic universe 
We’re continuing to add on to the Platformer project to add animation. Duplicate the ```0x06-unity-assets_ui``` directory and rename it ```0x07-unity-animation```.

In ```Level01``` scene, disable ```Main Camera``` by clicking on the checkbox next to its name in the Inspector. Create a new Camera GameObject named ```CutsceneCamera```. The camera should be facing the end flag.

## 1. Keyframes 
With ```Intro01``` open in the Animation tab, use keyframes to animate the ```CutsceneCamera```‘s Position and Rotation so that the camera pulls back from the flag, panning over the length of the platforms, and stopping behind the player, ending in the position and rotation of the ```Main Camera```.

## 2. Transitions 
Open the ```CutsceneCamera``` Animator in the Animator tab. Make sure that ```Entry``` has a transition to ```Intro```.

Disable ```PlayerController``` script in the ```Player``` GameObject and disable the ```TimerCanvas```. Create a script called ```CutsceneController.cs``` and attach it to the ```CutsceneCamera``` GameObject. This script should do the following when the ```Level01``` animation is finished playing:

* Enable ```Main Camera```
* Enable ```PlayerController```
* Enable ```Timer```
* Disable ```CutsceneController```

## 3. Sorry Sylvain, it's not a Tic Tac anymore 
Download this character model and import it into your ```Models``` folder. You may need to remap the materials and textures associated with the model. If you cannot find the materials and/or textures, extract them from the model’s ```Materials``` tab in the Inspector.

In the Hierarchy window, disable ```Player```‘s Mesh Renderer and make the model ```ty.fbx``` a child of the ```Player``` GameObject. Press Play to test it. The model should be in T-pose and move exactly the same as the Capsule placeholder object did, while in T-pose.

## 4. Running in circles 
Edit ```CameraController.cs``` so that the camera still follows the player, but when the player turns, it does not change the orientation of the camera. The only rotation the camera should do is when the player moves the camera with the mouse.

## 5. Happily idling 
All of the animations we’ll be using in this project are from Mixamo.

Download this Animation Clip and import it into your ```Animations``` folder. Change the following settings in the Inspector:

* Rig
  * Animation Type: Humanoid
  * Avatar Definition: Copy From Other Avatar
  * Source: ```tyAvatar```

## 6. Run boy run 
Download this Animation Clip and import it into your ```Animations``` folder. Change the settings so that they match ```Happy Idle‘s``` settings.

## 7. Jump, jump 
Download this Animation Clip and import it into your ```Animations``` folder. Change the settings so it matches ```Happy Idle``` and ```Running```‘s settings.

Drag the ```Jump``` animation into the ```ty``` Animator and create transitions to and from the ```Happy Idle``` state as well as the ```Running``` state. Name the transitions ```IdleToJump```, ```JumpToIdle```, ```JumpToRunning```, and ```RunningToJump``` accordingly.

If the player is standing still, the ```Jump``` animation should start immediately (i.e. the ```Jump``` animation shouldn’t wait until the ```Happy Idle``` animation is finished to start). When the player lands, the ```Jump``` animation should stop and the ```Idle``` animation should start again.

## 8. Free falling 
Create a new Sub-state Machine called ```FallingDown```. Create transitions to it from ```Running``` and ```Jump``` named ```RunningToFalling``` and ```JumpToFalling```.

## 9. Splat 
Download this Animation Clip and import it into your ```Animations``` folder.

## 10. Down but not out 
Download this Animation Clip and import it into your ```Animations``` folder.

## 11. Animated features 
Update the ```Level02``` and ```Level03``` scenes to have their own intro animations named ```Intro02``` and ```Intro03``` respectively. Replace the placeholder player with the animated model in each scene as well.

## 12. Not quite done yet 
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



## Credits: ##

Skyboxes: Farland Skies - [Cloudy Crown](https://assetstore.unity.com/packages/2d/textures-materials/sky/farland-skies-cloudy-crown-60004)

Models: Kenney's - [Nature Pack Extended](https://kenney.nl/assets/nature-pack-extended)
