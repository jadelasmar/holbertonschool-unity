# 0x05. Unity - Assets: Models, Textures

# Learning Objectives

* What is an Asset and how to import and use them
* How to use Asset Packages and the Unity Asset Store
* What are common Asset types
* How to use Unity primitives as placeholders to prototype a project
* What are materials and how to use them
* What are textures and how to use them
* What is a skybox
* What is are the components of a 3D model
* What is a mesh
* How to create UI elements with image components
* What is a Rigidbody and what is a Character Controller and what are the pros and cons of using each
* What is a Quaternion


# Tasks

## 0. Primitive player 
Create a new Scene called ```Level01```. Create a capsule GameObject called ```Player``` which will be a placeholder for this project.

* Position: ```X: 0```, ```Y: 1.25```, ```Z: 0```
* Rotation: ```X: 0```, ```Y: 0```, ```Z: 0```
* Scale: ```X: 1```, ```Y: 1```, ```Z: 1```

## 1. Primitive prototype 
In the ```Level01``` scene, create a layout of floating platforms of different sizes and positions using only Unity Cube GameObjects, . Plan for a start point and an endpoint and create a path so that the ```Player``` can jump between them. The cubes will be placeholders for 3D models that we will import later on.

## 2. Pole position 
At the end point of the platforms, create a placeholder cylinder GameObject called ```WinFlag``` to designate the end of the path. Do not make ```WinFlag``` a child of any object. Later we will add scripting for when the ```Player``` reaches the ```WinFlag```.

## 3. Jump man 
Create a new folder called ```Scripts```. Inside that folder, create a new C# script called ```PlayerController``` and attach it to ```Player```.

## 4. Camera ready 
Position the ```Main Camera``` at an offset behind the player.

## 5. Steady cam 
In the Scripts folder, create a new C# script called ```CameraController``` that allows the camera to follow the player. The script should also allow the player to rotate the camera on their own by moving the mouse, either by just moving the mouse or holding down right-click and dragging the mouse to move the camera.

## 6. Falling up 
Currently if the player falls off a platform, it falls infinitely. Edit the ```PlayerController``` and ```CameraController``` scripts so that if the player falls from a platform and can’t get to another platform, the player instead falls from the top of the screen onto the start position, causing the player to need to start from the beginning again.

## 7. Time trial 
Create a new Canvas and UI Text element that displays a timer on screen.

## 8. Clock's ticking 
Create a script called ```Timer``` and attach to the ```Player```. ```Timer``` should have a public Text variable called ```Timer Text``` for the ```TimerText``` Text object.

The timer should start at ```0:00.00``` and count up.

## 9. Finish line 
Create a script called ```WinTrigger``` and attach to ```WinFlag```.

When the ```Player``` touches the ```WinFlag``` collider, the timer should stop and the text size should increase and the color should change to ```green```. The recommended increased font size is ```60``` but the value is at your discretion as long as the size increase is noticeable to the user.

## 10. The sky's the limit 
In the Unity Asset Store, find ```Farland Skies - Cloudy Crown```, a free set of skyboxes. Add them to a folder called ```Skyboxes``` in the ```Assets/Materials``` folder in your ```0x05-unity-assets``` project.

## 11. The great outdoors 
Download Kenney’s Nature Pack Extended. Import the asset package and place the files in a directory called ```Models```. For the sake of organization, inside the ```Assets``` folder, create a new directory called ```Materials``` and move the materials in ```Models``` into ```Materials```.

## 12. Environmental awareness 
From the Nature Pack asset package in your ```Models``` folder, add trees, rocks, flowers, etc. to the platforms as you like. Organize your objects in your Hierarchy using empty GameObjects.

## 13. What's left of the flag 
Download this flag model. Place it in the ```Models``` directory. Add ```Flag``` to your scene and make it a child of the ```WinFlag``` GameObject. The pole of the flag should be positioned inside ```WinFlag‘s``` collider. Resize or reposition the collider if necessary.

## 14. (Sea)horse race 
Download this flag texture. Place it in a new directory called ```Textures```.

## 15. Under development 
**Scenes in Build:**

1. ```Level01```

Create three builds of ```Level01``` in a directory called ```Builds```.

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
