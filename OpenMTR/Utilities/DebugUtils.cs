using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMTR
{
    class DebugUtils
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
