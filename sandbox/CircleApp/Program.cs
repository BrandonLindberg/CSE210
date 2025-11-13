
class Program
{
    static void Main()
    {
        Circle circle1 = new Circle();

        // circle1._radius = 10;
        circle1.SetRadius(10);

        Console.WriteLine(circle1.GetCircleArea());

        Circle circle2 = new Circle(100);

        Console.WriteLine(circle2.GetCircleArea());
        Console.WriteLine(circle2.GetCircumference());

        List<Circle> circles = new List<Circle>();
        circles.Add(circle1);
        circles.Add(circle2);

        foreach (Circle c in circles)
        {
            Console.WriteLine(c.GetCircleArea());
        }
    }
}