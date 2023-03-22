using System;
using Develop05.Classes;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Command> commands = new Dictionary<string, Command>();
        Repository repo = new Repository();
        commands["1"] = new CreateSimpleGoalCommand(repo);
        // commands["2"] = new CreateEternalGoalCommand(repo);
        // commands["3"] = new CreateChecklistGoalCommand(repo);

        string choice = "";
        while (choice != "quit")
        {
            Console.Clear();
            Console.Write(
                "Welcome to the menu.\n1. Create Simple Goal\n2. Create Eternal Goal\n3. Create Checklist Goal\nquit. Quit\n> "
            );
            choice = Console.ReadLine();
            if (choice != "quit")
            {
                Command command = commands[choice];
                command.Execute();
            }
        }

        Goal simpleGoal = new SimpleGoal("Exercise", "I want to exercise once, tomorrow.", 1000);
        Console.WriteLine(simpleGoal.ToString());
        repo.Add(simpleGoal);
        int numberOfGoals = repo.GetAll().Count;
        Console.WriteLine($"There are {numberOfGoals} goals in the system.");

        simpleGoal.MarkComplete();
        Console.WriteLine(simpleGoal.ToString());
    }
}
