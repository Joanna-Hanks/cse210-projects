using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        int _score = 0;

        bool running = true;

        while (running)
        {
            Console.WriteLine($"\nYou have {_score} points.");
            Console.WriteLine("\nMenu Options");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(manager);
                    break;
                
                case "2":
                    manager.DisplayGoals();
                    break;

                case "3":
                    Console.Write("What is the filename for the goal file? ");
                    string saveFile = Console.ReadLine();
                    manager.SaveGoals(saveFile, _score);
                    Console.WriteLine("Goals saved.");
                    break;

                case "4":
                    Console.Write("What is the filename for the goal file? ");
                    string loadFile = Console.ReadLine();
                    _score = manager.LoadGoals(loadFile);
                    Console.WriteLine("Goals loaded.");
                    break;

                case "5":
                    Console.WriteLine("The goals are:");
                    manager.DisplayGoals();

                    Console.Write("Which goal did you accomplish? ");
                    int index = int.Parse(Console.ReadLine()) - 1;

                    int earned = manager.RecordEvent(index);
                    _score += earned;
                    break;
                case "6":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();

        Console.Write("What is the name of you goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            manager.AddGoal(new SimpleGoal(name, description, points));
        }
        else if (type == "2")
        {
            manager.AddGoal(new EternalGoal(name, description, points));
        }
        else if (type == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            manager.AddGoal(new ChecklistGoal(name, description, points, target, bonus));
        }
    }
}