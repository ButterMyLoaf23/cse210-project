using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = squareNumber(userNumber);
        int birthyear;
        PromptUserBirthYear(out birthyear);

        DisplayResult(userName, squaredNumber, birthyear);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to this program!");
    }

    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static void PromptUserBirthYear(out int birthyear)
    {
        Console.Write($"Enter the year you were born: ");
        birthyear = int.Parse(Console.ReadLine());
    }

    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int squareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
        Console.WriteLine($"{name}, you will turn {2026 - birthYear} years old this year.");
    }
}