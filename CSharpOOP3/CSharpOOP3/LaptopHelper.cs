using CSharpOOP2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP3
{
    public static class LaptopHelper
    {

        public static void PrintScreenDiagonal(this Laptop laptop) 
        {
            Console.WriteLine($"This model has {laptop.ScreenDiagonal}\" screen diagonal ");
        }


        public static double CalculatePriceWithDiscount(this Laptop laptop)
        {
            laptop.Price = laptop.Price - (laptop.Price * Laptop.priceDiscount / 100);
            return laptop.Price;
        }
    }
}
