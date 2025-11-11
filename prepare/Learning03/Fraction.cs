using System.Globalization;

class Fraction
{
    private double _numerator = 0.0;
    private double _denomenator = 0.0;

    public Fraction()
    {
        _numerator = 1;
        _denomenator = 1;
    }

    public Fraction(double top)
    {
        SetTop(top);
        _denomenator = 1;
    }

    public Fraction(double top, double bottom)
    {
        SetTop(top);
        SetBottom(bottom);
    }

    public void SetTop(double top)
    {
        _numerator = top;
    }

    public void SetBottom(double bottom)
    {
        _denomenator = bottom;
    }

    public string GetFractionString()
    {
        string numString = _numerator.ToString();
        string denomString = _denomenator.ToString();
        return $"{numString}/{denomString}";
    }

    public double GetFractionDecimal()
    {
        return _numerator / _denomenator;
    }
}