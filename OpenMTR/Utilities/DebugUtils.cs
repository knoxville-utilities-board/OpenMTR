using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace OpenMTR
{
    public static class DebugUtils
    {
        public static void Log(string message, bool newLine = true)
        {
            if (Program.DEBUG)
            {
                if (newLine)
                {
                    message += Environment.NewLine;
                }

                Console.Write(message);
            }
        }
    }
}
