using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing;

namespace ImageToCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            int writeCount = 0;
            string[] filePaths = Directory.GetFiles(@".\", "*.bmp");

            if (filePaths.Length == 0)
            {
                Console.WriteLine("No BMP files found. Place BMP files for conversion in the same folder as this application and try again.");
            }
            else
            {
                foreach(var fileName in filePaths)
                {
                    string csv = "";
                    Bitmap bmp = new Bitmap(fileName);

                    GraphicsUnit units = GraphicsUnit.Pixel;
                    RectangleF rect = bmp.GetBounds(ref units);

                    // *NOTE*
                    // For weather colors, we write each column in a row first.
                    // For ambient lighting colors, we write each row in a column first.
                    // This is because loading the CSV colors into the ambient lighting color
                    // panel in xEdit happens by column but weather colors is by row.

                    // If image is for weather colors...
                    if (rect.Height == 950) {
                        var xColorCount = (int)Math.Floor(rect.Width / 170);
                        var yColorCount = (int)Math.Floor(rect.Height / 50);

                        // For each row...
                        for (var yColor = 0; yColor < yColorCount; yColor++)
                        {
                            // For each column...
                            for (var xColor = 0; xColor < xColorCount; xColor++)
                            {
                                // Each color is 50 x 170
                                Color color = bmp.GetPixel(xColor * 171, yColor * 51);
                                int blue = color.B;
                                int green = color.G;
                                int red = color.R;

                                // Append to CSV
                                csv += blue.ToString() + "," + green.ToString() + "," + red.ToString() + ",";
                            }
                        }

                        // Remove trailing comma from last color
                        csv = csv.TrimEnd(',');

                        // Write to CSV file
                        File.WriteAllText(fileName.Split('\\')[1].Split('.')[0] + ".csv", csv);
                        writeCount += 1;
                    }
                    // If image is for ambient lighting colors...
                    else if (rect.Height == 300)
                    {
                        var xColorCount = (int)Math.Floor(rect.Width / 170);
                        var yColorCount = (int)Math.Floor(rect.Height / 50);

                        // For each column...
                        for (var xColor = 0; xColor < xColorCount; xColor++)
                        {
                            // For each row...
                            for (var yColor = 0; yColor < yColorCount; yColor++)
                            {
                                // Each color is 50 x 170
                                Color color = bmp.GetPixel(xColor * 171, yColor * 51);
                                int blue = color.B;
                                int green = color.G;
                                int red = color.R;

                                // Append to CSV
                                csv += blue.ToString() + "," + green.ToString() + "," + red.ToString() + ",";
                            }
                        }

                        // Remove trailing comma from last color
                        csv = csv.TrimEnd(',');

                        // Write to CSV file
                        File.WriteAllText(fileName.Split('\\')[1].Split('.')[0] + ".csv", csv);
                        writeCount += 1;
                    }
                    // If image is cloud layer colors...
                    else if (rect.Height == 1450)
                    {
                        var xColorCount = (int)Math.Floor(rect.Width / 170);
                        var yColorCount = (int)Math.Floor(rect.Height / 50);

                        // For each row...
                        for (var yColor = 0; yColor < yColorCount; yColor++)
                        {
                            // For each column...
                            for (var xColor = 0; xColor < xColorCount; xColor++)
                            {
                                // Each color is 50 x 170
                                Color color = bmp.GetPixel(xColor * 171, yColor * 51);
                                int blue = color.B;
                                int green = color.G;
                                int red = color.R;

                                // Append to CSV
                                csv += blue.ToString() + "," + green.ToString() + "," + red.ToString() + ",";
                            }
                        }

                        // Remove trailing comma from last color
                        csv = csv.TrimEnd(',');

                        // Write to CSV file
                        File.WriteAllText(fileName.Split('\\')[1].Split('.')[0] + ".csv", csv);
                        writeCount += 1;
                    }
                    else
                    {
                        Console.WriteLine("Invalid image dimension(s).");
                    }
                }

                if (writeCount > 0) {
                    Console.WriteLine("Converted " + writeCount + " BMPs to CSV.");
                }
                else
                {
                    Console.WriteLine("Something went wrong.");
                }
            }
        }
    }
}
