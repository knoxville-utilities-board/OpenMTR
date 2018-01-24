using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace OpenMTR
{
    partial class Program
    {
        // The main directory path that contains all the photos and metadata
        public static string DirectoryPath { get; set; }

        // Set this to false if you don't want debug logs. 
        public const bool DEBUG = true;

        /// <summary>
        /// Main Method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Welcomes the user ane gets the directory path to process
            Welcome.WelcomeUser();
            Console.Read();
        }
    }
}
