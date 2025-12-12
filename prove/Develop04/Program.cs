using System;

class Program
{
    static void Main(string[] args)
    {
        Menu _menu = new Menu();

        int _userSelection;
        bool _done = false;

        do
        {
            _userSelection = _menu.ProcessMenu();

            switch (_userSelection)
            {
                case 1:
                    new Breathing().RunActivity();
                    break;

                case 2:
                    new Reflection().RunActivity();
                    break;

                case 3:
                    new Listing().RunActivity();
                    break;

                case 4:
                    _done = true;
                    break;
            }

        } while (_done == false);
    }
}