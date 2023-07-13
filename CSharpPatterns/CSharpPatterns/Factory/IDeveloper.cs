using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPatterns.Factory
{
    //Defining base factory method
    public interface IDeveloper
    {
        IVehicle Create();
    }
}