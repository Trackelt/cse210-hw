class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;

    public Activity()
    {
        
    }
    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    public void StartMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}!");
        Console.WriteLine(_description);
        Console.WriteLine("How many seconds would you like this activity to last?");
        string response = Console.ReadLine();
        _duration = int.Parse(response);
    }

    public void EndMessage()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed {_activityName}");
        Console.WriteLine($"You spent {_duration} doing this activity");
    }

    public void Timer()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        if (DateTime.Now < endTime)
        {

        }
    }

    public void Animation()
    {
        int sleepTime = 500;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(2);
        while (DateTime.Now < endTime)
        {
            Console.Write("-");
            Thread.Sleep(sleepTime);
            Console.Write("\b");
            Console.Write('\\');
            Thread.Sleep(sleepTime);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(sleepTime);
            Console.Write("\b");
            Console.Write("/");
            Thread.Sleep(sleepTime);
            Console.Write("\b");
            
        }
    }
}