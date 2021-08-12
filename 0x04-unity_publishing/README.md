# 0x04. Unity - Publishing

# Learning Objectives
* How to publish a build
* How to reorder scenes in a build
* How to build a standalone application for Windows, Mac, and Linux
* How to edit a project’s Quality Settings
* How to add an icon to your build
* What is the profiler and how to use it to check your project’s performance
* What to consider when developing for different platforms

## 0. Quality Settings
Clone your 0x03-unity-ui repo into a new folder called 0x04-unity_publishing inside your holbertonschool-unity repo.

In this project, you will be exploring how to publish a game to play on Windows, Mac, or Linux. If there are any changes or improvements you’d like to make to the maze in this repo, feel free! This project will only be checking your build settings and the final standalone game. If you do make changes to your maze, it’s strongly recommended to have a peer play it to make sure it works as intended.

Edit the project’s Quality Settings. Your project should have three quality levels:
Low, Medium & High.

## 1. Player Settings
Edit the Player Settings for PC, Mac, & Linux Standalone. Unless otherwise specified below, leave settings with their default values. Create a new directory in the Assets folder called Images.

* Company Name: Your name
* Product Name: Maze
* Default Icon: Use this image or make your own (File name must be mazeicon.png and saved in directory Assets/Images/)

Resolution and Presentation:

* Default Is Full Screen: Off
* Default Screen Width: 1024
* Default Screen Height: 768
* Resizable Window: On

Splash Image:

* Splash Style: Light on Dark
* Animation: Dolly
* Draw Mode: Unity Logo Below
* Logos: Use this image or make your own (File name must be mazelogo.png and saved in directory Assets/Images/)
* Logo Duration: 4

## 2. Build Settings 
Scenes in Build:

* menu
* maze

Create three builds of the maze in a directory called Builds in the root of your project folder (not inside the Assets folder).

Windows and Linux builds should be set to x86_64 architecture
Do not check Development Build
Build Folder Hierarchy:

* Builds
  * Linux
    * Maze_Data
    * Maze.x86_64
  * Mac
    * Maze.app
  * Windows
    * Maze_Data
    * Maze.exe
    * UnityPlayer.dll
Make sure to run your build and make sure it works! It should open with the logo splash screen then the menu. Test your build on all three platforms if possible, but at the very least test on your own computer.

Create a .zip of each build:

* Maze_Mac.zip
* Maze_Linux_x86_64.zip
* Maze_Windows_x86_64.zip
