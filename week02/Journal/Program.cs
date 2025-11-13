/*
Class: Program (the menu will be here, I think)
Attributes:
* _write : string
*_display : string
*_load : string
*_save : string
*_quit : string
Behaviors:
*SelectMenuItem() : void

Class: Journal (will store a list--yes a LIST--of journal entries)
Attributes:
*_entry : List<Entry>
Behaviors:
*SaveToFile(file : string) void
*LoadFromFile(file : string) void
*DisplayAll(): void
*AddEntry(newEntry : Entry) : void

Class: Entry
Attributes:
*_date : string
*_promptText : string
*_entryText : string
Behaviors:
*Display(): void


Class: PromptGenerator 
Attributes:
*_prompts : List<string>
Behaviors:
*GetRandomPrompt(): string
*
*/





using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
    }
}