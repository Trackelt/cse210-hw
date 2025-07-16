class CheckListGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public CheckListGoal(string _name, string _desc, int _points, int targetCount, int bonusPoints)
    : base(_name, _desc, _points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            if (_currentCount == _targetCount)
            {
                return _Points + _bonusPoints;
            }
            else
            {
                return _Points;
            }
        }
        else
        {
            return 0;
        }
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }
    public override string GetDisplayText()
    {
        string checkbox;
        if (IsComplete() == true)
        {
            checkbox = "X";
        }

        else
        {
            checkbox = " ";
        }
        return $"[{checkbox}] {_Name} ({_Desc}) -- Currently Completed: {_currentCount}/{_targetCount}";
    }
    public override string GetSaveText()
    {
        return $"ChecklistGoal,{_Name},{_Desc},{_Points},{_bonusPoints},{_targetCount},{_currentCount}";
    }
}