public class Scripture
{
    private ref _reference Reference; //this is an attribute--is this right? attribute object created referring to reference class
    private List<Word> _words; //attribute

    public Scripture(ref reference, string text) //Constructor
    {
        _reference = reference;
        _words = text;
    }

    public void HideRandomWords(int numberToHide) //method/function
    {
        2 = numberToHide; //do we put a number for how many words to hide with each pres enter?
    }

    public string GetDisplayText();
    public bool IsCompletelyHidden();

}