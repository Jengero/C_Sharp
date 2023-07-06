using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpException
{
    public class Triangle
    {
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

        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        public static double EnterSide()
        {
            double side = 0;
            bool correctValue = false;
            while (!correctValue)
            {
                try
                {
                    side = ReadDoubleFromConsole.ReadDouble();
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
