using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicsTest
{
    public static class IntegerHelper
    {
       public static int GetSquareInt( this int integer) 
        {
            int result = integer * integer;
            return result;
        }
    }
}