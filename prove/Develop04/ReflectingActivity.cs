using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you helped someone.",
        "Think of a time you overcame a challenge.",
        "Think of a time you showed patience.",
        "Think of a time you did something hard."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this meaningful?",
        "What did you learn?",
        "How did you feel?",
        "What strength did you show?",
        "How can you use this in the future?"
    };

    public ReflectionActivity()
        : base(
            "Reflection Activity",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of you life."
        )
    {
    }

    public override void RunActivity()
    {
        Random random = new Random();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($" -- {prompt} --");
        Console.WriteLine();

        Console.WriteLine("When you have somethin in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        for (int i = 5; i >= 1; i--)
        {
            Console.Write($"\rYou may begin in: {i}");
            Thread.Sleep(1000);
        }

        Console.Clear();

        while (DateTime.Now < endTime)
        {
            string question = _questions[random.Next(_questions.Count)];

            Console.WriteLine();
            Console.WriteLine(question);
            ShowSpinner(5);
        }
    }
}