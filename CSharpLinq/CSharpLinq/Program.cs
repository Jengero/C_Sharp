using CSharpOOP2;
using System.Diagnostics;
#region Task_1. List of numbers divisible by three
//List<int> numbersToDivide = new() { 32, 50, 40, 77, 36, 93, 57, 4, 37, 7 };

//var numbersDivisibleByThree = from r in numbersToDivide
//                              where r % 3 == 0
//                              select r;

//Console.WriteLine($"The list of numbers divisible by 3:");

//foreach (var number in numbersDivisibleByThree) { Console.WriteLine(number); }
#endregion
#region Task_2. List of positive numbers less than 10 and negative numbers

//List<int> randomNumbers = new() { -7, 7, 14, -11, 8, 11, -14, 10, -12, -8 };

//var SelectedNumbers = randomNumbers.Where(p => p < 10).Select(r => r).ToList();

//Console.WriteLine($"List of positive numbers, that are less than 10 and negative numbers:");

//foreach (var r in SelectedNumbers) { Console.WriteLine(r); }
#endregion
#region Task_3. Sorted list of names with an even number of characters
//List<string> randomNames = new() {"Malika", "Enya", "Cruz", "Iona", "Brendon" };

//var sortedNames = from name in randomNames
//                  where name.Length % 2 == 0
//                  orderby name
//                  select name;

//Console.WriteLine($"List of names, that are less than zero and less than 10:");

//foreach (var name in sortedNames) { Console.WriteLine(name); }
#endregion
#region Task_4. List of cities starting with 'C' and ending with 'a'
//List<string> randomCities = new() { "Sapporo", "Lima", "Almaty", "Jakarta", "Casablanca", "Chengdu" };

//var cities = randomCities.Where(r => r.StartsWith("C") && r.EndsWith("a")).Select(r => r).ToList();

//cities.ForEach(Console.WriteLine);
#endregion
#region Task_5 List of capitalized words from a sentence entered from the console
//Console.WriteLine("Enter the example sentence:");
//string exampleToList = Console.ReadLine();
//exampleToList.Trim();

//List<string> words = exampleToList.Split(new char[] { ' ' }).ToList();

//var sortedWords = from word in words
//                  where char.IsUpper(word, 0)
//                  select word;

//foreach (var word in sortedWords) { Console.WriteLine(word); }
#endregion
#region Task_6 List of sorted numbers without duplicates
//List<int> numbersWithDuplication = new() { 34, 32, 42, 42, 42, 42, 30, 9, 23, 4 };

//var notRepetitiveNumbers = numbersWithDuplication.Distinct().OrderDescending().ToList();
//notRepetitiveNumbers.ForEach(f => Console.WriteLine(f));
#endregion
#region Task_7 Checking for a match between entered number among the elements of the collection
//List<int> numbersToCompare = new() { 81, 16, 42, 58, 72, 99, 3, 84, 75, 21 };

//Console.WriteLine("Enter the example number to compare:");
//int exampleToList = int.Parse(Console.ReadLine());
//var coincidenceCheck = numbersToCompare.Contains(exampleToList);
//if (coincidenceCheck) { Console.WriteLine($"The number {exampleToList} has already added to list."); }
//else Console.WriteLine("The entered value is not in the list.");
#endregion
#region Task_8 The sum of the lengths of the elements of the collection and the value of the first and last element
//List<string> randomCities = new() { "Sapporo", "Lima", "Almaty", "Jakarta", "Casablanca", "Chengdu" };

//int quantityOfSymbols = randomCities.Aggregate(0, (firstCity, nextCity) => firstCity + nextCity.Length);

//if (quantityOfSymbols > 5) { Console.WriteLine(randomCities.First() + ", " + randomCities.Last()); }
#endregion
#region Task_9 3 objects of class "Laptop" with value of field "Manufacturer" from the collection
//List<string> manufacturers = new() { "Asus", "Lenovo", "Apple" };

//var selectedManufacturer = from manufacturer in manufacturers
//                           select new Laptop
//                           {
//                               Manufacturer = manufacturer
//                           };

//foreach (var m in selectedManufacturer) { Console.WriteLine(m.Manufacturer); }
#endregion
#region Task_10 Collection of Manufacturer property values from the Laptop class
//List<Laptop> LaptopExamples = new() 
//{
//    new Laptop ("Asus", 15.5, true, 8, true, 1250),
//    new Laptop ("Lenovo", 17, true, 9, true, 1560),
//    new Laptop ("Apple", 13, false, 8, false, 2500)
//};

//var selectedManufacturers = LaptopExamples.Select(m => m.Manufacturer).ToList();
//selectedManufacturers.ForEach(Console.WriteLine);
#endregion