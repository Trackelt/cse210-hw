class ListingActivity : Activity
{
    public ListingActivity(string _activityName, string _description)
    : base(_activityName, _description)
    { }

    public void RunListing()
    {
        List<string> lPrompts = new List<string>();
        lPrompts.Add("Who are people that you appreciate?");
        lPrompts.Add("What are personal strengths of yours?");
        lPrompts.Add("Who are people that you have helped this week?");
        lPrompts.Add("When have you felt the Holy Ghost this month?");
        lPrompts.Add("Who are some of your personal heroes?");

        Console.Clear();
        StartMessage();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Animation(2);
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine(RandomPrompt(lPrompts));
        Console.Write("You may begin in: 5");
        Thread.Sleep(1000);
        Console.Write("\b");
        Console.Write("4");
        Thread.Sleep(1000);
        Console.Write("\b");
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Clear();

        List<string> responses = new List<string>();
        DateTime end = Timer();
        while (DateTime.Now < end)
        {
            responses.Add(Console.ReadLine());
        }
        int number = responses.Count();
        Console.WriteLine($"You listed {number} items!");
        EndMessage();
    }
}