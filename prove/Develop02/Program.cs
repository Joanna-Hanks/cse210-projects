using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int number = 0;


        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string answer = Console.ReadLine();
            number = int.Parse(answer);

            if (number == 1)
            {
                journal.AddEntry();
            }
            else if (number == 2)
            {
                journal.DisplayEntries();
            }
            else if (number == 3)
            {
                journal.LoadJournal();
            }
            else if (number == 4)
            {
                journal.SaveJournal();
            }
        } while (number != 5);
    }
}