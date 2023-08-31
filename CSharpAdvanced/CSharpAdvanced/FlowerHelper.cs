using System.Security.Cryptography.X509Certificates;

namespace CSharpAdvanced
{
    public static class FlowerHelper
    {
        public static double CalculateBulkDiscount(this Flower flower)
        {
            double bulkDiscountRate = 0.1;
            flower.Price = flower.Price - Math.Round(flower.Price * bulkDiscountRate, 2);
            return flower.Price;
        }

        public static void CalculateRepaintedPrice(this Flower flower) 
        {
            double appreciationCoefficient = 0.15;
            double newPrice = flower.Price + flower.Price * appreciationCoefficient;
            flower.Price = newPrice;
        }
    }
}
