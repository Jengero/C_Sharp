using CSharpOOP2;

Laptop Asus = new();                    
Asus.Manufacturer = "Asus";
Asus.ScreenDiagonal = 16.0;
Asus.IsGraphicsCardDiscrete = true;
Asus.ProcessorGeneration = 9;

Laptop Lenovo = new()
{
    Manufacturer = "Lenovo",
    ScreenDiagonal = 15.6,
    IsGraphicsCardDiscrete = true,
    ProcessorGeneration = 7
};

Laptop HewlettPackard = new("HP", 17.1, false, 5); 

Asus.ChangeScreenDiagonal();
//Asus.PrintGraphicsCard(); Error Line. Private method can be used only within their own class. 
Asus.PrintProcessorGeneration();

Laptop Acer = new() { Manufacturer = "Acer", IsGraphicsCardDiscrete = true, ProcessorGeneration = 7 };
Acer.ChangeScreenDiagonal(); // The default value of any double variable is 0. From the beginning of the method 0 is displayed in the console.

Laptop MicroStarInternational = new() { Manufacturer = "MSI", ScreenDiagonal = 17.3, IsGraphicsCardDiscrete = true };  // Default value of ProcessorGeneration = 3
Console.WriteLine($"Laptop {MicroStarInternational.Manufacturer} with {MicroStarInternational.ScreenDiagonal}\" " +
    $"screen and processor Intel {MicroStarInternational.ProcessorGeneration}th generation ");