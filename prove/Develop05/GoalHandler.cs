class GoalHandler
{
    private List<Goal> _goals = new List<Goal>();
    private int _pointTotal = 0;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public int GetTotalPoints()
    {
        return _pointTotal;
    }

    public void ListGoals()
    {
        Console.WriteLine("Current goals:");
        if (_goals.Count() > 0)
        {
            foreach (Goal goal in _goals)
            {
                goal.DisplayGoal();
            }
        }
    }
}