class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string _name, string _desc, int _points)
    : base(_name, _desc, _points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _Points;
        }
        else
        {
            return 0;
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDisplayText()
    {
        string checkbox;
        if (_isComplete == true)
        {
            checkbox = "X";
        }

        else
        {
            checkbox = " ";
        }
        return $"[{checkbox}] {_Name} ({_Desc})";
        
    }

    public override string GetSaveText()
    {
        return $"SimpleGoal,{_Name},{_Desc},{_Points},{_isComplete}";
    }

}