using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpOOP4
{
    public abstract class Shape
    {
        private string _name;
        public string Name
        {
            get => _name;
            set { _name = value; }
        }

        public Shape(string name) { Name = name; }

        public abstract void CalculateVolume();

        public virtual void PrintFigureInformation()
        {
            Console.WriteLine($"Type of figure is {Name}");
        }
    }
}
