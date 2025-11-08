using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Welcome to the Mindfulness program!");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("\nEnter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
                {
                case "1":
                    new Breathing().Run();
                    break;
                case "2":
                    new Reflection().Run();
                    break;
                case "3":
                    new Listing().Run();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Thread.Sleep(1500);
                    break;
            }
        }
    }
}
