
public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail) : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override void GetFullDetails()
    {
        Console.WriteLine("Type of Event: Reception");
        base.GetFullDetails();
        Console.WriteLine($"This email has RSVP: {_rsvpEmail}\n");
    }
    public override void GetShortDescription()
    {
        Console.WriteLine("Type of Event: Reception");
        base.GetShortDescription();
        Console.WriteLine();
    }
}