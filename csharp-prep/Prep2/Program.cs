using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade (percent)? ");
        string strGrade = Console.ReadLine();
        int intGrade = int.Parse(strGrade);
        string letterGrade;
        bool passed = true;
        string sign = "";

        if (intGrade < 70)
        {
            passed = false;
        }

        if (intGrade % 10 >= 7)
        {
            sign = "+";
        }
        else if (intGrade % 10 < 3)
        {
            sign = "-";
        }
        
        if (intGrade >= 90)
        {
            letterGrade = "A";
            if (sign == "+")
            {
                sign = "";
            }
        }
        else if (intGrade >= 80)
        {
            letterGrade = "B";
        }
        else if (intGrade >= 70)
        {
            letterGrade = "C";
        }
        else if (intGrade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
            sign = "";
        }

        Console.WriteLine($"Your grade: {letterGrade}{sign}");

        if (passed)
        {
            Console.WriteLine("You successfully completed this course.");
        }
        else
        {
            Console.WriteLine("You didn't pass the class. Try taking this course again.");
        }

    }
}