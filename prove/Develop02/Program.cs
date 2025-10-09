using System;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;
class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        string filename = "journal.txt";

        while (true)
        {
            Console.WriteLine("Welcome to the Journal program!");
            Console.WriteLine("1. Write a new journal entry.");
            Console.WriteLine("2. Display previous entries.");
            Console.WriteLine("3. Save the journal to a file.");
            Console.WriteLine("4. Load the journal from a file.");
            Console.WriteLine("5. Exit the journal application.");
            Console.Write("Please select an option 1-5: ");

            string input = Console.ReadLine();
            int option;
            if (!int.TryParse(input, out option))
            {
                Console.WriteLine("Invalid input. Please enter a number 1-5.");
                continue;
            }

            if (option == 1)
            {
                PromptGenerator promptGen = new PromptGenerator();
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine($"\nYour prompt is: {prompt}");
                Console.Write("Write your journal entry: ");
                string text = Console.ReadLine();
                myJournal.AddEntry(text, DateTime.Now, prompt);
                Console.WriteLine("Entry added.");
            }

            else if (option == 2)
            {
                myJournal.DisplayJournal();
            }

            else if (option == 3)
            {
                myJournal.SaveToFile(filename);
            }

            else if (option == 4)
            {
                myJournal.LoadFromFile(filename);
            }

            else
            {
                Console.WriteLine("Program Terminated.");
                break;
            }

        }
    } 
}
