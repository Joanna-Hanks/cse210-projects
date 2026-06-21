using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartActivity()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like your session to last? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void EndActivity()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        Console.WriteLine($"You completed another {_duration} seconds of the {_name}");

        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        string[] spinner = { ".", "..", "...", "" };

        for (int i = 0; i < seconds; i++)
        {
            foreach (string s in spinner)
            {
                Console.Write($"\r{s}");
                Thread.Sleep(300);
            }
        }

        Console.WriteLine();
    }

    public virtual void RunActivity()
    {
    }
}