public class Journal
{
    public List<JournalEntry> _entries = new List<JournalEntry>();

    public void AddEntry(JournalEntry entry)
    {
        _entries.Add(entry);
    }

    public void SaveEntry(string fileName)
    {
        using (StreamWriter _fileWriter = new StreamWriter(fileName))
        {
            foreach (var _entry in _entries)
            {
                _fileWriter.WriteLine($"{_entry._date},{_entry._prompt},{_entry._response}");
            }
        }
    }

    public void LoadEntry(string fileName)
    {
        foreach (var _line in File.ReadAllLines(fileName))
        {
            _entries.Clear();

            string[] _entryData = _line.Split(",");
            JournalEntry _newEntry = new JournalEntry();

            _newEntry._date = _entryData[0];
            _newEntry._prompt = _entryData[1];
            _newEntry._response = _entryData[2];
            _entries.Add(_newEntry);
        }
    }

    public void DisplayEntries()
    {
        foreach (var _entry in _entries)
        {
            _entry.Display();
        }
    }
}