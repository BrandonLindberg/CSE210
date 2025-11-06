using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randomNum = randomGenerator.Next(1, 101);

        int numGuess = 0;

        Console.WriteLine($"Guess the magic number.");

        while (numGuess != randomNum)
        {
            Console.Write("What is your guess: ");
            numGuess = int.Parse(Console.ReadLine());

            if (numGuess < randomNum)
            {
                Console.WriteLine("Higher");
            }
            else if(numGuess > randomNum)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Congratulations! You have guess the number");
            }
        }
    }
}