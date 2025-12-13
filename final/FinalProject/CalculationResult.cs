class CalculationResult
{
    private string _label;
    private string _value;

    public CalculationResult(string label, string value)
    {
        _label = label;
        _value = value;
    }

    public string GetValue()
    {
        return _value;
    }

    public void DisplayResult()
    {
        Console.WriteLine($"{_label}: {_value}");
    }
}