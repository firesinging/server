# Server emulation for Age of Empires Online

### Information

'Firesinging' is the open source game server for Age of Empires Online. Currently it is under development. 

This repository aims to re-create server functions based on a first release done by Kisonik. See code reference for more information. 

### Download

You can download a compiled version from the 'download' directory included. This is a debug version which allows you to trace code execution. 

### How to use

Place 'xlive.dll' and 'xlive.ini' from the xlive repository in the game directory of Age of Empires Online. Afterwards, but before starting the game, replace contents within 'xlive.ini' to your custom settings. 

Then look in the 'download\game' folder of this repository. Copy the 'Spartan.exe' into your fresh game installment and thus replacing the original 'Spartan.exe'.

Copy the content directly in the download folder of this repository to a new folder (adviced to keep it near your game folder for easy access) your harddrive and execute 'Server.exe'. Follow the instructions on the screen, normally choosing 'r' to start the server locally. Wait untill the server instances are loaded (green text) and afterwards run 'Spartan.exe' from the game directory. 

### Note
Keep in mind this is a work in progress. At the moment this isn't even 10% of the end result a working server emulation should be. Currently you can only enter the greek capital and take a look around. You cannot play! 


### Sources
Unofficial.Ionic.Zip.1.9.1.8
https://www.nuget.org/packages/Unofficial.Ionic.Zip/

SuperSocket 1.6.6
http://www.supersocket.net/

log4net.2.0.8
https://www.nuget.org/packages/log4net/

HL7Fuse-master
https://github.com/dib0/HL7Fuse

___

*Age of Empires Online © Microsoft Corporation. Firesinging was created under Microsoft's "Game Content Usage Rules" using assets from Age of Empires Online, and it is not endorsed by or affiliated with Microsoft.* 



