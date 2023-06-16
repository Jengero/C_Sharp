#region Task_1
//Console.WriteLine("Enter the price of the product:");
//var price= new Homework().readDoubleFromConsole();
//Console.WriteLine("Enter the quantity of the product:");
//var quantity= new Homework().readDoubleFromConsole();
//Console.WriteLine("Enter the discount of the product:");
//var priceDiscount = new Homework().readIntFromConsole();
//double finalPrice = new Homework().Task_1(price, priceDiscount, quantity);
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
//var firstProductQuantity = new Homework().readDoubleFromConsole();
//Console.WriteLine($"Enter the quantity of {secondProductName}: ");
//var secondProductQuantity = new Homework().readDoubleFromConsole();
//Console.WriteLine($"Enter the quantity of {thirdProductName}: ");
//var thirdProductQuantity = new Homework().readDoubleFromConsole();
//Console.WriteLine($"Enter price of {firstProductName}:");
//var firstProductPrice = new Homework().readDoubleFromConsole();
//Console.WriteLine($"Enter price of {secondProductName}:");
//var secodProductPrice = new Homework().readDoubleFromConsole();
//Console.WriteLine($"Enter price of {thirdProductName}:");
//var thirdProductPrice = new Homework().readDoubleFromConsole();
//Console.WriteLine($"Enter the discount, %");
//var priceDiscount = new Homework().readDoubleFromConsole();
//new Homework().Task_2(firstProductName, firstProductPrice, priceDiscount, firstProductQuantity);
//new Homework().Task_2(secondProductName, secodProductPrice, priceDiscount, secondProductQuantity);
//new Homework().Task_2(thirdProductName, thirdProductPrice, priceDiscount, thirdProductQuantity);
#endregion
#region Task_3
//Console.WriteLine("Enter the name of purchased product: ");
//var productName = Console.ReadLine();
//Console.WriteLine($"Enter price of {firstProductName}:");
//var productPrice = new Homework().readDoubleFromConsole();
//Console.WriteLine("Enter the name the second of purchased product: ");
//var secondProductName = Console.ReadLine();
//Console.WriteLine($"Enter the quantity of {secondProductName}: ");
//var secondProductQuantity = new Homework().readDoubleFromConsole();
//Console.WriteLine($"Enter price of {secondProductName}:");
//var secodProductPrice = new Homework().readDoubleFromConsole();
//Console.WriteLine($"Enter the discount, %");
//var discount = new Homework().readDoubleFromConsole();
//new Homework().Task_2(productName, productPrice, discount);
//new Homework().Task_2(secondProductName, secodProductPrice, discount, secondProductQuantity);
#endregion
#region Task_4
//Console.WriteLine("Enter the quantity of sides:");
//int numberOfSidesParameter = new Homework().readIntFromConsole();
//while (numberOfSidesParameter < 3)
//{
//    Console.WriteLine("The minimum number of sides of a figure is three. Enter correct value:");
//    numberOfSidesParameter = new Homework().readIntFromConsole();
//}
//new Homework().Task_4(numberOfSidesParameter);
#endregion
#region Task_5
//Console.Write("Enter the length of side 1: ");
//double FirstTriangleSide = new Homework().readDoubleFromConsole();
//Console.Write("Enter the length of side 2: ");
//double SecondTriangleSide = new Homework().readDoubleFromConsole();
//Console.Write("Enter the length of side 3: ");
//double ThirdTriangleSide = new Homework().readDoubleFromConsole();
//new Homework().Task_5(FirstTriangleSide, SecondTriangleSide, ThirdTriangleSide);

//Console.Write("Enter the radius of the circle: ");
//double circleRadius = new Homework().readDoubleFromConsole();
//new Homework().Task_5(circleRadius);
#endregion
public class Homework
{
    public double Task_1(double expectedPrice, double expextedDiscount, double expextedQuantity)
    {
        double finalPrice = (expectedPrice * expextedQuantity) - (expectedPrice * expextedQuantity * expextedDiscount / 100);
        return finalPrice;
    }
    public void Task_2(string productName, double unitPrice, double discount, double productQuantity = 1)
    {
        var productPrice = Task_1(unitPrice, discount, productQuantity);
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
    //        productPricesWithoutDiscount[i] = Task_1(productPrices[i], 0, productQuantities[i]);
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
    //    Console.WriteLine($"Total price with discount: {(Math.Round(Task_1(totalPriceWithoutDiscount, priceDiscount, 1), 2))} BYN");
    //    Console.WriteLine("_________");
    //}
    public void Task_3()
    {

    }
    public void Task_4(int quantityOfSides)
    {
        double[] figureSides =  new double[quantityOfSides];
        Console.WriteLine($"Enter {quantityOfSides} sides of the figure:");
        for (int i = 0;i < quantityOfSides;i++)
        {
            figureSides[i] = readDoubleFromConsole();
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
    public void Task_5(double FirstTriangleSide, double SecondTriangleSide, double ThirdTriangleSide)
    {
        double semiperimeter = (FirstTriangleSide + SecondTriangleSide + ThirdTriangleSide) / 2;
        double triangleArea = Math.Sqrt(semiperimeter * (semiperimeter - FirstTriangleSide)
                                                      * (semiperimeter - SecondTriangleSide) 
                                                      * (semiperimeter - ThirdTriangleSide));
        Console.WriteLine($"The area of the triangle with sides {FirstTriangleSide}, {SecondTriangleSide} and {ThirdTriangleSide} is {Math.Round(triangleArea, 2)}");
    }
    public void Task_5(double circleRadius)
    {
        double circleArea = Math.PI * Math.Pow(circleRadius, 2);
        Console.WriteLine($"The area of the circle with the radius {circleRadius} is {Math.Round(circleArea, 2)}");
    }
    public void Task_6()
    {
        Console.WriteLine(@"
Наследование: разные поколения техники: Iphone 4 => 14, часть фунций предыдущих поколений сохраняется,часть изменяется или появляются новые;
Инкапсуляция: принимая таблетки с обезболивающим действием человеку неизвестен механизм их действия на клеточном уровне;
Полиморфизм: линзы могут использоваться для фокусировки света при коррекции зрения или для создания лазеров;
Абстракция: выбирая блюдо в ресторане мы можем посмотреть на его состав (иногда калораж или БЖУ), но мы не будем смотреть 
(преимущественно) на количество витаминов, микроэлементов и клетчатки.");
    }
    public double readDoubleFromConsole()
    {
        string enteredValue = Console.ReadLine();
        enteredValue = enteredValue.Replace(',','.');
        double value;
        bool check = true;
        while (check != double.TryParse(enteredValue, out value))
            Console.WriteLine("Wrong value. Try again");
        return value;
    }
    public int readIntFromConsole()
    {
        int value;
        bool check = true;
        while (check != (int.TryParse(Console.ReadLine(), out value)))
            Console.WriteLine("Wrong value. Try again");
        return value;
    }
}