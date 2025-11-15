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


                if (number == 1) //receive prompt and write in journal. press enter when finished?
                {
                    Console.WriteLine($"{p.GetRandomPrompt()}"); //add readline and 
                    
                }
                else if (number == 2) //display all journal entries--iterate through and display all entries
                {
                    //Console.WriteLine($"Date: {date} - Prompt: {prompt}");
                    //Console.WriteLine($"{/* prompt from text file?*/}");
                }
                else if (number == 3) //load journal entry  --do we have to load first, in order to display?
                {
                    Console.WriteLine("What is the file name?");

                    string filename = Console.ReadLine();
                }
                else if (number == 4) //Save to textfile journal.txt
                {
                    SaveToFile(j._entries); 
                }
                else if (number == 5) //exit program--click run to start again
                {
                    System.Environment.Exit(1);
                }
            }    
        }
        

    public static void SaveToFile(List<Entry> entry) //entry is the name it is referred to. j._entries is the object or particular instance
    {
        
        Console.WriteLine("What is the file name?");
        string filename = Console.ReadLine();


        Console.WriteLine("Saving to file...");

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in entry)
            {
                outputFile.WriteLine($"{e._date}~~{e._promptText}~~{e._entryText}"); //??--iwas watcing "reading and writing demo video" not sure if this is correct
            }
        }

        Console.WriteLine("Your file has saved.");
    }
}