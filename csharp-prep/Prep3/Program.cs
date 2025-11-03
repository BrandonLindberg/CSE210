using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 10;
        int y = x++;
        Console.WriteLine($"x = {x}, y = {y}");
    }
}