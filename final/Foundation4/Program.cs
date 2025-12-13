using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>()
        {
            new Running("03 Nov 2022", 30, 3.0), 
            new Cycling("03 Nov 2022", 40, 15), 
            new Swimming("03 Nov 2022", 25, 30)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
