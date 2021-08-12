# 0x04. Unity - Publishing

## 0. Quality Settings
Clone your ```0x03-unity-ui``` repo into a new folder called ```0x04-unity-publishing``` inside your holbertonschool-unity repo.

In this project, you will be exploring how to publish a game to play on Windows, Mac, or Linux. If there are any changes or improvements you’d like to make to the ```maze``` in this repo, feel free! This project will only be checking your build settings and the final standalone game. If you do make changes to your ```maze```, it’s strongly recommended to have a peer play it to make sure it works as intended.

## 1. Player Settings
Edit the Player Settings for PC, Mac, & Linux Standalone. Unless otherwise specified below, leave settings with their default values. Create a new directory in the Assets folder called ```Images```.

## 2. Build Settings 
**Scenes in Build:**

1. ```menu```
2. ```maze```

Create three builds of the ```maze``` in a directory called Builds in the root of your project folder (not inside the Assets folder).

* Windows and Linux builds should be set to ```x86_64``` architecture
* Do not check ```Development Build```

## 3. Mobile maze
Create an iOS build or an Android build of the ```maze```.

* You cannot create a new Unity project – you must be able to build Windows, Mac, Linux, and iOS/Android builds all from ```0x04-unity-publishing```
* The game should load in landscape orientation
* The ```Player``` must move with either touch controls or tilt controls
* The ```menu``` buttons must work with touch controls
* For iOS, create a ```Menu``` button in the ```maze``` scene that opens the ```menu```
* For Android, the back button should also open the ```menu```
* All other functionality of the maze should remain the same
* It is not required to build for both iOS and Android, but you are welcome to do both if you have the resources to build and test for both.