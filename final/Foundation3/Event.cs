
using System.Net.Sockets;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void GetStandardDetails()
    {
        Console.WriteLine($"{_title}\n{_description}\nDate: {_date}\n Address: {_address}");
    }
    public virtual void GetFullDetails()
    {
        Console.WriteLine($"{_title}\n{_description}\nDate: {_date}\n Address: {_address}");        
    }
    public virtual void GetShortDescription()
    {
        Console.WriteLine($"{_title}\n{_date}");
    }
    public Address GetFullAddress()
    {
        return _address;
    }

}