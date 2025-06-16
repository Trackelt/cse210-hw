class ReflectionActivity : Activity
{
    public ReflectionActivity(string _activityName, string _description)
    : base(_activityName, _description)
    { }

    public void RunReflection()
    {
        List<string> rPrompts = new List<string>();
        rPrompts.Add("Think of a time when you stood up for someone else.");
        rPrompts.Add("Think of a time when you did something really difficult.");
        rPrompts.Add("Think of a time when you helped someone in need.");
        rPrompts.Add("Think of a time when you did something truly selfless.");
        List<string> rQuestions = new List<string>();
        rQuestions.Add("Why was this experience meaningful to you?");
        rQuestions.Add("Have you ever done anything like this before?");
        rQuestions.Add("How did you get started?");
        rQuestions.Add("How did you feel when it was complete?");
        rQuestions.Add("What made this time different than other times when you were not as successful?");
        rQuestions.Add("What is your favorite thing about this experience?");
        rQuestions.Add("What could you learn from this experience that applies to other situations?");
        rQuestions.Add("What did you learn about yourself through this experience?");
        rQuestions.Add("How can you keep this experience in mind in the future?");

        Console.Clear();
        StartMessage();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Animation(2);
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine(RandomPrompt(rPrompts));
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as to how they related to this experience.");
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

        Console.WriteLine();

        List<string> checker = new List<string>();
        int check = 0;
        DateTime end = Timer();
        while (DateTime.Now < end)
        {
            string i = RandomPrompt(rQuestions);
            if (checker.Contains(i))
            {
                if (check >= 9)
                {
                    break;
                }
                else { }
            }
            else
            {
                Console.Write(i);
                Animation(5);
                Console.WriteLine();
    
                check++;
            }

            checker.Add(i);
            //check++;



            //Console.Write(RandomPrompt(rQuestions));
            //Animation(5);
            //Console.WriteLine();
        }
        EndMessage();
    }
}