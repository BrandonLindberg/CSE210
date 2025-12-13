using System;

class Program
{
    static void Main(string[] args)
    {
        Profile _userProfile = CreateUserProfile();

        CalculatorManager _manager = new CalculatorManager();
        _manager.AddCalculator(new BmiCalculator());
        _manager.AddCalculator(new CalorieCalculator());
        _manager.AddCalculator(new HeartRateCalculator());

        bool _quit = false;

        while (_quit == false)
        {
            Console.Clear();
            _manager.DisplayMenu();

            string input = Console.ReadLine();

            if (input == "0")
            {
                _quit = true;
                continue;
            }

            int choice = int.Parse(input) - 1;

            if (choice >= 0 && choice < _manager.GetCount())
            {
                HealthCalculator _calculator = _manager.GetCalculator(choice);

                Console.Clear();
                Console.WriteLine(_calculator.GetName());
                Console.WriteLine($"\n{_calculator.GetDescription()}");

                CalculationResult _result = _calculator.Calculate(_userProfile);
                _result.DisplayResult();

                Console.WriteLine("\n*Press Enter to continue*");
                Console.ReadLine();
            }

            Console.WriteLine("0. Quit");
            Console.Write("Choose an option: ");
        }

        static Profile CreateUserProfile()
        {
            Console.Clear();
            Console.WriteLine("------ Health Calculator ------");
            Console.WriteLine("Enter your profile information:\n");
            Console.Write("Enter your age: ");
            int _age = int.Parse(Console.ReadLine());
            Console.Write("Enter your height in meters: ");
            double _height = double.Parse(Console.ReadLine());
            Console.Write("Enter your weight in kilograms: ");
            double _weight = double.Parse(Console.ReadLine());
            Console.Write("Enter your gender (M/F): ");
            string _gender = Console.ReadLine();
            Console.Write("Enter your activity level (low/medium/high): ");
            string _activity = Console.ReadLine();

            return new Profile(_age, _height, _weight, _gender, _activity);
        }
    }
}