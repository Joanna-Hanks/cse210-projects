using System;


public class PromptGenerator
{
    public List<string> _prompt = new List<string>();
    public PromptGenerator()
    {
        _prompt.Add("Who was the most interesting person I interacted with today?");
        _prompt.Add("What was the best part of my day?");
        _prompt.Add("How did I see the hand of the Lord in my life today?");
        _prompt.Add("What was the strongest emotion I felt today?");
        _prompt.Add("If I had one thing I could do over today, what would it be?");
        _prompt.Add("What would make today great?");
        _prompt.Add("What is one thing I am grateful for today?");
        _prompt.Add("What is a small, 15-minute action I can take toward a larger goal?");
        _prompt.Add("How can I show kindness to myself today?");
        _prompt.Add("What is currently draining my energy?");
    }

    public string GetPrompt()
    {
        int randomNumber = Random.Shared.Next(0, 10);

        return _prompt[randomNumber];
    }
}