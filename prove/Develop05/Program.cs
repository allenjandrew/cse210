using System;
using Develop05.Classes;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Command> commands = new Dictionary<string, Command>();
        Repository repo = new FileRepository();
        commands["1"] = new CreateGoalCommand(repo);

        string choice = "";
        while (choice != "quit")
        {
            Console.WriteLine("enter your choice: ");
            choice = Console.ReadLine();
            Command command = commands[choice];
            command.Execute();
        }

        Goal simpleGoal = new SimpleGoal("Exercise.", "I want to exercise once, tomorrow.", 1000);
        Console.WriteLine(simpleGoal.ToString());
        repo.Add(simpleGoal);
        int numberOfGoals = repo.GetAll().Count;
        Console.WriteLine($"There are {numberOfGoals} goals in the system.");

        simpleGoal.MarkComplete();
        Console.WriteLine(simpleGoal.ToString());
    }
}
