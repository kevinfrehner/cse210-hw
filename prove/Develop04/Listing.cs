using System;
using System.Collections.Generic;

public class Listing : Activity
{
    private string[] listingPrompts = new string[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private Random rand = new Random();

    public Listing()
        : base("Listing Activity",
               "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    { }

    public void Run()
    {
        Start(); 

        string prompt = listingPrompts[rand.Next(listingPrompts.Length)];
        Console.WriteLine($"\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");
        ShowCountdown(5); 

        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(Duration); 

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            responses.Add(response);
        }

        Console.WriteLine($"\nYou listed {responses.Count} items!\n");

        Finish(); 
    }
}
