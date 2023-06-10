
using System.Diagnostics.CodeAnalysis;
using static System.Runtime.InteropServices.JavaScript.JSType;

new Homework_3().Task_1();
new Homework_3().Task_2();
new Homework_3().Task_3();


//Console.WriteLine("First number");
//double first = double.Parse(Console.ReadLine());
//Console.WriteLine("Second number");
//double second = double.Parse(Console.ReadLine());
//Console.WriteLine("Third number");
//double third = double.Parse(Console.ReadLine());
//double res = new Homework_3().sum(first, second);

//double res1 = new Homework_3().sum(first, second, third);

//Console.WriteLine($"Result is {res}");
//Console.WriteLine($"Result is {res1}");

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

        bool res1 = int.TryParse(enteredNum1, out int num1);
        bool res2 = int.TryParse(enteredNum2, out int num2);

        if (num1 < num2)
        {
            for (int i = num1; i < num2; i++)
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
        else
        {
            Console.WriteLine("Numbers are incorrect!");
        }
    }
    public void Task_3()
    {
        Console.WriteLine("Enter two numbers.");
        bool res1 = int.TryParse(Console.ReadLine(), out int num1);
        bool res2 = int.TryParse(Console.ReadLine(), out int num2);
        switch (res1 && res2 == true)
        {
            case true:
                if (num1 < num2)
                {
                    for (int i = num1; i <= num2; i++)
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
                else if (num1 > num2)
                {
                    for (int i = num1; i >= num2; i--)
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
                break;
            case false:
                Console.WriteLine("Numbers are incorrect!");
                break;

        }

    }
    public void Task_4()
    {
        Console.WriteLine("Enter the number:");
        var b = Console.ReadLine();
        int a = 0;
        int c = 0;
        int n = 1;
        for (int i = 0; i < b.Length; i++)
        {
            char ex = b[n];
            a = Convert.ToInt32(ex);
            n++;
            a += c;
        }
        Console.WriteLine($"Result is: {a}");
    }
}
