using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Exceptions
{
    public class OutOfMemoryException : Exception
    {
        public OutOfMemoryException(string message)
            : base(message)
        { }
    }
}
