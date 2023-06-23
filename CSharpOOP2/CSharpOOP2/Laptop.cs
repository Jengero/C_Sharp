using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP2
{

    public class Laptop
    {
        public string Manufacturer;
        public double ScreenDiagonal;
        public bool IsGraphicsCardDiscrete;
        public int ProcessorGeneration = 3;

        public Laptop(string Manufacturer, double ScreenDiagonal, bool IsGraphicsCardDiscrete, int ProcessorGeneration) {}
        public Laptop() {}
        public Laptop(string Manufacturer, double ScreenDiagonal) {}

        public void ChangeScreenDiagonal()
        {
            Console.WriteLine($"Current diagonal of the screen is {ScreenDiagonal}");
            Console.WriteLine("Select from the list below to what value to change the screen diagonal:");
            Console.WriteLine("10.6\", 11.1\", 11.6\", 12.1\", 13.1\", 13.3\", 14.0\", 14.1\", 14.5\"");
            Console.WriteLine("15.0\", 15.1\", 15.6\", 16.0\", 16.4\", 17.0\", 17.1\", 17.3\", 18.4\"");
            double screenSize = ReadDoubleFromConsole();
            double[] screenDiagonale = new double[] { 10.6, 11.1, 11.6, 12.1, 13.1, 13.3, 14.0, 14.1, 14.5, 15.0, 15.1, 15.6, 16.0, 16.4, 17.0, 17.1, 17.3, 18.4 };

            for (int i = 0; i < screenDiagonale.Length; i++)
            {
                if (screenSize == screenDiagonale[i])
                {
                    ScreenDiagonal = screenSize;
                    Console.WriteLine($"Screen size changed to {ScreenDiagonal}\"");
                    break;
                }
                else if (screenSize != screenDiagonale[i] && i == 17)
                {
                    Console.WriteLine("Wrong value. Please select from the presented list");
                    i = 0;
                    screenSize = ReadDoubleFromConsole();
                }
                else { }
            }
        }
        private void PrintScreenDiagonal() 
        {
            Console.WriteLine($"Current screen diagonal is {ScreenDiagonal}"); 
        }
        internal void PrintProcessorGeneration()
        {
            Console.WriteLine($"Current processor generation is {ProcessorGeneration}");
        }

        public double ReadDoubleFromConsole()
        {
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
