
class Circle
{
    private double _radius;

    public Circle()
    {
        _radius = 0.0;
    }
    
    public Circle(double radius)
    {
        SetRadius(radius);
    }

    public void SetRadius(double radius)
    {
        if (radius <= 0)
        {
            Console.WriteLine("Radius must be positive number greater than 0");
            _radius = 0;
        }
        else
        {
            _radius = radius;
        }
    }

    public double GetCircleArea()
    {
        return 3.1415 * _radius * _radius;
    }
}