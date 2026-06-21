using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear you mind and focus on your breathing."
        )
    {
    }

    public override void RunActivity()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            for (int i = 4; i >= 1; i--)
            {
                Console.Write($"\rBreathe in... {i}");
                Thread.Sleep(1000);
            }

            Console.WriteLine();

            for (int i = 4; i >= 1; i--)
            {
                Console.Write($"\rNow breathe out... {i}");
                Thread.Sleep(1000);
            }

            Console.WriteLine();
        }
    }
}