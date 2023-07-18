using CSharpBasicsTest;
#region Task6
//Phone IPhone = new(6.5, "IPhone 12");
//Phone Samsung = new("Samsung S22");

//IPhone.PrintInformation();

//IPhone._diagonal = 6.2;

//IPhone.PrintInformation();
#endregion
#region Task7
//List<string> Cities = new List<string> { "Prague", "Odessa", "Frankfurt", "Damascus" };
//Console.WriteLine("Enter a char to select:");

//string letter = Console.ReadLine();

//var sortedCities = from c in Cities
//                   where c.Contains(letter)
//                   select c;

//foreach (var c in sortedCities) { Console.WriteLine(c); }
#endregion
#region Task8
//Console.WriteLine("Enter a string containing only letters and spaces");
//string example = Console.ReadLine();
//example.Trim();

//List<string> words = example.Split(new char[] { ' ' }).ToList();

//var sortedWords = from w in words
//                  where w.Length > 3
//                  select w;

//foreach (var w in sortedWords) { Console.WriteLine(w); }
#endregion
#region Task9

#endregion
#region Task10
int a = 5;
int result = IntegerHelper.GetSquareInt(a);
Console.WriteLine(result);
#endregion