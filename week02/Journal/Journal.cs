public class Journal
{
    public List<Entry> _entries = new List<Entry>(); //list<entry> is the class, _entries is the handle(variable)--created a new instance of the class

    public void AddEntry(Entry newEntry) //function AddEntry is part of Journal class
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries) //iterates through the list and each entry displays itself. the entry class teaches it how
        {
            entry.Display();
        }
        
    }
    public void SaveToFile(string file)
    {

    }
    public void LoadFromFile(string file)
    {

    }
}

