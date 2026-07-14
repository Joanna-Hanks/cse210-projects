
public abstract class Activity
{
    private string _date;
    private string _activityName;
    private double _minutes;

    public Activity(string date, string activityName, double minutes)
    {
        _date = date;
        _minutes = minutes;
        _activityName = activityName;
    }

    public double GetMinutes()
    {
        return _minutes;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public void GetSummary()
    {
        Console.WriteLine($"{_date} {_activityName} ({_minutes} min)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile");
    }
}