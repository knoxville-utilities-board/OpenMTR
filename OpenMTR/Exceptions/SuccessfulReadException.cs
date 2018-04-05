using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMTR
{
    public class SuccessfulReadException : Exception
    {
        public SuccessfulReadException()
        {
        }

        public SuccessfulReadException(string message)
            : base(message)
        {
        }

        public SuccessfulReadException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
