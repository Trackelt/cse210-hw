class Scripture
{
    private List<string> _scriptures;
    public List<string> GetScriptList()
    {
        return _scriptures;
    }
    public Scripture(string subscript, string choice)
    { 
        
    }
    public Scripture(List<string> scriptures)
    {
        _scriptures = scriptures;
    }
    public string[] SplitVerse(string _verse)
    {
        string[] words = _verse.Split(' ');
        return words;
    }
}