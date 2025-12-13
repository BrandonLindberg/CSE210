class BmiCalculator : HealthCalculator
{
    public BmiCalculator() : base ("BMI Calculator", "Calculates your Body Mass Index.")
    {}

    public override CalculationResult Calculate(Profile currenProfile)
    {
        double _height = currenProfile.GetHeight();
        double _weight = currenProfile.GetWeight();

        double _bmi = _weight / (_height * _height);

        string _catagory;

        if (_bmi < 18.5)
        {
            _catagory = "Underweight";
        }
        else if (_bmi < 25)
        {
            _catagory = "Normal weight";
        }
        else if (_bmi < 30)
        {
            _catagory = "Overweight";
        }
        else
        {
            _catagory = "Obese";
        }

        return new CalculationResult("BMI", $"{_bmi} - {_catagory}");
    }
}