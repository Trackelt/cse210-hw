class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentname, string topic, string booksection, string problems)
    : base(studentname, topic)
    {
        _textbookSection = booksection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section: {_textbookSection} Problems: {_problems}";
    }
}