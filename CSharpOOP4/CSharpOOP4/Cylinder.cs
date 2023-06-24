using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP4
{
    public class Cylinder : Shape
    {
        public double Radius
        {
            get => _radius;
            set { _radius = value; }
        }
        public double Height
        {
            get => _height;
            set { _height = value; }
        }
        private double _radius;
        private double _height;
        public double cylinderVolume;

        public Cylinder(string name, double radius, double height ) : base(name)
        {
            Name = "Cylinder";
            Radius = radius;
            Height = height;
        }

        public override void CalculateVolume()
        {
            cylinderVolume = Math.Round(Math.PI * Math.Pow(Radius, 2) * Height, 2);
        }
        public override void PrintFigureInformation()
        {
            base.PrintFigureInformation();
            Console.WriteLine($"The height is {Height}");
            Console.WriteLine($"The radius is {Radius}");
            Console.WriteLine($"The volume is {cylinderVolume}");
        }
    }
}
