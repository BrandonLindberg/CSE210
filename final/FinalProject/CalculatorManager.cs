class CalculatorManager
{
    private List<HealthCalculator> _calculators =
        new List<HealthCalculator>();

    public void AddCalculator(HealthCalculator calculator)
    {
        _calculators.Add(calculator);
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Select a calculator:");
        for (int i = 0; i < _calculators.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_calculators[i].GetName()}");
        }
    }

    public HealthCalculator GetCalculator(int index)
    {
        return _calculators[index];
    }

    public int GetCount()
    {
        return _calculators.Count;
    }
}
