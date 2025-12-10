using System;
using System.Net;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        Reference r = new Reference("Ether", 12, 27, 28);  //this has the class, the "handle", and the (new) instance is inside the ( )--the parameters are the new instance that is specified  
        Scripture s = new Scripture(r, "If men come unto me I will show unto them their weakness.");


        bool _funStuff = true;




        Console.WriteLine("Hello World! This is the Scripture Memorizer Project.");
        Console.WriteLine("Press enter to continue or type 'quit' to finish.");

        while (_funStuff == true) //while, if can both use == text with conditions that resolve to true or false
        {
            Console.WriteLine($"{r.GetDisplayText()}"); //shows the reference
            Console.WriteLine($"{s.GetDisplayText()}");

            if (s.IsCompletelyHidden() == true)
            {
                _funStuff = false;
                //return; //this ends the program--this is the end anyway
            }

            s.HideRandomWords(2);

            //add the other stuff above here
            Console.WriteLine("Do you want to continue? if yes, press enter. If no, type 'quit'.");
            string _noFun = Console.ReadLine();
            if (_noFun == "quit")
            {
                _funStuff = false;
            }



        }











    }


}

/*
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
*/



//($"{Reference.GetBook(_book)} {_chapter}: {_verse}-{endVerse}");


//"And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble. and my grace is sufficient for all men that humble themselves before me. for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.");


//Scripture scripture = new Scripture(reference, 

//Reference reference = new Reference("Ether", 12, 27);

//part of 1 Nephi 16:29--And thus we see that by small means the Lord can bring about great things.
//D&C 64:33 33 Wherefore, be not weary in well-doing, for ye are laying the foundation of a great work. And out of small things proceedeth that which is great.