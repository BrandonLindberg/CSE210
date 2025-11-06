using System;

class Program
{
    static void Main(string[] args)
    {
        Menu journalMenu = new Menu();

        int userSelection;

        bool done = false;

        do
        {
            userSelection = journalMenu.ProcessMenu();

            switch (userSelection)
            {
                case 1:
                //create new entry object
                //call create on object
                //add entry to journal
                    break;
                case 2:
                //call journal.Display
                    break;
                case 3:
                //save to file
                    break;
                case 4:
                //read from file
                    break;
                case 5:
                    done = true;
                    break;
            }

        } while (!done);
    }
}