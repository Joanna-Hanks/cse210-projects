using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squared = SquareNumber(userNumber);
        int birthYear;
        PromptUserBirthYear(out birthYear);
        DisplayResult(userName, squared, birthYear);

    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());

        return userNumber;
    }
    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int userNumber)
    {
        int squared = userNumber * userNumber;
        return squared;
    }
    static void DisplayResult(string userName, int squared, int birthYear)
    {
        Console.WriteLine($"{userName}, the square of your number is {squared}");
        Console.WriteLine($"{userName}, you will turn {2026-birthYear} this year.");
    }
    
}