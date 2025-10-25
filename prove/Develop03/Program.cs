using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        scripture.DisplayScripture();

        
        while (true)
        {
            Console.WriteLine("Please press 'enter' to continue the program, or, type 'quit' to exit the program");
            string userInput = Console.ReadLine();

            if (userInput == "")
            {
                scripture.PopFunction();
                Console.Clear();
                scripture.DisplayScripture();
            }
            else if (userInput.ToLower() == "quit")
            {
                Console.WriteLine("Quitting Program.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
