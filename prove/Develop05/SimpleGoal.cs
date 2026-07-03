
public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (_isComplete)
        {
            return 0;
        }
        else
        {
            _isComplete = true;
            return GetPoints();
        }
    }
    public override string GetDisplay()
    {
        string checkBox = _isComplete ? "[X]" : "[ ]";
        return $"{checkBox} {GetName()} ({GetDescription()})";
    }
    public override string GetSaveString()
    {
        return $"SimpleGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
    }

}