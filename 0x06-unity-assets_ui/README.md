# 0x06. Unity - Assets: UI

# Learning Objectives

* What is an Asset and how to import and use them
* How to import images to use in a user interface
* What is a Sprite
* How is a Sprite different from a Texture
* How to use the Sprite Editor
* What is 9-slicing
* How to create a Slider
* How to create a Toggle
* How to swap button images
* How to use PlayerPrefs and what are they used for


# Tasks

## 0. Leveling up 
We’ll be adding on to the last project to add a menu and UI (see example ). Duplicate your ```0x05-unity-assets_models_textures``` directory and rename it ```0x06-unity-assets_ui```.

Create two more Scenes in ```0x06-unity-assets_ui```. For each new scene, create a new path of platforms for the ```Player``` to navigate through.

## 1. Choose your own adventure 
The next few tasks will be creating UI elements using imported images to build a menu that allows the player to choose a level.

## 2. Option in 
Create a new Scene called ```Options```.

## 3. Pushing buttons 
Create a new C# script called ```MainMenu.cs```. In the ```MainMenu``` scene, script the level buttons scene so that choosing ```Level01```, ```Level02```, or ```Level03``` loads the corresponding scene.

## 4. Wait, hold on, time out 
Inside the ```Level01``` Scene, create a new Canvas and using the image as a guide, create a pause screen with the following objects:

## 5. Es-ca-pé 
Create a new C# script called ```PauseMenu.cs```. Add a method to this script so that when the player presses Esc while playing the game, the game should pause and the ```PauseCanvas``` should become active. The timer should also pause.

* Class: ```public class PauseMenu : MonoBehaviour```
* Prototype: ```public void Pause()```

Add another method so that If the player presses Esc while in the ```PauseMenu``` or presses the ```Resume``` button, the game should unpause where the player left off and the timer should continue from where it stopped.

* Class: ```public class PauseMenu : MonoBehaviour```
* Prototype: ```public void Resume()```

## 6. Even more button pushing 
In the ```PauseMenu``` and ```PauseMenu.cs```, script the ```RestartButton``` so that it reloads the level scene that the player is currently on.

## 7. Up is down, down is up 
In the ```CameraController.cs``` script, add the ability to invert the Y axis.

Create a public bool called ```isInverted```.

The camera should be able to work in two ways:

* Normal: The camera should move up when the mouse moves up and down when the mouse moves down.
* Inverted: The camera should move up when the mouse moves down and down when the mouse moves up.

## 8. But Y? 
In ```Options``` and ```OptionsMenu.cs```, script it so that checking the ```InvertYToggle``` in the menu and applying the changes reverses the camera/mouse movements in the level scene.

## 9. A winner is you 
In the ```Level01``` Scene, create a new Canvas and using the image as a guide, create a win screen with the following objects:

## 10. Winning isn't everything 
Edit ```WinTrigger.cs``` so that when the player touches the flag, ```WinCanvas``` becomes active.

## 11. Still under development 
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
