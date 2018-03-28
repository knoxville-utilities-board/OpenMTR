using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMTR
{
    public class PassFailException : Exception
    {
        public PassFailException()
        {
        }

        public PassFailException(string message)
            : base(message)
        {
        }

        public PassFailException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
