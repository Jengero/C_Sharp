using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpException
{
    internal class NegativeOrZeroValueException : Exception
    {
        public double Side;

        public NegativeOrZeroValueException(double value) :
            base($"Error! The value of the side  ({value}) must be a number more, then zero. Please reenter the value of the side:")
        {
            Side = value;
        }
    }
}
