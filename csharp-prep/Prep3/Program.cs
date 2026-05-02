using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int answer = randomGenerator.Next(1, 101);
        

        int attempt;


        do
        {
            Console.Write("What is your guess? ");
            string number = Console.ReadLine();
            attempt = int.Parse(number);

            if (attempt < answer)
            {
                Console.WriteLine("Higher");
            }
            else if (attempt > answer)
            {
                Console.WriteLine("Lower");
            }
        } while (attempt != answer);

        Console.WriteLine("You guessed it!");
    }


}