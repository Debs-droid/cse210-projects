public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse) //this is a constructor--basic 
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse) //this is a constructor--for scripture references with more than 1 verse
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetBook() //getter for _book variable
    {
        return _book;
    }

    public void SetBook(string book) //setter for _book variable
    {
        _book = book;
    }

    public int GetChapter() //getter for _chapter variable
    {
        return _chapter;
    }

    public void SetChapter(int chapter) //setter for _chapter variable
    {
        _chapter = chapter;
    }

    public int GetVerse()
    {
        return _verse;
    }

    public void SetVerse(int verse)
    {
        _verse = verse;
    }

    public int GetEndVerse()
    {
        return _endVerse;
    }

    public void SetEndVerse(int endVerse)
    {
        _endVerse = endVerse;
    }



    public string GetDisplayText() //method to return 
    {
        if (_endVerse == 0)
        {
            return $"{_book} {_chapter}: {_verse}";
        }
        else
        {
            return $"{_book} {_chapter}: {_verse}-{_endVerse}";
        }
    }

}

//reference class gets the display text using the constructor