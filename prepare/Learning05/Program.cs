using System;

class Program
{
    using System;

class Program
{
    static void Main(string[] args)
    {
        ShowGreeting();

        string user = GetUserName();
        int favoriteNum = GetUserFavoriteNumber();

        int squaredValue = CalculateSquare(favoriteNum);

        int yearOfBirth;
        GetBirthYear(out yearOfBirth);

        PresentResults(user, squaredValue, yearOfBirth);
    }

    static void ShowGreeting()
    {
        Console.WriteLine("Hello! Thanks for running this program.");
    }

    static string GetUserName()
    {
        Console.Write("What is your name? ");
        return Console.ReadLine();
    }

    static int GetUserFavoriteNumber()
    {
        Console.Write("Enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static void GetBirthYear(out int birthYear)
    {
        Console.Write("What year were you born? ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int CalculateSquare(int num)
    {
        return num * num;
    }

    static void PresentResults(string userName, int squaredNum, int birthYear)
    {
        Console.WriteLine($"{userName}, your number squared is {squaredNum}.");
        Console.WriteLine($"{userName}, you will be {2025 - birthYear} years old this year.");
    }
}
