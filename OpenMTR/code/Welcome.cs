using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMTR
{
    public class Welcome
    {
        /// <summary>
        /// Welcomes the user to the application and gets the directory to process from the console. 
        /// </summary>
        public static void WelcomeUser()
        {
            // Welcome the user!
            Console.WriteLine(@"
----------------------------------
        Welcome to OpenMTR
----------------------------------
You can exit by entering q or quit



");
            // Get the directory to process
            GetProcessDirectory();
        }


        /// <summary>
        /// Gets and sets the 
        /// </summary>
        protected static void GetProcessDirectory()
        {
            // Used to get the path from the user, and confirm it exists
            bool validatingPath = true;
            string tempPath = "";

            // Get the path and confirm it exists
            while (validatingPath)
            {
                Console.Write("Please enter the full path to a folder to process: ");
                tempPath = Console.ReadLine();

                if (Directory.Exists(tempPath))
                {
                    validatingPath = false;
                    Program.DirectoryPath = tempPath;
                }
                else if (tempPath == "q" || tempPath == "quit")     // We want to be able to exit the application
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Directory does not exist.");
                }
            }

            // Log it out so we know. 
            DebugUtils.Log($"Process path is: {Program.DirectoryPath}", true);
        }
    }
}
