class HeartRateCalculator : HealthCalculator
{
    public HeartRateCalculator() : base ("Heart Rate Zones", "Calculates your target heart rate zones")
    {}

    public override CalculationResult Calculate(Profile currentProfile)
    {
        int _maxHeartRate = 220 - currentProfile.GetAge();

        int _low = (int)(_maxHeartRate * 0.5);
        int _high = (int)(_maxHeartRate * 0.85);

        return new CalculationResult("Target Heart Rate", $"{_low} - {_high} bpm");
    }
}