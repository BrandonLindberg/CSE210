abstract class HealthCalculator
{
    protected string _name;
    protected string _description;

    public HealthCalculator(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public abstract CalculationResult Calculate(Profile userProfile);
}