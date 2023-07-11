using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpException
{
    public class Triangle
    {
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;

        public double FirstSide
        {
            get => _firstSide;
            internal set 
            { 
                _firstSide = value; 
            }
        }

        public double SecondSide
        {
            get => _secondSide;
            internal set 
            { 
                _secondSide = value; 
            }
        }

        public double ThirdSide
        {
            get => _thirdSide;
            internal set 
            { 
                _thirdSide = value; 
            }
        }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        public void CheckSidesValues()
        {
            if (FirstSide > SecondSide + ThirdSide) { throw new SideValueException(FirstSide, SecondSide, ThirdSide); }
            else if (SecondSide > FirstSide + ThirdSide) { throw new SideValueException(SecondSide, FirstSide, ThirdSide); }
            else if (ThirdSide > FirstSide + SecondSide) { throw new SideValueException(ThirdSide, FirstSide, SecondSide); }
            else { Console.WriteLine($"Triangle with {FirstSide}, {SecondSide}, {ThirdSide} sides"); } 
        }
        public static double EnterSide()
        {
            double side = 0;
            bool correctValue = false;
            while (!correctValue)
            {
                try
                {
                    side = ConsoleReader.ReadDouble();
                    if (side <= 0) { throw new NegativeOrZeroValueException(side); }
                    else correctValue = true;
                }
                catch (NegativeOrZeroValueException ex)
                {
                    Console.WriteLine(ex.Message);
                    correctValue = false;
                }
            }
            return side;
        }
    }
}
