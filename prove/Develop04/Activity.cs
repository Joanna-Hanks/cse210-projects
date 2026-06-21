using System;

public class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    public void StartActivity()
    {
        Console.WriteLine($"Welcome to the {name}");
        Console.WriteLine();
        Console.WriteLine(description);
        Console.WriteLine();

        Console.WriteLine("How long, in seconds, would you like your session to last?");
        duration = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void EndActivity()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed the {name} for {duration} seconds");

        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        string[] spinner = { ".", "..", "...", "" };

        for (int i = 0; i < seconds; i++)
        {
            foreach (string s in spinner)
            {
                Console.Write($"\r{s}   ");
                Thread.Sleep(300);
            }
        }

        Console.WriteLine();
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }

    public virtual void RunActivity()
    {
        
    }

}
