public class Word
{
    private string _text; //attribute
    private bool _isHidden; //attribute --true or false

    public Word(string text) //this is a constructor
    {
        _text = text;

        _isHidden = false; //default value--
    }

    public void Hide()  //method/function --for word, change to underscore--count length of word (how many letters), then for each--put letters inside text (adding to text)
    {

        _isHidden = true;

    }
    public void Show() //method/function 
    {
        _isHidden = false; //default value--this one makes sure you can go back to showing--either when iterating list or show the scripture at the end.
    }
    public bool IsHidden() //method/function--if _isHidden is true (yes, hidden), return false; if false (not hidden) return true
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return "_";
        }
        else
        {
            return _text;
        }
    }
}
//hide is supposed set _IsHidden to true; show sets it to false; checks and returns