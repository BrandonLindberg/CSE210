public abstract class Goal
{
    protected string _type;
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string goalType, string name, string description, int points)
    {
        _type = goalType;
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string CheckStatus();

    public virtual string GetGoalString()
    {
        return $"{_name}: {_description} - {_points}";
    }

    public virtual void DisplayGoal()
    {
        Console.WriteLine($"{_type}: {_name} - {_description} - {_points}");
    }
}