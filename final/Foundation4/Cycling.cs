
public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, string activityName, double minutes, double speed) : base(date, activityName, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * GetMinutes()) / 60;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }

}