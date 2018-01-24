using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMTR
{
    class DebugUtils
    {
        /// <summary>
        /// Logs a message to the console
        /// </summary>
        /// <param name="message">[string] The message to display</param>
        /// <param name="newLine">[bool] Add a new line to the end</param>
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
