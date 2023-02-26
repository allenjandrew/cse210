using System;
using Learning04.Classes;

class Program
{
    static void Main(string[] args)
    {
        Assignment easyDub = new Assignment("Alex Perazzo", "Planet Building 101");
        Console.WriteLine(easyDub.GetSummary());
        MathAssignment secondDub = new MathAssignment(
            "Danny Checketts",
            "Christmas",
            "3.55",
            "1-14"
        );
        Console.WriteLine(secondDub.GetSummary());
        Console.WriteLine(secondDub.GetHomeworkList());
        WritingAssignment thirdDub = new WritingAssignment(
            "Charlie Cash Money Thompson",
            "Rohld Dahl Fan Club",
            "The Importance of the BFG in Modern-Day American Politics"
        );
        Console.WriteLine(thirdDub.GetSummary());
        Console.WriteLine(thirdDub.GetWritingInfo());
    }
}
