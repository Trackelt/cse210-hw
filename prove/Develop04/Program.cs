using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity myBreathing = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing");
        myBreathing.RunBreathing();

        //Activity myActivity = new Activity("potatos", "are eating food");
        //Activity myTimer = new Activity();
        //myActivity.StartMessage();
        //myActivity.Animation();
    }
}