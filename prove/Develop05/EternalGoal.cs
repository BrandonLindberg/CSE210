public class EternalGoal : Goal
{
    public EternalGoal(string goalType, string name, string description, int points) : base(goalType, name, description, points)
    {}

    public override int RecordEvent()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string CheckStatus()
    {
        return "[∞]";
    }

    public override string GetGoalString()
    {
        return $"Eternal - {base.GetGoalString()}";
    }
}