using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbersList = new List<int>();

        int Number = -1;
        while (Number != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished. ");
            string response = Console.ReadLine();
            Number = int.Parse(response);
            if (Number != 0)
            {
                numbersList.Add(Number);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
         {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

      
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

       
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}
    
