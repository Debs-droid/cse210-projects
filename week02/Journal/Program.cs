using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal j = new Journal();

        PromptGenerator p = new PromptGenerator();


        while (true)
        {
            Console.WriteLine("Welcome to the Journal Program! \nPlease select one of the following choices: ");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.WriteLine("What would you like to do? ");
            int number = int.Parse(Console.ReadLine());


            if (number == 1) //receive prompt and write in journal. press enter when finished
            {
                string _prompt = p.GetRandomPrompt();
                Console.WriteLine($"{_prompt}"); //the prompt displays in the console
                Entry e = new Entry();
                //string _entry = Console.ReadLine();
                //e._entryText = _entry;  //taking the temp variable ( _entry) and transfer it to the entry class variable which is _entryText
                e._entryText = Console.ReadLine();

                e._promptText = _prompt; //e._promptText is the variable, _prompt (the data is in _prompt)

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                e._date = dateText;

                //add entry e to journal list--this is built in lines 22-26
                j.AddEntry(e);

            }
            else if (number == 2) //display all journal entries--iterate through and display all entries--journal object, which has list of entries stored inside it(this object is _entries)
            {
                j.DisplayAll();
            }
            else if (number == 3) //load journal entry  --do we have to load first, in order to display?--takes them from journal text
            {
                Console.WriteLine("What is the file name?");

                string filename = Console.ReadLine();

                j.LoadFromFile(filename);

            }

            else if (number == 4) //Save to textfile journal.txt
            {
                j.SaveToFile();
            }
            else if (number == 5) //exit program--click run to start again
            {
                System.Environment.Exit(0);
            }
        }
    }
}