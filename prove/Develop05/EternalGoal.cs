public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        UpdateStreak();
        return _points;
    }

    public override string GetStatus()
    {
        return "[ ] {_name} (Streak: {_streak})";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal | {_name} | {_description} | {_points}";
    }
}