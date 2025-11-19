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
    //public void SaveToFile(string file)
    public void SaveToFile() //entry is the name it is referred to. j._entries is the object or particular instance
    {
        Console.WriteLine("What is the file name?");
        string filename = Console.ReadLine();

        Console.WriteLine("Saving to file...");

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date}~~{e._promptText}~~{e._entryText}");
            }
        }

        Console.WriteLine("Your file has saved.");
    }

    public void LoadFromFile(string file)
    {
        //string  = "journal.txt";
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");
            Entry e = new Entry();
            e._date = parts[0];
            e._promptText = parts[1];
            e._entryText = parts[2];

            _entries.Add(e);
        }
    }
}

