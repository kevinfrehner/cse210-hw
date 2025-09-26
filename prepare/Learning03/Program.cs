using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int answer = -1;

        while (answer != magicNumber)
        {
            Console.Write("What is your guess? ");
            answer = int.Parse(Console.ReadLine());

            if (magicNumber > answer)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < answer)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

    }



}

