public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void DisplayScore()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You don't have any goals recorded yet.");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDisplay()}");
        }
    }
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public int RecordEvent(int index)
    {
        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("Invalid goal selection");
            return 0;
        }

        Goal goal = _goals[index];
        int earned = goal.RecordEvent();
        _score += earned;
        Console.WriteLine($"Congratulations! You have earned {earned} points!");
    
        return earned;
    }
    public void SaveGoals(string filename, int score)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetSaveString());
            }
        }
    }
    public int LoadGoals(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        _goals = new List<Goal>();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split("|");
            string type = parts[0];

            if (type == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                _goals.Add(goal);
            }
            else if (type == "EternalGoal")
            {
                EternalGoal goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                _goals.Add(goal);
            }
            else if (type == "ChecklistGoal")
            {
                ChecklistGoal goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6]));
                _goals.Add(goal);
            }
        }
        return _score;
    }
}