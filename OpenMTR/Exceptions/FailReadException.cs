using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMTR
{
    public class FailReadException : Exception
    {
        public FailReadException()
        {
        }

        public FailReadException(string message)
            : base(message)
        {
        }

        public FailReadException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
