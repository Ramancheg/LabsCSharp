using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Exceptions
{
    public class InvalidCastException : Exception
    {
        public InvalidCastException(string message)
            : base(message)
        { }
    }
}
