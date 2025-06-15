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
        Animation(2);
        Console.WriteLine($"You have completed {_duration} seconds of {_activityName}.");
        Animation(2);
    }

    public DateTime Timer()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        return endTime;
    }

    public void Animation(int seconds)
    {
        int sleepTime = 500;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
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
        Console.Write("\b");
        Console.Write(" ");
    }

    public string RandomPrompt(List<string> list)
    {
        Random random = new Random();
        int length = list.Count();
        int index = random.Next(0, length);
        string prompt = list[index];
        return prompt;
    }
}