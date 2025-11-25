class Program
{
    static void PassReferenceType(int [] data)
    {
        data[3] = 12345;
    }
    static void PassByOut(out int a)
    {
        a = 17;
        Console.WriteLine($"In the pass by reference, x is {a}");
    }
    static void PassByReference(ref int x)
    {
        x = 9999;
        Console.WriteLine($"In the pass by reference, x is {x}");
    }
    static void PassByValue(int x)
    {
        x = 1001;
        Console.WriteLine($"Here, x is {x}");
    }
    public static void Main(string[] args)
    {
        int x = 10;
        int y = x;
        y++;
        Console.WriteLine($"{x}, {y}");

        int [] a = {1, 2, 3, 4, 5, 6};
        int [] b = a;

        Console.WriteLine($"{a[1]}, {a[0]}");

        PassByValue(x);
        Console.WriteLine($"x is {x}");

        PassByReference(ref x);
        Console.WriteLine($"In main, x is: {x}");

        int z;
        PassByOut(out z);


        PassReferenceType(a);
        foreach (int i in a)
        {
            Console.WriteLine($"i is {i}");
        }
    }
}