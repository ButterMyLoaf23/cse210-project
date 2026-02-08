public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected int _streak;
    protected DateTime _lastCompleted;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _name;
    }

    protected void UpdateStreak()
    {
        if (_lastCompleted == DateTime.MinValue)
        {
            _streak = 1;
        }
        else
        {
            if (_lastCompleted.Date == DateTime.Today.AddDays(-1))
            {
                _streak++;
            }
            else if (_lastCompleted.Date != DateTime.Today)
            {
                _streak = 1;
            }
        }

        _lastCompleted = DateTime.Today;
    }

    public abstract int RecordEvent();
    public abstract string GetStatus();
    public abstract string GetStringRepresentation();

}