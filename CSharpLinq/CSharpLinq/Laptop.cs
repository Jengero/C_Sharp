namespace CSharpOOP2
{

    public class Laptop
    {
        public string Manufacturer
        {
            get => _manufacturer;
            internal set { _manufacturer = value; }
        }
        public double Price;
        public double ScreenDiagonal;
        public bool IsGraphicsCardDiscrete;
        public int ProcessorGeneration;
        public double LaptopVat => _laptopVat;
        public bool IsExtendedWarranty 
        {
            set { isExtendedWarranty = value; }
        }
        public static string ProcessorManufacturer;
        public static int priceDiscount;
        private double _laptopVat = 0.2;
        internal bool isExtendedWarranty;
        private string _manufacturer = "Indeterminate";

        public Laptop(string _manufacturer, double screenDiagonal, bool discreteGraphicsCard, int processorGeneration, bool isExtendedWarranty, double price ) 
        {   Manufacturer = _manufacturer; 
            ScreenDiagonal = screenDiagonal; 
            IsGraphicsCardDiscrete = discreteGraphicsCard; 
            ProcessorGeneration = processorGeneration; 
            IsExtendedWarranty = isExtendedWarranty; 
            Price = price; 
        }
        public Laptop(string _manufacturer) { Manufacturer = _manufacturer; }
        public Laptop() {}

        public static void ChangePaymentMethod() 
        {
            Console.WriteLine(@"Choose appropriate method of payment. Type 1, 2 or 3:
1.Full payment in cash 
2.Full payment by card 
3.Payment by installments");
            int paymentMethod = ReadIntFromConsole();
            if (paymentMethod == 1) { Console.WriteLine("Full payment in cash is selected"); }
            else if (paymentMethod == 2) { Console.WriteLine("Full payment by card is selected"); }
            else if (paymentMethod == 3) { Console.WriteLine("Payment by installments is selected"); }
            else { Console.WriteLine("Value should be 1,2 or 3"); }  
        }
        public static int ReadIntFromConsole()
        {
            string enteredValue = Console.ReadLine();
            int value;
            bool check = true;
            while (check != int.TryParse(enteredValue, out value))
            {
                Console.WriteLine("Wrong value. Try again");
                enteredValue = Console.ReadLine();
            }
            return value;
        }
    }

}
