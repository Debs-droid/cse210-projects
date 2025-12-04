using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Scripture Memorizer Project.");

        Reference reference = new Reference("Ether", 12, 27, 28);  //this has the class, the "handle", and the (new) instance is inside the ( )--the parameters are the new instance that is specified  

        //Scripture scripture = new Scripture(reference, "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble.");

        //Scripture scripture1 = new Scripture(reference, "Words go here")
        //{
            //Console.WriteLine($"{scripture1}");
        //}

        Console.WriteLine($"{reference.GetDisplayText()}");

        Console.WriteLine("Men come unto me");

        //Console.WriteLine($"{scripture.HideRandomWords()}");
    }

    //call methods that are already created

}





//($"{Reference.GetBook(_book)} {_chapter}: {_verse}-{endVerse}");


//"And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble. and my grace is sufficient for all men that humble themselves before me. for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.");


//Scripture scripture = new Scripture(reference, 

//Reference reference = new Reference("Ether", 12, 27);

//part of 1 Nephi 16:29--And thus we see that by small means the Lord can bring about great things.
//D&C 64:33 33 Wherefore, be not weary in well-doing, for ye are laying the foundation of a great work. And out of small things proceedeth that which is great.