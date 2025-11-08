using System;

public class Reflection : Activity
{

    public Reflection()
        : base("Reflection Activity",
               "This activity will help you reflect on times in your life when you have shown strength and resilience. " +
               "This will help you recognize the power you have and how you can use it in other aspects of your life.")
    { }

    private string[] reflectionPrompts = new string[]
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] reflectionQuestions = new string[]
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private Random rand = new Random();

    public string GetRandomPrompt()
    {
        int index = rand.Next(reflectionPrompts.Length);
        return reflectionPrompts[index];
    }

    public void Run()
    {
        Start(); 

        string prompt = GetRandomPrompt();
        Console.WriteLine($"\n{prompt}\n");
        Console.WriteLine("Consider this prompt carefully...");
        ShowSpinner(5); 

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            string question = reflectionQuestions[rand.Next(reflectionQuestions.Length)];
            Console.Write($"\n> {question} ");
            ShowSpinner(6);
        }

        Finish(); 
    }
}
