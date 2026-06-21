using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "List people you appreciate.",
        "List your strengths.",
        "List things you are grateful for.",
        "List people you have helped recently."
    };

    public ListingActivity()
        : base(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
        )
    {
    }

    public override void RunActivity()
    {
        Random random = new Random();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($" -- {prompt} --");
        for (int i = 5; i >= 1; i--)
        {
            Console.Write($"\rYou may begin in: {i}");
            Thread.Sleep(1000);
        }
        Console.WriteLine();

        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                count++;
            }
        }

        Console.WriteLine($"You listed {count} items!");
    }
}