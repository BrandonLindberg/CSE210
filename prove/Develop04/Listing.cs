public class Listing : Activity
{
    public Listing() : base("Listing Activity", "This activity will help you reflect on the good things in your life.")
    {}

    private List<string> _prompt = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public void RunActivity()
    {
        StartActivity();
        Random _random = new Random();

        Console.WriteLine($"\n{_prompt[_random.Next(_prompt.Count)]}");
        Console.WriteLine("List each reponse that you think of:");

        DateTime _endTime = DateTime.Now.AddSeconds(_duration);
        int _count = 0;

        while (DateTime.Now < _endTime)
        {
            Console.ReadLine();
            _count++;
        }
        Console.WriteLine($"\nYou listed {_count} things.");
        EndActivity();
    }
}