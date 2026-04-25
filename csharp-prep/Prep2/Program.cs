using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int number = int.Parse(answer);

        Console.WriteLine("");

        string grade = "";
        string pass = "";

        if (number >= 90)
        {
            grade = "A";
        }
        else if (number >= 80)
        {
            grade = "B";
        }
        else if (number >= 70)
        {
            grade = "C";
        }
        else if (number >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        if (grade == "A" || grade == "B" || grade == "C")
        {
            pass = ("Congragulations! You have passed this course!");
        }
        else
        {
            pass = ("You did not pass this course :O");
        }


        Console.WriteLine($"You got a {grade}!");
        Console.WriteLine($"{pass}");
        Console.WriteLine("");
    }
}