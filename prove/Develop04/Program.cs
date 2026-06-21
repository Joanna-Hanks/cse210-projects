using System;

class Program
{
    static void Main(string[] args)
    {
        string answer = "";

        while (answer != "4")
        {
            Console.Clear();

            Console.WriteLine("Menu Options");
            Console.WriteLine("    1. Start breathing activity");
            Console.WriteLine("    2. Start reflection activity");
            Console.WriteLine("    3. Start listing activity");
            Console.WriteLine("    4. Quit");

            Console.Write("Select a choice from the menu: ");
            answer = Console.ReadLine();

            Activity activity = null;

            if (answer == "1")
            {
                activity = new BreathingActivity();
            }
            else if (answer == "2")
            {
                activity = new ReflectionActivity();
            }
            else if (answer == "3")
            {
                activity = new ListingActivity();
            }
            else if (answer == "4")
            {
                break;
            }

            if (activity != null)
            {
                Console.Clear();
                activity.StartActivity();
                activity.RunActivity();
                activity.EndActivity();

            }
        }
    }
}