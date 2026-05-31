using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        string answer = "";

        scripture.Display();
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");

        answer = Console.ReadLine();

        while (answer != "quit")
        {
            Console.Clear();

            scripture.HideWords();
            scripture.Display();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");

            answer = Console.ReadLine();            

            if (scripture.AreAllWordsHidden() == true)
            {
                break;
            }
        }
    
    }
}