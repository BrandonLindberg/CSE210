public class GeneratePrompt
{
    private List<string> _prompts = new List<string>()
    {
        "What made you smile today?",
        "How was your mood today?",
        "What are you looking forward to doing tomorrow?",
        "What is the coolest thing you saw today?",
        "What is something you learned today?"
    };

    public string GetRandomPrompt()
    {
        Random _random = new Random();
        int _index = _random.Next(_prompts.Count);
        return _prompts[_index];
    }
}