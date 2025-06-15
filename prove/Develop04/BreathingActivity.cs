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
        StartMessage();
        
    }
}