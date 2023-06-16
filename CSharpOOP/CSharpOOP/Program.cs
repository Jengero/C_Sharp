#region Task_1
//Console.WriteLine("Enter the price of the product:");
//var price= new Homework().ReadDoubleFromConsole();
//Console.WriteLine("Enter the quantity of the product:");
//var quantity= new Homework().ReadDoubleFromConsole();
//Console.WriteLine("Enter the discount of the product:");
//var priceDiscount = new Homework().ReadIntFromConsole();
//double finalPrice = new Homework().CalculatePrice(price, priceDiscount, quantity);
//Console.WriteLine($"Calculated price is {finalPrice}");
#endregion
#region Task_2
//Console.WriteLine("Enter the name the first of purchased product: ");
//var firstProductName = Console.ReadLine();
//Console.WriteLine("Enter the name the second of purchased product: ");
//var secondProductName = Console.ReadLine();
//Console.WriteLine("Enter the name the third of purchased product: ");
//var thirdProductName = Console.ReadLine();
//Console.WriteLine($"Enter the quantity of {firstProductName}: ");
//var firstProductQuantity = new Homework().ReadDoubleFromConsole();
//Console.WriteLine($"Enter the quantity of {secondProductName}: ");
//var secondProductQuantity = new Homework().ReadDoubleFromConsole();
//Console.WriteLine($"Enter the quantity of {thirdProductName}: ");
//var thirdProductQuantity = new Homework().ReadDoubleFromConsole();
//Console.WriteLine($"Enter price of {firstProductName}:");
//var firstProductPrice = new Homework().ReadDoubleFromConsole();
//Console.WriteLine($"Enter price of {secondProductName}:");
//var secodProductPrice = new Homework().ReadDoubleFromConsole();
//Console.WriteLine($"Enter price of {thirdProductName}:");
//var thirdProductPrice = new Homework().ReadDoubleFromConsole();
//Console.WriteLine($"Enter the discount, %");
//var priceDiscount = new Homework().ReadDoubleFromConsole();
//new Homework().WriteReceiptLine(firstProductName, firstProductPrice, priceDiscount, firstProductQuantity);
//new Homework().WriteReceiptLine(secondProductName, secodProductPrice, priceDiscount, secondProductQuantity);
//new Homework().WriteReceiptLine(thirdProductName, thirdProductPrice, priceDiscount, thirdProductQuantity);
#endregion
#region Task_3
//Console.WriteLine("Enter the name of purchased product: ");
//var productName = Console.ReadLine();
//Console.WriteLine($"Enter price of {firstProductName}:");
//var productPrice = new Homework().ReadDoubleFromConsole();
//Console.WriteLine("Enter the name the second of purchased product: ");
//var secondProductName = Console.ReadLine();
//Console.WriteLine($"Enter the quantity of {secondProductName}: ");
//var secondProductQuantity = new Homework().ReadDoubleFromConsole();
//Console.WriteLine($"Enter price of {secondProductName}:");
//var secodProductPrice = new Homework().ReadDoubleFromConsole();
//Console.WriteLine($"Enter the discount, %");
//var discount = new Homework().ReadDoubleFromConsole();
//new Homework().WriteReceiptLine(productName, productPrice, discount);
//new Homework().WriteReceiptLine(secondProductName, secodProductPrice, discount, secondProductQuantity);
#endregion
#region Task_4
//Console.WriteLine("Enter the quantity of sides:");
//int numberOfSidesParameter = new Homework().ReadIntFromConsole();
//while (numberOfSidesParameter < 3)
//{
//    Console.WriteLine("The minimum number of sides of a figure is three. Enter correct value:");
//    numberOfSidesParameter = new Homework().ReadIntFromConsole();
//}
//new Homework().CalculatePerimeter(numberOfSidesParameter);
#endregion
#region Task_5
//Console.Write("Enter the length of side 1: ");
//double FirstTriangleSide = new Homework().ReadDoubleFromConsole();
//Console.Write("Enter the length of side 2: ");
//double SecondTriangleSide = new Homework().ReadDoubleFromConsole();
//Console.Write("Enter the length of side 3: ");
//double ThirdTriangleSide = new Homework().ReadDoubleFromConsole();
//new Homework().CalculateArea(FirstTriangleSide, SecondTriangleSide, ThirdTriangleSide);

//Console.Write("Enter the radius of the circle: ");
//double circleRadius = new Homework().ReadDoubleFromConsole();
//new Homework().CalculateArea(circleRadius);
#endregion
public class Homework
{
    public double CalculatePrice(double expectedPrice, double expextedDiscount, double expextedQuantity)
    {
        double finalPrice = (expectedPrice * expextedQuantity) - (expectedPrice * expextedQuantity * expextedDiscount / 100);
        return finalPrice;
    }
    public void WriteReceiptLine(string productName, double unitPrice, double discount, double productQuantity = 1)
    {
        var productPrice = CalculatePrice(unitPrice, discount, productQuantity);
        Console.WriteLine(@$"_________
{productName} x {productQuantity}   {Math.Round(productPrice, 2)} BYN 
_________");
    }
    //{
    //    string[] productNames = new string[productsQuantity];
    //    double[] productQuantities = new double[productsQuantity];
    //    double[] productPrices = new double[productsQuantity];
    //    Console.WriteLine($"Total number of products: {productsQuantity}");
    //    for (int i = 0; i < productsQuantity; i++) 
    //    {
    //        Console.WriteLine("Enter the name of purchased product: ");
    //        var productName = Console.ReadLine();
    //        Console.WriteLine($"Enter the quantity of {productName}: ");
    //        var productQuantity = readDoubleFromConsole();
    //        Console.WriteLine($"Enter price of {productName}:");
    //        var productPrice = readDoubleFromConsole();
    //        productNames[i] = productName;
    //        productQuantities[i] = productQuantity;
    //        productPrices[i] = productPrice;
    //    }
    //    Console.WriteLine($"Enter the discount, %");
    //    var priceDiscount = readDoubleFromConsole();
    //    double[] productPricesWithoutDiscount = new double[productsQuantity];
    //    for (int i = 0; i < productsQuantity; i++) 
    //    {
    //        productPricesWithoutDiscount[i] = CalculatePrice(productPrices[i], 0, productQuantities[i]);
    //    }
    //    Console.WriteLine("Receipt");
    //    Console.WriteLine("_________");
    //    for (int i = 0; i < productsQuantity; i++)
    //    {
    //        Console.WriteLine($"{productNames[i]} x {productQuantities[i]}   {(Math.Round(productPricesWithoutDiscount[i], 2))} BYN");
    //    }
    //    Console.WriteLine("_________");
    //    double totalPriceWithoutDiscount = productPricesWithoutDiscount.Sum();
    //    Console.WriteLine($"Total price without discount: {(Math.Round(totalPriceWithoutDiscount, 2))} BYN");
    //    Console.WriteLine($"Total price with discount: {(Math.Round(CalculatePrice(totalPriceWithoutDiscount, priceDiscount, 1), 2))} BYN");
    //    Console.WriteLine("_________");
    //}
    public void CalculatePerimeter(int quantityOfSides)
    {
        double[] figureSides =  new double[quantityOfSides];
        Console.WriteLine($"Enter {quantityOfSides} sides of the figure:");
        for (int i = 0;i < quantityOfSides;i++)
        {
            figureSides[i] = ReadDoubleFromConsole();
            while (figureSides[i] <= 0 )
            {
                Console.WriteLine("Side length cannot be zero or less. Please, write the correct number:");
                i--;
                continue;
            }
        }
        {
            double perimeter = (Math.Round(figureSides.Sum(),2));
            //double perimeter = 0;
            //foreach (var i in figureSides)
            //{
            //    perimeter += i;
            //}
            Console.WriteLine($"The value of the perimeter is {perimeter}");
        }
    }
    public void CalculateArea(double firstTriangleSide, double secondTriangleSide, double thirdTriangleSide)
    {
        double semiperimeter = (firstTriangleSide + secondTriangleSide + thirdTriangleSide) / 2;
        double triangleArea = Math.Sqrt(semiperimeter * (semiperimeter - firstTriangleSide)
                                                      * (semiperimeter - secondTriangleSide) 
                                                      * (semiperimeter - thirdTriangleSide));
        Console.WriteLine($"The area of the triangle with sides {firstTriangleSide}, {secondTriangleSide} and {thirdTriangleSide} is {Math.Round(triangleArea, 2)}");
    }
    public void CalculateArea(double circleRadius)
    {
        double circleArea = Math.PI * Math.Pow(circleRadius, 2);
        Console.WriteLine($"The area of the circle with the radius {circleRadius} is {Math.Round(circleArea, 2)}");
    }
    public void GiveExamplesOOPrinciples()
    {
        Console.WriteLine(@"
Наследование: разные поколения техники: Iphone 4 => 14, часть фунций предыдущих поколений сохраняется,часть изменяется или появляются новые;
Инкапсуляция: принимая таблетки с обезболивающим действием человеку неизвестен механизм их действия на клеточном уровне;
Полиморфизм: линзы могут использоваться для фокусировки света при коррекции зрения или для создания лазеров;
Абстракция: выбирая блюдо в ресторане мы можем посмотреть на его состав (иногда калораж или БЖУ), но мы не будем смотреть 
(преимущественно) на количество витаминов, микроэлементов и клетчатки.");
    }
    public double ReadDoubleFromConsole()
    {
        string enteredValue = Console.ReadLine();
        enteredValue = enteredValue.Replace(',','.');
        double value;
        bool check = true;
        while (check != double.TryParse(enteredValue, out value))
            Console.WriteLine("Wrong value. Try again");
        return value;
    }
    public int ReadIntFromConsole()
    {
        int value;
        bool check = true;
        while (check != (int.TryParse(Console.ReadLine(), out value)))
            Console.WriteLine("Wrong value. Try again");
        return value;
    }
}