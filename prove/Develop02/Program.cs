using System;

class Program
{
    static void Main(string[] args)
    {
        Menu _journalMenu = new Menu();

        Journal _journal = new Journal();
        GeneratePrompt _promptGenerator = new GeneratePrompt();

        int _userSelection;
        bool _done = false;

        do
        {
            _userSelection = _journalMenu.ProcessMenu();

            switch (_userSelection)
            {
                case 1:
                string _prompt = _promptGenerator.GetRandomPrompt();
                Console.WriteLine(_prompt);
                string _response = Console.ReadLine();
                Console.WriteLine();

                JournalEntry _entry = new JournalEntry();
                _entry._date = DateTime.Now.ToShortDateString();
                _entry._prompt = _prompt;
                _entry._response = _response;
                _journal.AddEntry(_entry);
                    break;

                case 2:
                _journal.DisplayEntries();
                    break;

                case 3:
                Console.Write("Filename: ");
                _journal.SaveEntry(Console.ReadLine());
                Console.WriteLine();
                    break;

                case 4:
                Console.WriteLine("Filename: ");
                _journal.LoadEntry(Console.ReadLine());
                Console.WriteLine();
                    break;

                case 5:
                    _done = true;
                    break;
            }

        } while (!_done);
    }
}