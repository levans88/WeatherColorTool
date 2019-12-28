# WeatherColorTool
Fallout 4 Weather Color Tool (DIY Radstorm Colorizer - Edit Weathers as Bitmap Images)

<b>Features</b>

- Edit weathers for Fallout 4 as BMPs in Paint.NET or your favorite image editor (adjust hue/saturation, whatever)
- Convert weather images from BMP to CSV using ImageToCSV.exe
- Import weather CSVs into xEdit (skips disabled cloud layers as it should)
- Supports cloud layers, weather colors, and ambient light colors as separate images (all cloud layers as single image)

<b>Repository Description</b>

This repository contains a Delphi project (\WeatherColorTool), a C# project (\ImageToCSV), and an xEdit script (\Weather Editor.pas).

The Delphi project was used to modify xEdit's "Weather Editor.pas" script in RAD Studio with syntax highlighting and intellisense. I had to comment some things out for the IDE to be useful and let me build, so it is called "WeatherColorTool.pas" when being used in Delphi RAD Studio. The finalized version is a modified replacement for xEdit's "Weather Editor.pas" script and is in the root of this repository. For more on setting up a dev environment for Delphi/xEdit scripts, see this link:  https://tes5edit.github.io/docs/11-Scripting-Functions.html#s_11-2

The C# project is for converting bitmaps to CSV files for import by the "Weather Editor.pas" script.

<b>Notice</b>

The modified version of this script retains all original functionality for other games, but the new functionality will only execute and work for Fallout 4 at this time.

<b>Usage Instructions</b>

Acquiring Images
1) Backup your original "Weather Editor.pas" xEdit script, and drop this repo's version into your xEdit "Edit Scripts" folder.
2) Load FO4Edit including whatever weather plug-in(s) contain the weather records you want to modify.
3) Click on the weather record you want to recolor, press "Ctrl + w" to run the Weather Editor.
4) Take a screen shot of the section of colors you want to edit (Weather Colors or Directional Ambient Light Colors). For Cloud Layer Colors you'll have to take one screen shot per layer and assemble into a single BMP for now. Trim screenshots and/or assemble them into your BMP files just like the sample images using the same dimensions.
5) Edit your weather images using Paint.NET or your favorite image editing tool. Avoid dithering and anti-aliasing at save and on tool usage. Save your files as BMP.

Importing Images
1) Place your images in the same folder as ImageToCSV.exe and run the program. A CSV for each image will be created.
2) Return to or re-open FO4Edit including whatever weather plug-in(s) contain the weather records you want to modify.
3) Right-click on the weather record(s) you want to modify and "Copy as Override" into a new plug-in (name it whatever you want).
4) Go to the copy of the weather you just made, click on it, and press "Ctrl + w" to run the Weather Editor.
5) Click on the "Tools" tab.
6) Press the load button associated with the type of CSV you would like to import: "Load Weather CSV", "Load Lighting CSV", or "Load Clouds CSV". You will get a message prompting you to re-run the script to see the changes, but you can load all three before you do that if you want.
7) Close the Weather Editor and re-run it (Ctrl + w) to verify the changes were made.
8) Take note of your weather's ID, exit, and save your plug-in. Install your plug-in as you normally would and take note of its load order.
9) Run your game, open the console, and test your changes with "fw XXXXXXXX" (where the XXXXXXXX is your weather's ID).
