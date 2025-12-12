public class GeneratePrompt
{
    private List<string> _prompts = new List<string>()
    {
        "Prompt 1",
        "Prompt 2",
        "Prompt 3"
    };

    public string GetRandomPrompt()
    {
        Random _random = new Random();
        int _index = _random.Next(_prompts.Count);
        return _prompts[_index];
    }
}