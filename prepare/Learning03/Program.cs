using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction myFraction = new Fraction(1,10);

        Console.WriteLine(myFraction.GetFractionString());
        Console.WriteLine(myFraction.GetFractionDecimal());
    }
}