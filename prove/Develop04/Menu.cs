class Menu()
{
    public string[] _menuStrings = {
        "Mindfulness Program",
        "Select an option:",
        "1. Breathing Activity",
        "2. Reflection Activity",
        "3. Listing Activity",
        "4. Quit"
    };

    public int ProcessMenu()
    {
        int _userSelection = 0;
        do
        {
            foreach (string menuItem in _menuStrings)
            {
                Console.WriteLine(menuItem);
            }
            _userSelection = int.Parse(Console.ReadLine());
        } while (_userSelection < 1 || _userSelection > 4);
        return _userSelection;
    }
}