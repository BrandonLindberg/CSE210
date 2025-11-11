
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
    }
}