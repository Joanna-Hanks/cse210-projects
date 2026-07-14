
public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public override void GetFullDetails()
    {
        Console.WriteLine("Type of Event: Outdoor Gathering");
        base.GetFullDetails();
        Console.WriteLine($"Weather Forecast: {_weather}\n");
    }
    public override void GetShortDescription()
    {
        Console.WriteLine("Type of Event: Outdoor Gathering");
        base.GetShortDescription();
        Console.WriteLine();
    }
}