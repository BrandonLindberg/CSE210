public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string goalType, string name, string description, int points) : base(goalType, name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (_isComplete == false)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string CheckStatus()
    {
        if (_isComplete == false)
        {
            return "[X]";
        }
        else
        {
            return "[ ]";
        }
    }

    public override string GetGoalString()
    {
        return $"Simple - {base.GetGoalString()} - {_isComplete}";
    }
}