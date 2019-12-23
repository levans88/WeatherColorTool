# WeatherColorTool
Fallout 4 Weather Color Tool

Work in progress... don't try to run this script right now.

The intention is to create a script that can import a file containing RGB data for weather colors into xEdit.

I want to change the collective hue of the colors involved in a rad storm in Paint.net instead of hand editing 700+ fields just to test a palette/idea.

The plan is to use the existing "Weather Editor.pas" script in xEdit (Ctrl + W) or its code to export screenshots of the colors for a specific weather, edit the image colors in whatever way, then use a modified version of the same weather script to load the new colors from a file (ex: image, array in text file, etc.)

The three groups of colors, their screenshot dimensions, and their fields as named in "Weather Editor.pas" are listed below:

1) Clouds, 1360 x 50, "Layer 0" through "Layer 28". Some layers are enabled (checked) but many might not be. <b>Rad storm cloud layers appear to be all the same color. This experiment does not need to handle cloud layers at this time</b>.

2) Weather Colors, 1360 x 950
- X-Axis: Sunrise, Day, Sunset, Night, Unknown, Unknown, Unknown, Unknown
- Y-Axis: Sky-Upper, Fog Near, Unknown, Ambient, Sunlight, Sun, Stars, Sky-Lower, Horizon, Effect Lighting, Cloud LOD Diffuse, Cloud LOD Ambient, Fog Far, Sky Statics, Water Multiplier, Sun Glare, Moon Glare, Unknown1, Unknown2

3) Directional Ambient Lighting Colors, 1360 x 300
- X-Axis: Sunrise, Day, Sunset, Night, Unknown, Unknown, Unknown, Unknown
- Y-Axis: Color #0 (X+), Color #1 (X-), Color #2 (Y+), Color #3 (Y-), Color #4 (Z+), Color #5 (Z-)
