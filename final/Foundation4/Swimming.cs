
public class Swimming : Activity
{
    private double _laps;

    public Swimming(string date, string activityName, double minutes, double laps) : base(date, activityName, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}