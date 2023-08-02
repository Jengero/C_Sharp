using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPatterns.Factory
{
    // Implementation of the base interface whose object will create the factory method
    public class Unicycle : IVehicle
    {
        public void PrintInformation()
        {
            Console.WriteLine("Unicycle has been created");
        }
    }
}