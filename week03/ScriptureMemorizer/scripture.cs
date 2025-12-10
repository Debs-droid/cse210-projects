using System.Globalization;
using System.Reflection.Metadata.Ecma335;

public class Scripture
{
    private Reference _reference; //attribute object created referring to reference class
    private List<Word> _words; //attribute--here a list of word objects, not a list of strings

    //Word w = new Word("_", false);
    public Scripture(Reference reference, string text) //Constructor for single verse
    {
        _reference = reference;

        _words = new List<Word>(); //create space for it to be populated 
        string[] splitWords = text.Split(" ");  //indexes have [] brackets 

        foreach (string splitWord in splitWords)
        {
            Word newWord = new Word(splitWord);

            _words.Add(newWord);
        }

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
        _words = text;
    }


    public void HideRandomWords(int numHide) //--method to hide words--how many words to hide each time, and replace _ for each word letter
    {
        Random random = new Random();
        for (int i = 0; i < numHide; i++)//++ means index is increment by 1
        {
            int randomIndex = random.Next(_words.Count);
            _words[randomIndex].Hide();

        }
    }

    public string GetDisplayText() //what are the responsibilities--delivers 
    {
        string _constScrip = ""; //empty list

        foreach (Word word in _words) //foreach needs 
        {
            _constScrip += $"{word.GetDisplayText()} ";
        }

        return _constScrip;
    }

    public bool IsCompletelyHidden() //delivers quit //returns true if very word is hidden. yes, completely hidden=true; no, not all hidden=false;
    {
        //string _notShown = "_";

        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)  //not hidden--word is showing, passage not completely hidden.      --the quit (return;) is in IsHidden, so by referencing this, it should quit when all words are hidden.
            {
                return false; //not all the words are hidden--this stops the method and goes back to program.
            }
        }
        return true;
    }
}


