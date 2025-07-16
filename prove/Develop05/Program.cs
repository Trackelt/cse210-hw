using System;
using System.Formats.Asn1;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int totalScore = 0;
        List<Goal> goals = new List<Goal>();
        int response = 0;
        while (response != 6)
        {
            int level = CalculateLevel(totalScore);
            string title = GetLevel(level);

            Console.WriteLine($"Current Score: {totalScore} | Status: {title}");
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option from the menu: ");
            string choice = Console.ReadLine();
            if (int.TryParse(choice, out response))
            {
                if (response == 1)
                {
                    CreateGoal(goals);
                }
                else if (response == 2)
                {
                    ListGoals(goals);
                }
                else if (response == 3)
                {
                    SaveGoal(goals, totalScore);
                }
                else if (response == 4)
                {
                    (goals, totalScore) = LoadGoal();
                }
                else if (response == 5)
                {
                    totalScore += RecordGoal(goals);
                }
                else if (response == 6)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please re-enter input");
                }

            }
            else
            {
                Console.WriteLine("Please enter a number");
            }

        }


    }

    static void CreateGoal(List<Goal> goals)
    {
        int goalResponse = 0;
        int points = 0;
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        string goalChoice = Console.ReadLine();

        if (int.TryParse(goalChoice, out goalResponse))
        {
            if (goalResponse >= 1 && goalResponse <= 3)
            {
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string desc = Console.ReadLine();
                Console.Write("How many points should it give? ");
                string point = Console.ReadLine();
                if (int.TryParse(point, out points))
                { }
                else
                {
                    Console.WriteLine("Please re-enter input");
                }
                if (goalResponse == 1)
                {
                    goals.Add(new SimpleGoal(name, desc, points));
                }
                else if (goalResponse == 2)
                {
                    goals.Add(new EternalGoal(name, desc, points));
                }
                else if (goalResponse == 3)
                {
                    int target = 0;
                    int extraPoints = 0;
                    Console.Write("How many times does it need to be completed? ");
                    string howMany = Console.ReadLine();
                    if (int.TryParse(howMany, out target))
                    { }
                    else
                    {
                        Console.WriteLine("Please re-enter input");
                    }
                    Console.Write("How many extra points should it give? ");
                    string extra = Console.ReadLine();
                    if (int.TryParse(extra, out extraPoints))
                    { }
                    else
                    {
                        Console.WriteLine("Please re-enter input");
                    }
                    goals.Add(new CheckListGoal(name, desc, points, target, extraPoints));
                }

            }
            else
            {
                Console.WriteLine("Please re-enter input");
            }
        }
        else
        {
            Console.WriteLine("Please enter a number");
        }
    }

    static void ListGoals(List<Goal> goals)
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals to display");
            return;
        }
        else
        {
            Console.WriteLine("The goals are:");
            for (int i = 0; i < goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {goals[i].GetDisplayText()}");
            }
        }
    }

    static int RecordGoal(List<Goal> goals)
    {
        int choice;
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals available");
            return 0;
        }
        else
        {
            Console.WriteLine("The goals are:");
            for (int i = 0; i < goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {goals[i]._Name}");
            }
            Console.Write("Which goal did you complete? ");
            string choice2 = Console.ReadLine();
            if (int.TryParse(choice2, out choice))
            {
                choice = choice - 1;
            }
            else
            {
                Console.WriteLine("Please re-enter input");
            }
            if (choice < 0 || choice >= goals.Count)
            {
                Console.WriteLine("Please re-enter input");
                return 0;
            }
            int earned = goals[choice].RecordEvent();
            Console.WriteLine($"Congratulations! You have earned {earned} points");
            return earned;
        }
    }
    static void SaveGoal(List<Goal> goals, int totalScore)
    {
        Console.Write("What will be the name of the file? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(totalScore);
            foreach (Goal goal in goals)
            {
                outputFile.WriteLine(goal.GetSaveText());
            }
        }
    }
    static (List<Goal>, int) LoadGoal()
    {
        Console.Write("What is the name of the file you wish to load? ");
        string filename = Console.ReadLine();
        List<Goal> goals = new List<Goal>();
        int totalScore = 0;
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found");
            return (goals, totalScore);
        }
        string[] lines = File.ReadAllLines(filename);
        if (lines.Length == 0)
        {
            Console.WriteLine("File is empty");
            return (goals, totalScore);
        }
        totalScore = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(',');
            string type = parts[0];
            string name = parts[1];
            string desc = parts[2];
            int points = int.Parse(parts[3]);

            if (type == "SimpleGoal")
            {
                bool IsComplete = bool.Parse(parts[4]);
                SimpleGoal goal = new SimpleGoal(name, desc, points);
                if (IsComplete)
                {
                    goal.RecordEvent();
                }
                goals.Add(goal);
            }
            else if (type == "EternalGoal")
            {
                goals.Add(new EternalGoal(name, desc, points));
            }
            else if (type == "ChecklistGoal")
            {
                int bonus = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int current = int.Parse(parts[6]);
                CheckListGoal goal = new CheckListGoal(name, desc, points, target, bonus);
                for (int j = 0; j < current; j++)
                {
                    goal.RecordEvent();
                }
                goals.Add(goal);
            }
        }
        return (goals, totalScore);
    }
    static int CalculateLevel(int totalScore)
    {
        return (totalScore / 1000) + 1;
    }
    static string GetLevel(int level)
    {
        string title;
        if (level == 1)
        {
            title = "Peasant";
        }
        else if (level == 2)
        {
            title = "Squire";
        }
        else if (level == 3)
        {
            title = "Knight";
        }
        else if (level == 4)
        {
            title = "Lord";
        }
        else if (level == 5)
        {
            title = "King";
        }
        else
        {
            title = "Grandmaster";
        }
        return title;
    }
}