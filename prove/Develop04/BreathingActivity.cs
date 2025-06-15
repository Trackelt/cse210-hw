class BreathingActivity : Activity
{

    public BreathingActivity(string _activityName, string _description)
    : base(_activityName, _description)
    {
        //_activityName = "Breathing Activity";
        //_description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing";
    }
    public void RunBreathing()
    {
        Console.Clear();
        StartMessage();
        Console.Clear();
        Console.WriteLine("Get ready...");
        Animation(2);
        Console.WriteLine();
        DateTime end = Timer();
        while (DateTime.Now < end)
        {
            Console.Write("Breathe in...3");
            Thread.Sleep(1000);
            Console.Write("\b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b");
            Console.Write(" ");
            Console.WriteLine();
            Console.Write("Breathe out...3");
            Thread.Sleep(1000);
            Console.Write("\b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b");
            Console.Write(" ");
            Console.WriteLine();
        }
        EndMessage();
        
    }
}