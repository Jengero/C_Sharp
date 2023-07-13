using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPatterns.Factory
{
    //Implementing a factory method to create a specific product type
    public class UnicycleDevelopper : IDeveloper
    {
        public IVehicle Create()
        {
            return new Unicycle();
        }
    }
}