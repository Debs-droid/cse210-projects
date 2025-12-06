using System.Security.Cryptography.X509Certificates;

class WritingAssignment : Assignment
{
    protected string _title;


    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetTitle() //getter
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}\n";
    }

}