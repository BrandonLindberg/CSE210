using System;

class Program
{

    static int AddValues(int n1, int n2, int n3)
    {
        int total = n1 + n2 + n3;
        return total;
    }

    static void Main(string[] args)
    {
        int total = AddValues(10, 3, 56);
        Console.WriteLine(total);
    }
}