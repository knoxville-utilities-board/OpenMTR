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
        public static void WelcomeUser()
        {
            Console.WriteLine("----------------------------------\n        Welcome to OpenMTR\n----------------------------------\nYou can exit by entering q or quit\n\n");

            GetPathFromUser();
        }


        protected static void GetPathFromUser()
        {
            string tempPath = "";

            Console.Write("Please enter the full path to a folder to process: ");
            tempPath = Console.ReadLine();

            while (!Directory.Exists(tempPath))
            {
                if (tempPath == "q" || tempPath == "quit")
                {
                    Environment.Exit(0);
                }
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Directory does not exist. ");
                Console.ResetColor();
                Console.Write("Please enter the full path to a folder to process: ");

                tempPath = Console.ReadLine();
            }

            Program.DirectoryPath = tempPath;

            FHTestDriver FHT = new FHTestDriver(tempPath);

            DebugUtils.Log($"Process path is: {Program.DirectoryPath}", true);

            FHT.test();
        }
    }
}
