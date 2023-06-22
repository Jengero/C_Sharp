#region Task_1-2
using CSharpOOP2;
using CSharpOOP3;
using System.Diagnostics;

Laptop lenovo = new("Lenovo", 15.6, true, 7, true, 1800);

lenovo.isExtendedWarranty = false;
//Console.WriteLine($"{lenovo.IsExtendedWarranty}");              Error line
//lenovo.LaptopVat = 0.1;                                         Error line
Console.WriteLine($"Value added tax is {lenovo.LaptopVat}");
#endregion
#region Task_3
Console.WriteLine($"{lenovo.Manufacturer}");
#endregion
#region Task_4
Console.WriteLine($"Current CPU manufacturer is {Laptop.ProcessorManufacturer}");
Laptop.ProcessorManufacturer = "Intel";
Console.WriteLine($"New CPU manufacturer is {Laptop.ProcessorManufacturer}");
#endregion
#region Task_5
Laptop.ChangePaymentMethod();
#endregion
#region Task_6-7
lenovo.PrintScreenDiagonal();
Console.WriteLine("Enter discount, %:");
Laptop.priceDiscount = Laptop.ReadIntFromConsole();
Console.WriteLine($"The price before discount is {lenovo.Price}");
lenovo.CalculatePriceWithDiscount();
Console.WriteLine($"The new price is {lenovo.Price}");
#endregion