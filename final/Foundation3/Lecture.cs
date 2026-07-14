public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override void GetFullDetails()
    {
        Console.WriteLine("Type of event: Lecture");
        base.GetFullDetails();
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Room Capacity: {_capacity}");
    }
    public override void GetShortDescription()
    {
        Console.WriteLine("Type of event: Lecture");
        base.GetShortDescription();
    }
}