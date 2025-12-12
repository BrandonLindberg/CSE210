public class Reflection : Activity
{
    public Reflection() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {}

    private List<string> _prompt = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public void RunActivity()
    {
        StartActivity();
        Random _random = new Random();

        Console.WriteLine($"\n{_prompt[_random.Next(_prompt.Count)]}");
        ShowSpinner(3);

        DateTime _endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < _endTime)
        {
            string _question = _questions[_random.Next(_questions.Count)];
            Console.WriteLine($"\n{_question}");
            ShowSpinner(3);
        }
        EndActivity();
    }
}