using System.Runtime.CompilerServices;

abstract class Goal
{
    private string _name; 
    private string _desc;
    private int _points;
    public string _Name => _name;
    public string _Desc => _desc;
    public int _Points => _points;

    public Goal(string name, string desc, int points)
    {
        _name = name;
        _desc = desc;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDisplayText();
    public abstract string GetSaveText();

    
}