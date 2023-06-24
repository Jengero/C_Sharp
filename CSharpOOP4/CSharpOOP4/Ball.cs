using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP4
{
    public class Ball : Shape
    {
        public double Radius
        {
            get => _radius;
            set { _radius = value; }
        }
        private double _radius;
        public double ballVolume;

        public Ball(string name, double radius) : base(name)
        {
            Name = "Ball";
            Radius = radius;
        }

        public override void CalculateVolume()
        {
            ballVolume = Math.Round(4 * Math.PI * (Math.Pow(Radius, 3)) / 3, 2); 
        }
        public override void PrintFigureInformation()
        {
            base.PrintFigureInformation();
            Console.WriteLine($"The radius is {Radius}");
            Console.WriteLine($"The volume is {ballVolume}");
        }
    }
}
