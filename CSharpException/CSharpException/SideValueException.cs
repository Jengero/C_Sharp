using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpException
{
    internal class SideValueException : Exception
    {
        public double side;
        public SideValueException(double value, double firstSide, double secondSide) :
            base($"Error! The value of the side of triangle ({value}) must be less, than sum of each others ({firstSide + secondSide})" )
        {
            side = value;
        }
    }
}