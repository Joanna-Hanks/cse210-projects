using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running("03 Nov 2022", "Running", 30, 3);
        Swimming swimming = new Swimming("10 Nov 1520", "Swimming", 30, 10);
        Cycling cycling = new Cycling("17 Nov 1922", "Cycling", 60, 70);

        running.GetSummary();
        swimming.GetSummary();
        cycling.GetSummary();
    }
}