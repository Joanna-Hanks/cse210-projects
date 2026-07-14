
public class OutdoorGathering : Event
{
    public string _weather;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public override void GetFullDetails()
    {
        Console.WriteLine("Type of event: Outdoor Gathering");
        base.GetFullDetails();
        Console.WriteLine($"Weather: {_weather}");
    }
    public override void GetShortDescription()
    {
        Console.WriteLine("Type of event: Outdoor Gathering");
        base.GetShortDescription();
    }
}