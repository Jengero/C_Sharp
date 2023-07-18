using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicsTest
{
    public class Phone
    {
        public double _diagonal;
        public string _model;
        double Diagonal { get => _diagonal; set => _diagonal = value; }
        string Model { get => _model; set => _model = value; }

        public Phone(double diagonal, string model) 
        {
            _diagonal = diagonal;
            _model = model;
        }

        public Phone(string model)
        { 
            _model = model;
        }

        public void PrintInformation() 
        {
            Console.WriteLine($"This is {Model} with {Diagonal}\" screen");
        }
    }
}
