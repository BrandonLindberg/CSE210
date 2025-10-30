using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        string firstName;
        string lastName;

        Console.Write("Please enter your first name: ");
        firstName = Console.ReadLine();

        Console.Write("Pleae enter your last name: ");
        lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {firstName} {lastName}");
    }
}