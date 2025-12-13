class CalorieCalculator : HealthCalculator
{
    public CalorieCalculator() : base ("Daily Calorie Needs", "Estimates how many calories you need per day.")
    {}

    public override CalculationResult Calculate(Profile currentProfile)
    {
        double _weight = currentProfile.GetWeight();
        double _height = currentProfile.GetHeight();
        int _age = currentProfile.GetAge();

        double _bmr;

        if (currentProfile.GetGender().ToUpper() == "M")
        {
            _bmr = (10 * _weight) + (6.25 * _height) - (5 * _age) + 5;
        }
        else
        {
            _bmr = (10 * _weight) + (6.25 * _height) - (5 * _age) + 161;
        }

        double _multiplier = GetActivityMultiplier(currentProfile.GetActivityLevel());
        double _calories = _bmr * _multiplier;

        return new CalculationResult("Calories Per Day", $"{_calories}");
    }

    private double GetActivityMultiplier(string level)
    {
        if (level == "low")
        {
            return 1.2;
        }
        else if (level == "medium")
        {
            return 1.55;
        }
        else
        {
            return 1.725;
        }
    }
}