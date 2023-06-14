
using System.Diagnostics.CodeAnalysis;
using static System.Runtime.InteropServices.JavaScript.JSType;

//new Homework_3().Task_1();
//new Homework_3().Task_2();
new Homework_3().Task_3();
class Homework_3
{
    public void Task_1()
    {
        Console.WriteLine("Enter the number:");
        int num = int.Parse(Console.ReadLine());
        if (num % 2 == 0 && num % 5 != 0)
        {
            Console.WriteLine("Tutti");
        }
        else if (num % 5 == 0 && num % 2 != 0)
        {
            Console.WriteLine("Frutti");
        }
        else if (num % 5 == 0 && num % 2 == 0)
        {
            Console.WriteLine("Tutti-frutti");
        }
        else
        {
            Console.WriteLine($"Number {num} can’t be divided on 2 or 5");
        }
    }
    public void Task_2()
    {
        Console.WriteLine("Enter two numbers. The first one should be less than the second.");
        var enteredNum1 = Console.ReadLine();
        var enteredNum2 = Console.ReadLine();
        bool res1 = int.TryParse(enteredNum1, out int min);
        bool res2 = int.TryParse(enteredNum2, out int max);
        if (min < max)
        {
            CheckDivision(min, max);
        }
        else
        {
            Console.WriteLine("Numbers are incorrect!");
        }
    }
    public void Task_3()
    {
        Console.WriteLine("Enter two numbers:");
        bool res1 = int.TryParse(Console.ReadLine(), out int num1);
        bool res2 = int.TryParse(Console.ReadLine(), out int num2);
        int min = Math.Min(num1, num2);
        int max = Math.Max(num1, num2);

        if (res1 && res2)
        {
            CheckDivision(min, max);
        }
        else
        {
            Console.WriteLine("Numbers are incorrect!");
        }

        //switch (res1 && res2)
        //{
        //    case true:
        //        if (num1 < num2)
        //        {
        //            for (int i = num1; i <= num2; i++)
        //            {
        //                if (i % 2 == 0 && i % 5 != 0)
        //                {
        //                    Console.WriteLine("Tutti");
        //                }
        //                else if (i % 5 == 0 && i % 2 != 0)
        //                {
        //                    Console.WriteLine("Frutti");
        //                }
        //                else if (i % 5 == 0 && i % 2 == 0)
        //                {
        //                    Console.WriteLine("Tutti-frutti");
        //                }
        //                else
        //                {
        //                    Console.WriteLine($"Number {i} can’t be divided on 2 or 5");
        //                }
        //            }
        //        }
        //        else if (num1 > num2)
        //        {
        //            for (int i = num1; i >= num2; i--)
        //            {
        //                if (i % 2 == 0 && i % 5 != 0)
        //                {
        //                    Console.WriteLine("Tutti");
        //                }
        //                else if (i % 5 == 0 && i % 2 != 0)
        //                {
        //                    Console.WriteLine("Frutti");
        //                }
        //                else if (i % 5 == 0 && i % 2 == 0)
        //                {
        //                    Console.WriteLine("Tutti-frutti");
        //                }
        //                else
        //                {
        //                    Console.WriteLine($"Number {i} can’t be divided on 2 or 5");
        //                }
        //            }
        //        }
        //        break;
        //    case false:
        //        Console.WriteLine("Numbers are incorrect!");
        //        break;
        //}
    }
    private void CheckDivision(int min, int max)
    {
        for (int i = min; i <= max; i++)
        {
            if (i % 2 == 0 && i % 5 != 0)
            {
                Console.WriteLine("Tutti");
            }
            else if (i % 5 == 0 && i % 2 != 0)
            {
                Console.WriteLine("Frutti");
            }
            else if (i % 5 == 0 && i % 2 == 0)
            {
                Console.WriteLine("Tutti-frutti");
            }
            else
            {
                Console.WriteLine($"Number {i} can’t be divided on 2 or 5");
            }
        }
    }
}
