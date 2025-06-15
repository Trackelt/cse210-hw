using System;

class Program
{
    static void Main(string[] args)
    {
        int response = 0;
        
        BreathingActivity myBreathing = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        ReflectionActivity myReflection = new ReflectionActivity("Reflection Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        while (response != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflection activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            response = int.Parse(choice);
            if (response == 1)
            {
                myBreathing.RunBreathing();
            }
            else if (response == 2)
            {
                myReflection.RunReflection();
            }
            else if (response == 3)
            {

            }
            else if (response == 4)
            {
                break;
            }
            else
            {

            }
        }
        
        
        

        //Activity myActivity = new Activity("potatos", "are eating food");
        //Activity myTimer = new Activity();
        //myActivity.StartMessage();
        //myActivity.Animation();
    }
}