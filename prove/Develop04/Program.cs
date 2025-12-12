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
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    _done = true;
                    break;
            }

        } while (_done == false);
    }
}