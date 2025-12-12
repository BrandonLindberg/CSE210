class Scripture
{
    private ScriptureReference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(ScriptureReference reference, string text)
    {
        _reference = reference;

        string[] _splitWords = text.Split(" ");

        for (int i = 0; i < _splitWords.Length; i++)
        {
            Word _newWord = new Word(_splitWords[i]);
            _words.Add(_newWord);
        }
    }

    public void HideWord(int count)
    {
        Random _random = new Random();

        List<Word> _visibleWords = new List<Word>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (_words[i].IsHidden() == false)
            {
                _visibleWords.Add(_words[i]);
            }
        }

        if (_visibleWords.Count == 0)
        {
            return;
        }

        for (int i = 0; i < count; i++)
        {
            if (_visibleWords.Count == 0)
            {
                break;
            }

            int _index = _random.Next(_visibleWords.Count);
            Word _wordToHide = _visibleWords[_index];

            _wordToHide.HideWord();
        }
    }

    public string GetDisplayText()
    {
        string _fullText = "";

        for (int i = 0; i < _words.Count; i++)
        {
            _fullText += _words[i].DisplayWord();
            _fullText += " ";
        }

        return _reference.TextToDisplay() + " - " + _fullText;
    }

    public bool AllHidden()
    {
        for (int i = 0; i < _words.Count; i++)
        {
            if (_words[i].IsHidden() == false)
            {
                return false;
            }
        }

        return true;
    }
}