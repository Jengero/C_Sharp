// See https://aka.ms/new-console-template for more information
 void Test1()
{
    // Дана коллекция имен ниже. Используя 3 любых метода LINQ, примените их к коллекции ниже и выведите итоговую коллекцию.

    var names = new List<string> { "Mike", "Selena", "Andy" };

    var namesWithFirstS = names.Where(x => x.StartsWith("S")).ToList();
    foreach (var name in namesWithFirstS) { Console.WriteLine(name); }

}
