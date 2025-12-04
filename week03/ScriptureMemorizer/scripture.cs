public class Scripture
{
    private Reference _reference; //attribute object created referring to reference class
    private List<Word> _words; //attribute--here a list of word objects, not a list of strings


    public Scripture(Reference reference, string text) //Constructor for single verse
    {
        _reference = reference;
        
        _words = new List<Word>(); //create space for it to be populated 
        string[] splitWords = text.Split(" ");

        foreach (string splitWord in splitWords)
        {
            Word newWord = new Word(splitWord);

            _words.Add(newWord);
        }

        
        
        
        
        //indexes have [] brackets 
    }


    public Reference GetReference() //getter, get reference
    {
        return _reference;
    }
    public void SetReference(Reference reference)
    {
        _reference = reference;
    }
    public List<Word> GetWords() //getter, get words
    {
        return _words;
    }
    public void SetWords(List<Word> text)
    {
        _words = text; //is this the correct variable to use here? maybe i should call it words not wordList
    }


    public void HideRandomWords() //method to hide words--how many words to hide each time, and replace _ for each word letter
    {
        List<Word> _wordList = new List<Word>();


        /*while (text != "_") //?????
        {
            //this is where i change the letters to _ 
        }

        Random random = new Random();

        int randomIndex = random.Next(_wordList.Count);

        string randomWord = _wordList[randomIndex];

        //this was from a google search of "c# random selection generator" so not correct in this context*/
    } //need random number--generate it each time you call the function--what position to hide in the scripture; 
      // while loop, 2 at a time; get the word, function IsHidden called from word class; check if it is hidden, call the function Hide

}


/*public string GetDisplayText();
public bool IsCompletelyHidden() //call function in word--create object
{
    if (_words = _) //either use == for boolean test, or ?
    {
        return true;
    }
    else
    {
        return false;
    }
}*/



//attributes: member variables for reference (ref), list of words in the scripture
//scripture class methods: hides random words, gets display text, and ends when all is completely hidden (bool)
