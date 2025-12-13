class Profile
{
    private int _age;
    private double _heightM;
    private double _weightKg;
    private string _gender;
    private string _activityLevel;

    public Profile()
    {
        
    }

    public Profile(int age, double height, double weight, string gender, string activityLevel)
    {
        _age = age;
        _heightM = height;
        _weightKg = weight;
        _gender = gender;
        _activityLevel = activityLevel;
    }

    public int GetAge()
    {
        return _age;
    }

    public double GetHeight()
    {
        return _heightM;
    }

    public double GetWeight()
    {
       return _weightKg;
    }

    public string GetGender()
    {
        return _gender;
    }

    public string GetActivityLevel()
    {
        return _activityLevel;
    }
}