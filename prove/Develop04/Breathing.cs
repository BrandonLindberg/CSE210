public class Breathing : Activity
{
    public Breathing() : base("Breathing Activity", "This activity will help you relax by guiding you through slow breathing.")
    {}

    public void RunActivity()
    {
        StartActivity();
        DateTime _endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < _endTime)
        {
            Console.Write($"\nBreathe in...");
            ShowCountdown(4);

            Console.Write($"\nBreathe out...");
            ShowCountdown(7);
        }
        EndActivity();
    }
}