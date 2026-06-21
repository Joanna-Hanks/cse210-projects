using System;

public class BreathingActivity : Activity
{
    public override void RunActivity()
    {
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.WriteLine("Breathe in...");

            for (int i = 4; i >= 1; i--)
            {
                Console.WriteLine($"Breathe in... {i}");
                Thread.Sleep(1000);
            }

            Console.WriteLine();
            Console.WriteLine("Breathe out...");

            for (int i = 4; i >= 1; i--)
            {
                Console.WriteLine($"Breathe out... {i}");
                Thread.Sleep(1000);
            }
        }
    }
}