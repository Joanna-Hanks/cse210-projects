public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _targetAmount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetAmount, int bonusPoints) : base(name, description, points)
    {
        _amountCompleted = 0;
        _targetAmount = targetAmount;
        _bonusPoints = bonusPoints;
    }
    public override int RecordEvent()
    {
        _amountCompleted++;
        int pointsEarned = GetPoints();

        if (_amountCompleted == _targetAmount)
        {
            pointsEarned += _bonusPoints;
        }

        return pointsEarned;
    }
    public override string GetDisplay()
    {
        string check = _amountCompleted >= _targetAmount ? "[X]" : "[ ]";

        return $"{check} {GetName()} ({_amountCompleted}/{_targetAmount})";
    }
    public override string GetSaveString()
    {
    return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_amountCompleted}|{_targetAmount}|{_bonusPoints}";
    }

}