using System.Diagnostics;

namespace CSharpPatterns.Factory
{
    public class Program
    {
        static void Main(string[] args) 
        {
            IDeveloper developer = new CarDevelopper();
            IVehicle vehicle = developer.Create();
            vehicle.PrintInformation();

            developer = new MotorcycleDevelopper();
            vehicle = developer.Create();
            vehicle.PrintInformation();

            developer = new TruckDevelopper();
            vehicle = developer.Create();
            vehicle.PrintInformation();

            developer = new UnicycleDevelopper();
            vehicle = developer.Create();
            vehicle.PrintInformation();
        }
    }
}