#region Divide arrays
//int[] arrayToSplit = new int[] { 55, 87, 70, 45, 8, 12, 66, 82, 25, 88, 39, 40, 54, 5, 65, 33, 6, 20, 4, 24 };
//Homework.splitEvenAndOddValues(arrayToSplit);
#endregion
#region Subtract the minimum value from the maximum array value
//int[] arrayToSubtract = new int[] { 84, 83, 75, 94, 61, 92, 29, 43, 55, 59 };
//Homework.GetArraySubtraction(arrayToSubtract);
#endregion
#region Sort array by surnames
using CSharpCollections1;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Net;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

//List<string> surnames = new() { "Robinson", "Williams", "Cook", "Garcia", "Henderson", "Boone", "Garza", "Cox", "McGuire", "Morgan" };
//surnames.Sort();
//foreach (string name in surnames) { Console.WriteLine(name); }
#endregion
#region Sort the list of voters
List<Citizen> citizens = new()
{
    new Citizen() { Name = "Patric Mo", Address = "Tully Street 4252", DateOfBirth = new(1982, 5, 9) },
    new Citizen() { Name = "Sophos Igor", Address = "Ridenour Street 4496", DateOfBirth = new(1987, 2, 10) },
    new Citizen() { Name = "Finnr Lex", Address = "Buffalo Creek Road 3387", DateOfBirth = new(1993, 5, 21) },
    new Citizen() { Name = "Marita Felix", Address = "Ridenour Street 4496", DateOfBirth = new(1980, 8, 5) },
    new Citizen() { Name = "Emerson Aton", Address = "Ridenour Street 4496", DateOfBirth = new(2007, 6, 22) }
};

Console.WriteLine("The list of citizens:");

foreach (var citizen in citizens)
{
    Console.WriteLine("Name: " + citizen.Name + "; Address: " + citizen.Address + "; Date of birth: " + citizen.DateOfBirth.ToShortDateString());
}

Console.WriteLine(String.Empty);
Console.WriteLine("The list of voters, sorted by addresses and names:");

var sortedCitizens = citizens.OrderBy(order => order.Address).ThenBy(order => order.Name);

foreach (var order in sortedCitizens)
{
    if (order.DateOfBirth < DateTime.Now.AddYears(-18))
    { Console.WriteLine("Name: " + order.Name + "; Address: " + order.Address + "; Date of birth: " + order.DateOfBirth.ToShortDateString()); }
    else { Console.WriteLine($"{order.Name} is under 18 years old"); }
}
#endregion
#region Swap key and value in dictionary
//Console.WriteLine("Enter five pairs of words with the type \"Name of the country : Capital\"");
//string[] EnteredValues = new string[5];
//char divider = ':';
//var countries = new Dictionary<string, string>();
//for (int i = 0; i < EnteredValues.Length; i++) 
//{
//    EnteredValues[i] = Console.ReadLine();
//    string[] keyValuePair = (EnteredValues[i].Split(divider));
//    foreach (string word in keyValuePair) { word.Trim(); }
//    countries.Add(keyValuePair[0], keyValuePair[1]);
//}

//foreach (var country in countries)
//{
//    Console.WriteLine($"key: {country.Key}  value: {country.Value}");
//}

//var reverseCountries = new Dictionary<string, string>();

//foreach (var country in countries)
//{
//    //reverseCountries = countries.ToDictionary(country => country.Value, country => country.Key);
//    reverseCountries.Add(country.Value, country.Key);
//}

//Console.WriteLine("Swap result:");

//foreach (var country in reverseCountries)
//{
//    Console.WriteLine($"key: {country.Key}  value: {country.Value}");
//}
#endregion

class Homework 
{
    public static void splitEvenAndOddValues(int[] array) 
    {
        Array.Sort(array);
        int evenNumberCuantity = 0;
        int oddNumberCuantity = 0;

        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                evenNumberCuantity++;
            }
            else
            {
                oddNumberCuantity++;
            }
        }
        int[] evenRandomNumbers = new int[evenNumberCuantity];
        int[] oddRandomNumbers = new int[oddNumberCuantity];
        int j = 0;
        int t = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                evenRandomNumbers[j] = array[i];
                j++;
            }
            else
            {
                oddRandomNumbers[t] = array[i];
                t++;
            }
        }

        Console.WriteLine("Even numbers array:");
        foreach (int number in evenRandomNumbers)
        {
            Console.WriteLine($"{number}");
        }

        Console.WriteLine("Odd numbers array:");


        foreach (int number in oddRandomNumbers)
        {
            Console.WriteLine($"{number}");
        }
    }

    public static void GetArraySubtraction(int[] array)
    {
        Array.Sort(array);
        int result = array[array.Length - 1] - array[0];
        Console.WriteLine(result);
    }

    
}