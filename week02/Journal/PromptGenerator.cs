public class PromptGenerator 
{
    public List<string> _prompts = new List<string>
    {
        "What are three things you enjoyed today?",
        "Is there anything that worried you today?",
        "Is there anything you would have done differently today?",
        "Who helped you today?",
        "Who or what are you grateful for today? (3 things)",
        "What are you excited about today?",
        "What made you happy today?",
        "How can I make tomorrow 1% better than today?",
        "How was I proactive today?",
        "What was the funniest thing that happened (or that I saw) today?",
        "What is one thing I accomplished or am proud of today?",
        "What is one goal you achieved today? And one you didn't? (small victories, temporary failures)"
    };

    Random rnd = new Random(); //this is now an attribute of the class


    public string GetRandomPrompt() //this is the function or behavior or method
    {
        int pIndex = rnd.Next(_prompts.Count);
        //Console.WriteLine ($"{_prompts[pIndex]}");
        return _prompts[pIndex]; //_prompts is a specific instance, which is selected randomly according to its specific index number
    }
}