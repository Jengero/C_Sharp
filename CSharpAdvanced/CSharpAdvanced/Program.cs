#region Task1. Creation of generic method
using CSharpAdvanced;
using System.Diagnostics;
using System.Linq;
List<int> intExample = new() { 1, 23, 45 };
GetFirstValue(intExample);

List<string> stringExample = new() { "Tom", "Bob", "Kate", "Tim", "Mike", "Sam" };
GetFirstValue(stringExample);

static void GetFirstValue<T>(List<T> collection) 
{
    var firstValue = collection.FirstOrDefault();
    Console.WriteLine(firstValue);
}
#endregion
#region Task2. Generic methods - flowers
Rose rose = new("Short stem rose", "Red", 1);

Violet violet = new("Violet", "Blue", 1);

var roseQuantity = GetFlowerQuantity(rose);
var violetQuantity = GetFlowerQuantity(violet);

GetReceipt(rose, roseQuantity, rose, rose);
GetReceipt(violet, violetQuantity, violet, violet);

int GetFlowerQuantity<T> (T flower) where T : Flower 
{
    Console.WriteLine($"Enter the quantity of {flower.Name}. If you order 50 or more flowers, you will get 10% sale!");
    int quantity = int.Parse(Console.ReadLine());
    if (quantity >= 50) 
    {
        FlowerHelper.CalculateBulkDiscount(flower);
    }
        return quantity;
}

double GetBouquetPrice<T>(T price, int quantity) where T : Flower
{
    double bunchPrice = price.Price * quantity;
    return Math.Round(bunchPrice, 2);
}

void GetReceipt<T>(T price, int quantity, T name, T color) where T : Flower 
{
    Console.WriteLine("-------");
    Console.WriteLine($"The bouquet of {quantity} {color.Color} {name.Name} --- {GetBouquetPrice(price, quantity)} BYN");
    Console.WriteLine("-------");
}
#endregion
#region Task3. Generic class - colors upgrade
RepaintedFlower<Flower>.RepaintBouquet(rose, RepaintedFlower<Flower>.GetColorForRepainting(rose));
RepaintedFlower<Flower>.RepaintBouquet(violet, RepaintedFlower<Flower>.GetColorForRepainting(violet));


Console.WriteLine(String.Empty);
Console.WriteLine("Price after repainting:");
Console.WriteLine(String.Empty);

GetReceipt(rose, roseQuantity, rose, rose);
GetReceipt(violet, violetQuantity, violet, violet);
#endregion
#region Task4. Creating extension class
// CalculateBulkDiscount and CalculateRepaintedPrice methods are used from FlowerHelper extension class.
#endregion