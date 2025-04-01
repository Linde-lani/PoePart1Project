using System.IO;
using System;
using System.Drawing;

namespace PoePart1
{
    public class aiLogo
    {
        public aiLogo()
        {

            //get full location of the project
            string fullLocation = AppDomain.CurrentDomain.BaseDirectory;

            //Replacing the bin\\Debug path
            string newLocation = fullLocation.Replace("bin\\Debug", "");

            //Then combine the path
            string fullPath = Path.Combine(newLocation, "logo.jpg");

            //Using the ascii art

            //Creating the Bitmap class
            Bitmap image = new Bitmap(fullPath);

            //then set the size
            image = new Bitmap(image, new Size(150, 220));

            //outer and inner loop
            for (int height = 0; height < image.Height; height++)
            {

                for (int width = 0; width < image.Width; width++)
                {

                    Color pixelColor = image.GetPixel(height, width);
                    int gray = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    char asciiChar = gray > 200 ? '.' : gray > 150 ? '*' : gray > 100 ? 'o' : gray > 50 ? '#' : '@';
                    Console.WriteLine(asciiChar);

                }//End of inner loop
                Console.WriteLine();

            }//End of outer loop
        }//End of constructor

    }//End of class

}//End of namespace