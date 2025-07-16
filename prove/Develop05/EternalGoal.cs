class EternalGoal : Goal
{

    public EternalGoal(string _name, string _desc, int _points)
    : base(_name, _desc, _points)
    { }

    public override int RecordEvent()
    {
        return _Points;
    }

    public override string GetDisplayText()
    {
        return $"[ ] {_Name} ({_Desc})";
    }

    public override string GetSaveText()
    {
        return $"EternalGoal,{_Name},{_Desc},{_Points}";
    }

    public override bool IsComplete()
    {
        return false;
    }
}