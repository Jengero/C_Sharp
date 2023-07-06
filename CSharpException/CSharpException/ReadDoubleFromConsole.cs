using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpException
{
    internal static class ReadDoubleFromConsole
    {
        public static double ReadDouble()
        {
            Console.WriteLine("Enter the value of the side of triangle: ");
            string enteredValue = Console.ReadLine();
            enteredValue = enteredValue.Replace(',', '.');
            double value;
            bool check = true;
            while (check != double.TryParse(enteredValue, out value))
            {
                Console.WriteLine("Wrong value. Try again");
                enteredValue = Console.ReadLine();
            }
            return value;
        }


    }
}
