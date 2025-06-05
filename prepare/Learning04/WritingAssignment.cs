class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentname, string topic, string title)
    : base(studentname, topic)
    {
        _title = title;
    }
    public string GetWritingAssignment()
    {
        string studentname = GetStudentName();
        return $"{_title} by {studentname}";
    }
}