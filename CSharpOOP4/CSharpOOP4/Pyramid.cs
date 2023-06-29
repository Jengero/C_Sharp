using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP4
{
    public class Pyramid : Shape
    {
        private double _baseArea;
        private double _height;
        private double _pyramidVolume;
        public double BaseArea
        {
            get => _baseArea;
            set { _baseArea = value; }
        }
        public double Height
        {
            get => _height;
            set { _height = value; }
        }

        public Pyramid(string name, double baseArea, double height) : base(name)
        {
            Name = name;
            BaseArea = baseArea;
            Height = height;
        }

        public override void CalculateVolume()
        {
            _pyramidVolume = Math.Round(BaseArea * Height / 3, 2);
        }

        public override void PrintFigureInformation()
        {
            base.PrintFigureInformation();
            Console.WriteLine($"The height is {Height}");
            Console.WriteLine($"The area of the base is {BaseArea}");
            Console.WriteLine($"The volume is {_pyramidVolume}");
        }
    }
}
