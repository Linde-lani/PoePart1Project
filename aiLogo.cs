using System.IO;
using System;

namespace PoePart1
{
    public class aiLogo
    {
        public aiLogo()
        {
            //This retieves the location where the app is running
            string projectLocation = AppDomain.CurrentDomain.BaseDirectory;

            //Displays the project location
            Console.WriteLine(projectLocation);

            //The code will be updated the "bin\\Debug\\" into an empty string
            string updatedPath = projectLocation.Replace("bin\\Debug\\", "");

            //The path to the txt file is constructed
            //The complete path string is stored in the full_path string
            string fullPath = Path.Combine(updatedPath, "AiLogo.txt");

            //This method is called to show the logo
            showLogo(fullPath);


            
        }

        private void showLogo(string full_path)
        {
            try
            {
                // Read all lines from the text file
                string[] asciiArtLines = File.ReadAllLines(full_path);

                // Print each line to the console
                foreach (string line in asciiArtLines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: ASCII art file not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

}   }