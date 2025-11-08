public class Breathing : Activity
{
    public Breathing()
        : base("Breathing Activity",
               "This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.")
    { }

    public void Run()
    {
        Start();

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in... ");
            ShowCountdown(4);

            Console.Write("\nBreathe out... ");
            ShowCountdown(6);
            Console.WriteLine();
        }

        Finish();
    }
}
