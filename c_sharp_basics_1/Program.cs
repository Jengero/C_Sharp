

using System;
using System.Security.Cryptography;

using System.Text;
using static System.Net.WebRequestMethods;

Console.WriteLine("Hello, Work!");

//new Homework().Task_1();
//new Homework().Task_2();
//new Homework().Task_3();
//new Homework().Task_4();
//new Homework().Task_5();
//new Homework().Task_6();
//new Homework().Extra_1();


//new Homework_2().Task_2_1();
//new Homework_2().Task_2_2();
//new Homework_2().Task_2_3();
//new Homework_2().Task_2_4();
//new Homework_2().Task_2_5();
//new Homework_2().Task_2_6();
//new Homework_2().Task_2_7();
//new Homework_2().Task_2_8();
//new Homework_2().Task_2_9();


class Homework
{
    public void Task_1()
    {
        string name = "Egor";
        int age = 25;
        double CorrectAnswers = 82.5;
        char grade = 'B';
        bool ispasssed = true;
        Console.WriteLine($"Applicant's information:\n Name: {name};\n Age {age};\n Percentage of correct answers {CorrectAnswers};\n Final grade: {grade};\n Admission to the next training block: {ispasssed}");
    }
    public void Task_2()
    {
        Console.WriteLine("Enter the person's age");
        var Age = Console.ReadLine();
        Console.WriteLine("Enter a person's first name");
        var FirstName = Console.ReadLine();
        Console.WriteLine("Enter a person's last name");
        var LastName = Console.ReadLine();
        Console.WriteLine($@"Example:- Are you on the guest list?
        - Yes, my name is {FirstName} {LastName}.
        - And did you know that the event is only for people over 21?  
        - I am {Age}.");

        //Console.WriteLine($"Example:\n \"- Are you on the guest list?\n - Yes, my name is {FirstName} {LastName}.\n - And did you know that the event is only for people over 21? \n - I am {Age}.\"");
    }
    public void Task_3()
    {
        Console.WriteLine("Enter four words:");
        var word1 = Console.ReadLine();
        var word2 = Console.ReadLine();
        var word3 = Console.ReadLine();
        var word4 = Console.ReadLine();

        //string[] joining = new string[] { word1, word2, word3, word4 };
        //var result1 = String.Join( ' ', joining);

        //var result1 = String.Join(' ', word1, word2, word3, word4);
        //Console.WriteLine(result1);

        Console.WriteLine(String.Join(' ', word1, word2, word3, word4));
        var s = ' ';

        //var result2 = String.Concat(word1, s, word2, s, word3, s, word4);
        //Console.WriteLine(result2);

        Console.WriteLine(String.Concat(word1, s, word2, s, word3, s, word4));
    }
public void Task_4()
    {
        //Example: 'I wish it need not have happened in my time,' said Frodo.

        Console.WriteLine("Enter example sentence:");
        var sent = Console.ReadLine();
        var cut_sent1 = sent.Substring(2);
        Console.WriteLine(sent.Substring(2));
        var cut_sent2 = sent.Substring(0, 2);
        Console.WriteLine(cut_sent2);
        var stitch = string.Join('\0', cut_sent2, cut_sent1);
        Console.WriteLine(stitch);
    }
    public void Task_5()
    {
        //Example:
        //        Invictus 
        //By William Ernest Henley

        //   Out of the night that covers me,
        //   Black as the pit from pole to pole,
        //   I thank whatever gods may be
        //   For my unconquerable soul.

        // Black as the pit from pole to pole,
        // Black - White

        Console.WriteLine("Enter example poem:");
        var poem = Console.ReadLine();
        Console.WriteLine("Enter adjective antonym:");
        var ant = Console.ReadLine();
        Console.WriteLine(poem.Replace("Black", ant));
    }
    public void Task_6()
    {
        Console.WriteLine("Enter example letter:");
        var let = Console.ReadLine();
        var up = let.ToUpper();
        Console.WriteLine(up);
    }
    public void Extra_1()
    {
        var s = " ";
        Console.WriteLine("Enter the first sentence:");
        //var str = new StringBuilder(Console.ReadLine());
        StringBuilder str = new (Console.ReadLine());
        Console.WriteLine("Enter the second sentence:");
        str.Append((s) + (Console.ReadLine()));
        Console.WriteLine("Enter the third sentence:");
        str.Append((s) + (Console.ReadLine()));
        Console.WriteLine(str);



    }

}

class Homework_2
{
    public void Task_2_1()
    {
        Console.WriteLine("Enter four tipes of data:");
        Console.WriteLine("int tipe:");
        int int_ex = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("double tipe:");
        double double_ex = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("float tipe:");
        float float_ex = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("boolean tipe:");
        bool bool_ex = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine($"Entered values: { int_ex}; {double_ex}; {float_ex}; {bool_ex}.");
    }
    public void Task_2_2()
    {
        Console.WriteLine("Enter two tipes of data to convert:");
        Console.WriteLine("Enter numeric type:");
        var DoubleEx = Console.ReadLine();
        Console.WriteLine("Enter boolean type:");
        var BoolEx = Console.ReadLine();
        Console.WriteLine("Result of the convertation:");

        bool result1 = double.TryParse(DoubleEx, out double parsedDouble);
        if (result1 == true) { Console.WriteLine(parsedDouble); }
        else Console.WriteLine("First value has wrong data tipe!");

        bool result2 = Boolean.TryParse(BoolEx, out bool parsedBool);
        if (result2 == true) { Console.WriteLine(parsedBool); }
        else Console.WriteLine("Second value has wrong data tipe!");
    }
    public void Task_2_3()
    {
        Console.WriteLine("Enter numeric type of data:");
        var Number = Console.ReadLine();
        bool result = double.TryParse(Number, out double parsedNumber);
        Console.WriteLine($"The conversion result - {result}");
        Console.WriteLine(parsedNumber);
    }
    public void Task_2_4()
    {
        Console.WriteLine(@"Initial value is 35. The second value is greater than the first by 3. 
The third value is the result of summarise the first and the second.");
        int a = 20;
        int b = a + 3;
        int c = a + b;
        Console.WriteLine($"Result is {c}");
    }
    public void Task_2_5()
    {
        // cheese, milk, beef, eggs, mushrooms
        var product1 = "Cheese";
        var product2 = "Milk";
        var product3 = "Beef";
        var product4 = "Eggs";
        var product5 = "Mushrooms";

        var mass1 = 0.25;
        var mass2 = 1;
        var mass3 = 0.965;
        var mass4 = 1;
        var mass5 = 0.800;

        var cost1 = 22.20;
        var cost2 = 2.80;
        var cost3 = 29.99;
        var cost4 = 3.64;
        var cost5 = 8.90;

        var TotalSum = (Math.Round((cost1 * mass1) + (cost2 * mass2) + (cost3 * mass3) + (cost4 * mass4) + (cost5 * mass5), 2));
        var Sale = 0.15;
        var SumOfSale = (Math.Round(TotalSum * Sale, 2));
        var SumAfterSale = (Math.Round(TotalSum - Sale, 2));
        
        Console.WriteLine(@$"                  Payment check
{product1}...{mass1} kg.......................{(Math.Round(cost1 * mass1, 2))} BYN
{product2}...{mass2} l.......................{(Math.Round(cost2 * mass2, 2))} BYN
{product3}...{mass3} kg.......................{(Math.Round(cost3 * mass3, 2))} BYN
{product4}...{mass4} dozen.......................{(Math.Round(cost4 * mass4, 2))} BYN
{product5}...{mass5} kg.......................{(Math.Round(cost5 * mass5, 2))} BYN


Total cost.......................{TotalSum} BYN
Sale.......................{SumOfSale} BYN

Final cost.......................{SumAfterSale} BYN

Thanks for your purchase!");
    }
    public void Task_2_6()
    {
        double a = 11;
        double b = 7;
        double result1 = (a - b) * b / a + b;
        // 1) a-b = 11 - 7 = 4 
        // 2) 4 * b = 4 * 7 = 28
        // 3) 28 / a = 28 / 11 ≈ 2.55
        // 4) 2.55 + b = 2.55 + 7 ≈ 9.55
        Console.WriteLine(Math.Round(result1, 2));

        double result2 = ++result1 / (b+3);
        Console.WriteLine(Math.Round(result2, 2));
        // 1) ++result1 = 9.55 + 1 = 10.55
        // 2) b+3 = 10
        // 3) 10.55 / 10 ≈ 1.05
        double result3 = result1-- * (b / 2) ;
        double result4 = result1-- * (b / 2) ;
        Console.WriteLine(Math.Round(result3, 2)); //???
        Console.WriteLine(Math.Round(result4, 2)); 
        // 1) b / 2 = 3.5
        // 2) 9.55 * 3.5 ≈ 33.41
        // 3) 9.55-- = 8.55
    }
    public void Task_2_7()
    {
        int a1 = 5;
        int b1 = 5;

        double a2 = 6;
        double b2 = 6;
        var c2 = 6;

        int a3 = 41;
        int b3 = 31;
        int c3 = 42;

        int a4 = 324;
        int b4 = 323;

        int a5 = 65;
        int b5 = 66;

        int a1_1 = 6;
        int b1_1 = 5;

        double a2_1 = 7;
        double b2_1 = 6;
        var c2_1 = 6;

        int a3_1 = 42;
        int b3_1 = 42;
        int c3_1 = 42;

        int a4_1 = 323;
        int b4_1 = 323;

        int a5_1 = 67;
        int b5_1 = 66;

        // True sequence
        bool r1 = a1 == b1;
        Console.WriteLine(r1);

        bool r2 = (a2 == c2) && (b2 == c2);
        Console.WriteLine(r2);

        bool r3 = (a3 != c3) || (b3 != c3);
        Console.WriteLine(r3);

        bool r4 = a4 != b4;
        Console.WriteLine(r4);

        bool r5 = a5 <= b5;
        Console.WriteLine(r5);

        // False sequence
        bool res1 = a1_1 == b1_1;
        Console.WriteLine(res1);

        bool res2 = (a2_1 == c2_1) && (b2_1 == c2_1);
        Console.WriteLine(res2);

        bool res3 = (a3_1 != c3_1) || (b3_1 != c3_1);
        Console.WriteLine(res3);

        bool res4 = a4_1 != b4_1;
        Console.WriteLine(res4);

        bool res5 = a5_1 <= b5_1;
        Console.WriteLine(res5);
    }
    public void Task_2_8()
    {
        int ans = 42;
        object temp = ans;
        int wer = (int)ans;
    }
    public void Task_2_9()
    {
        int a = 15;
        //  неявное  преобразование
        double b = a;
    
        Char c = '2';
        // явное преобразование
        int d = (int)c;
    }

}

}

