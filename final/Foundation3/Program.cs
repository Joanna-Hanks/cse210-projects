using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Rexburg", "Idaho", "USA");
        Address address2 = new Address("123 Peekaboo St", "Bald Head Island", "North Carolina", "USA");
        Address address3 = new Address("523 Westminister Ave", "Toronto", "Ontario", "Canada");

        Lecture lecture = new Lecture("How Cats Make People Happier", "Why do people seem much happier when they own a cat? Come to this lecture to find out!", "6/31/1832", "12:00 AM", address1, "Crazy Cat Lady", 100);
        Reception reception = new Reception("Luke and Misty's Wedding Reception", "Free food, free entertainment, free drinks, come join!", "4/31/1950", "5:00 AM", address2, "othercrazycatlady@kitties.arehappy");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Pool Party", "Come cool off at the pool party!", "12/25/1832", "8:00 AM", address3, "Thunderstorms with excessive lightning targeting people in pools");
    
        lecture.GetStandardDetails();
        lecture.GetFullDetails();
        lecture.GetShortDescription();

        Console.WriteLine();
        reception.GetStandardDetails();
        reception.GetFullDetails();
        reception.GetShortDescription();

        Console.WriteLine();
        outdoorGathering.GetStandardDetails();
        outdoorGathering.GetFullDetails();
        outdoorGathering.GetShortDescription();

    }
}