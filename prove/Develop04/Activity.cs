public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    private int _spinnerDuration = 2;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartActivity()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine($"{_description}\n");

        Console.WriteLine("How long would you like the session to be? (seconds)");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready.");
        ShowSpinner(_spinnerDuration);
    }

    public void EndActivity()
    {
        Console.WriteLine($"\n{_name} complete.");
        ShowSpinner(_spinnerDuration);

        Console.WriteLine($"You have completed {_duration} seconds of the {_name}");
        ShowSpinner(_spinnerDuration);
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void ShowSpinner(int seconds)
    {
        string[] _spinner = {"|","/","-","\\"};
        DateTime _endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < _endTime)
        {
            Console.Write(_spinner[i]);
            Thread.Sleep(250);
            Console.Write("\b");
            i = (i + 1) % _spinner.Length;
        }
    }
}