using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nGamification Program");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Quit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(manager);
                    break;

                case "2":
                    manager.ShowGoals();
                    break;

                case "3":
                    manager.ShowGoals();
                    manager.RecordEvent();
                    break;

                case "4":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("\nWhat kind of goal do you want to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choose: ");
        string type = Console.ReadLine();

        Console.Write("Goal title: ");
        string title = Console.ReadLine();

        Console.Write("Short description: ");
        string description = Console.ReadLine();

        Console.Write("Points for completing: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            manager.AddGoal(new SimpleGoal(title, description, points));
            Console.WriteLine("Simple Goal created!");
        }
        else if (type == "2")
        {
            manager.AddGoal(new EternalGoal(title, description, points));
            Console.WriteLine("Eternal Goal created!");
        }
        else if (type == "3")
        {
            Console.Write("How many times does this need to be completed? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus points for finishing the checklist: ");
            int bonus = int.Parse(Console.ReadLine());

            manager.AddGoal(new ChecklistGoal(title, description, points, target, bonus));
            Console.WriteLine("Checklist Goal created!");
        }
        else
        {
            Console.WriteLine("Invalid type.");
        }
    }
}
