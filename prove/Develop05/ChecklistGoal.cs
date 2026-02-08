public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus) : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _currentCount = 0;
    }

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus, int currentCount) : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _currentCount = currentCount;
    }

    public override int RecordEvent()
    {
        UpdateStreak();
        _currentCount++;

        if (_currentCount == _targetCount)
        {
            return _points + _bonus;
        }   

        return _points;
    }

    public override string GetStatus()
    {
        string box = _currentCount >= _targetCount ? "X" : " ";
        return $"[{box}] {_name} (completed {_currentCount}/{_targetCount}) (Streak: {_streak})";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal | {_name} | {_description} | {_points} | {_bonus} | {_targetCount} | {_currentCount}";
    }
}