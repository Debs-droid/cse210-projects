class Assignment
{
    protected string _studentName; //private or protected?--I did make the getters/setters so why not work if private?
    protected string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;

    }

    public string GetStudentName() //getter
    {
        return _studentName;
    }

    public void SetStudentName(string studentName) //setter
    {
        _studentName = studentName;
    }

    public string GetTopic() //getter
    {
        return _topic;
    }

    public void SetTopic(string topic) //setter
    {
        _topic = topic;
    }

    public string GetSummary() //method
    {
        return $"\n{_studentName} - {_topic}";
    }
}
