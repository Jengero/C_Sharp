
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

new Homework().Task_2_1();
//new Homework().Task_2_2();
//new Homework().Task_2_3();
//new Homework().Task_2_4();
//new Homework().Task_2_5();
//new Homework().Task_2_6();
//new Homework().Task_2_7();
//new Homework().Task_2_8();
//new Homework().Task_2_9();

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
        Console.WriteLine("");
        var Age = Console.ReadLine();


    }

    public void Task_2_2()
    {


    }
    public void Task_2_3()
    {


    }
    public void Task_2_4()
    {


    }
    public void Task_2_5()
    {


    }
    public void Task_2_6()
    {


    }
    public void Task_2_7()
    {


    }
    public void Task_2_8()
    {


    }
    public void Task_2_9()
    {


    }

}
