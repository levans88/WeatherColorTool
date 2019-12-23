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
            string[] filePaths = Directory.GetFiles(@".\", "*.png");

            if (filePaths.Length == 0)
            {
                Console.WriteLine("No PNG files found. Place PNG files for conversion in the same folder as this application and try again.");
            }
            else
            {
                foreach(var fileName in filePaths)
                {
                    string csv = "";
                    Bitmap bmp = new Bitmap(fileName);

                    GraphicsUnit units = GraphicsUnit.Pixel;
                    RectangleF rect = bmp.GetBounds(ref units);

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
                            int red = color.R;
                            int green = color.G;
                            int blue = color.B;

                            // Append to CSV
                            csv += red.ToString() + "," + green.ToString() + "," + blue.ToString() + ",";
                        }
                    }

                    // Remove trailing comma from last color
                    csv = csv.TrimEnd(',');

                    // Write to CSV file
                    File.WriteAllText(fileName.Split('\\')[1].Split('.')[0] + ".csv", csv);
                    writeCount += 1;
                }

                if (writeCount > 0) {
                    Console.WriteLine("Converted " + writeCount + " PNGs to CSV.");
                }
                else
                {
                    Console.WriteLine("Something went wrong.");
                }
            }
        }
    }
}
