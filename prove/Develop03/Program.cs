using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureReference _reference = new ScriptureReference("Genesis", 1, 1, 2);
        Scripture _scripture = new Scripture(_reference, "In the beginning God created the heavens and the earth");

        while (_scripture.AllHidden() == false)
        {
            Console.Clear();
            Console.WriteLine(_scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to hide words or type 0 to exit");

            string _input = Console.ReadLine();
            if (_input == "0")
            {
                break;
            }

            _scripture.HideWord(1);
        }
    }
}