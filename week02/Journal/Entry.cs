public class Entry
{
    public string _date; //this is an attribute of class entry
    public string _promptText;
    public string _entryText;

    public void Display() //display the three attributes when menu item 
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
    }
}

