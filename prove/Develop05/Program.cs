using System;

class Program
{
    static void Main(string[] args)
    {
        Menu _menu = new Menu();
        GoalHandler _goalHandle = new GoalHandler();
        
        string[] _goalMenu = {
            "1. Simple Goal",
            "2. Eternal Goal",
            "3. Checklist Goal"  
        };

        int _userSelection;
        bool _done = false;

        do
        {
            _userSelection = _menu.DisplayMenu();

            switch (_userSelection)
            {
                case 1:
                    Console.Clear();

                    Console.WriteLine("Available goal types:");
                    
                    foreach (string goalItem in _goalMenu)
                        {
                            Console.WriteLine(goalItem);
                        }

                    Console.Write("Goal type to create: ");
                    int _goalSelection = int.Parse(Console.ReadLine());

                    switch (_goalSelection)
                        {
                            case 1:
                                Console.Write("Name of goal: ");
                                string _name = Console.ReadLine();
                                Console.Write("Description of goal: ");
                                string _description = Console.ReadLine();
                                Console.Write("Amount of points goal is worth: ");
                                int _points = int.Parse(Console.ReadLine());
                                SimpleGoal _simpleGoal = new SimpleGoal("Simple Goal: ", _name, _description, _points);
                                _goalHandle.AddGoal(_simpleGoal);
                                break;
                            
                            case 2:
                                Console.Write("Name of goal: ");
                                _name = Console.ReadLine();
                                Console.Write("Description of goal: ");
                                _description = Console.ReadLine();
                                Console.Write("Points goal is worth: ");
                                _points = int.Parse(Console.ReadLine());
                                EternalGoal _eternalGoal = new EternalGoal("Eternal Goal: ", _name, _description, _points);
                                _goalHandle.AddGoal(_eternalGoal);
                                break;

                            case 3:
                                Console.Write("Name of goal: ");
                                _name = Console.ReadLine();
                                Console.Write("Description of goal: ");
                                _description = Console.ReadLine();
                                Console.Write("Points goal is worth: ");
                                _points = int.Parse(Console.ReadLine());
                                Console.Write("Amount of times done for completion: ");
                                int _numNeeded = int.Parse(Console.ReadLine());
                                Console.Write("Bonus points for completing goal: ");
                                int _bonusPoints = int.Parse(Console.ReadLine());
                                ChecklistGoal _checklistGoal = new ChecklistGoal("Eternal Goal: ", _name, _description, _points, _numNeeded, _bonusPoints);
                                _goalHandle.AddGoal(_checklistGoal);
                                break;
                        }
                    break;

                case 2:
                    Console.Clear();
                    _goalHandle.ListGoals();
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;

                case 6:
                _done = true;
                    break;
            }

        } while (_done == false);
    }
}