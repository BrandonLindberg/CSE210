class Menu()
{
    public string[] _menuStrings = {
        "Welcome to the Journal",
        "Select an option:",
        "1 - Create Journal Entry",
        "2 - Display Journal",
        "3 - Save Journal to file",
        "4 - Load Journal from file",
        "5 - Quit\n"
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
        } while (_userSelection < 1 || _userSelection > 5);
        return _userSelection;
    }
}