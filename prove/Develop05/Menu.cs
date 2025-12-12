class Menu
{
    public string[] _menuStrings = {
        "Menu Options:",
        "1. Create Goal",
        "2. List Goals",
        "3. Save Goals",
        "4. Load Goals",
        "5. Record Event",
        "6. Quit"
    };

    public int DisplayMenu()
    {
        int _input = 0;
        
        do
        {
            foreach (string menuItem in _menuStrings)
            {
                Console.WriteLine(menuItem);
            }
            _input = int.Parse(Console.ReadLine());
        }while (_input < 1 || _input > 5);
        return _input;
    }
}