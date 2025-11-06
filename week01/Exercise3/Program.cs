using System;

class Program
{
    static void Main(string[] args)
    {   //This section is for part 1 and 2
        /*Console.Write("What is the magic number? ");
        string magic = Console.ReadLine();
        int magicNum = int.Parse(magic);*/

        Random randomNum = new Random();
        int magicNum = randomNum.Next(1, 100);
        int guess = -1;

        while (guess != magicNum)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNum > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNum < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed the magic number!");
            }
        }
       
    }
}