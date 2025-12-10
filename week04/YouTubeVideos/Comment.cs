using System.Net;

public class Comment
{
    public string _nameCommenter; //attributes
    public string _textComment;

    public Comment(string name, string text) //constructor
    {
        _nameCommenter = name;
        _textComment = text;
    }

    public void displayComment() //method
    {
        Console.WriteLine($"Commenter: {_nameCommenter} Comment: {_textComment}");
    }
}

//this is ready--create the comment list and objects in video class; create the video list in the program class