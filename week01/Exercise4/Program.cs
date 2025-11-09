using System;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();


        //This sets up the list.
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a list of numbers, one at a time. Type 0 to exit the list. ");

            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);


            //only add to the list if the number entered is not 0.
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        //Requirement 1. It iterates using a foreach loop
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of the list is {sum}.");

        //Requirement 2. This one was hard for me. I'm not sure that I get it. 
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average number in the list is {average}.");

        //Requirement 3. I googled and found this way.
        int highNum = numbers.Max();

        Console.WriteLine($"The highest number in the list is {highNum}.");

        //Requirement 3. this is the longer way, not a short cut.
        int highestNum = numbers[0];

        foreach (int number in numbers)
        {
            if (number > highestNum)
            {
                highestNum = number;
            }
        }

        Console.WriteLine($"The max number is still {highestNum}.");
        int highestNumber = numbers[0];

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > highestNumber)
            {
                highestNumber = numbers[i];
            }
        }
        Console.WriteLine($"I tried this three ways and the highest number is still {highestNumber}. Pretty cool.");


    }
}