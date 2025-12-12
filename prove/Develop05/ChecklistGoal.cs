public class ChecklistGoal : Goal
{
    private int _targetNum;
    private int _currentNum;
    private int _bonus;

    public ChecklistGoal(string goalType, string name, string description, int points, int targetNum, int bonus) : base(goalType, name, description, points)
    {
        _currentNum = 0;
        _targetNum = targetNum;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (_currentNum < _targetNum)
        {
            _currentNum++;

            if (_currentNum == _targetNum)
            {
                return _points + _bonus;
            }
            return _points;
        }
        return 0;
    }

    public override bool IsComplete()
    {
        return _currentNum >= _targetNum;
    }

    public override string CheckStatus()
    {
        return $"[{_currentNum}/{_targetNum}]";
    }

    public override string GetGoalString()
    {
        return $"Checklist - {base.GetGoalString()} - {_currentNum}/{_targetNum}|{_bonus}";
    }
}