using System.Security.Cryptography.X509Certificates;

class MathAssignment : Assignment
{
    //private string _studentName; //these are the ones inherited from assignment class
    //private string _topic; //these are the ones inherited from assignment class
    private string _bookSection;
    private string _problems;
    public MathAssignment(string studentName, string topic, string bookSection, string problems) : base(studentName, topic) //see if this is set up appropriately
    {
        _bookSection = bookSection;
        _problems = problems;
    }

    public string GetHomeworkList() //method 
    {
        return $"Homework: Section {_bookSection} Problems {_problems}\n";
    }
}



/*public int GetBookSection()
{
    return _bookSection;
}

public void SetBookSection(int bookSection)
{
    _bookSection = bookSection;
}

public int GetProblems() //getter
{
    return _problems;
}

public void SetProblems(int problems)
{
    _problems = problems;
}*/


