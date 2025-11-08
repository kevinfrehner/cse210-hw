public class Activity
{

    public string Name { get; }
    public string Description { get; }
    public int Duration { get; private set; }

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public virtual void Start()
    {
        Console.Clear();
        Console.WriteLine($"--- {Name} ---\n");
        Console.WriteLine(Description);
        Console.Write("\nEnter duration (in seconds): ");
        Duration = ReadIntFromUser();

        Console.WriteLine("\nGet ready...");
        ShowSpinner(3);
    }

    public virtual void Finish()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(2);
        Console.WriteLine($"\nYou have completed the {Name} for {Duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
    }

    protected void ShowSpinner(int seconds)
    {
        char[] spinnerChars = { '|', '/', '-', '\\' };
        DateTime end = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < end)
        {
            Console.Write($"\r{spinnerChars[i++ % spinnerChars.Length]}");
            Thread.Sleep(200);
        }
        Console.Write("\r ");
        Console.Write("\r");
    }

    private int ReadIntFromUser()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int value) && value > 0)
                return value;
            Console.Write("Please enter a positive number: ");
        }
    }


}
