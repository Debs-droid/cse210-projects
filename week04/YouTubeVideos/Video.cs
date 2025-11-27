using System.Security.Cryptography.X509Certificates;

public class Video
{
    public string _author;
    public string _title;
    public int _seconds;

    public List<Comment> myCommentStorage1 = new List<Comment>(); //method to list comments

    public Video(string author, string title, int seconds) //constructor, three parameters; so, when I call the object, I just enter in the three parameters how I want them displayed
    {
        _author = author;
        _title = title;
        _seconds = seconds;
    }

    public void showVideo() //method to show video
    {
        Console.WriteLine($"Video Title: {_title} Author: {_author} Length in Seconds: {_seconds}");

        foreach (Comment c in myCommentStorage1)
        {
            c.displayComment(); //understand where the method is coming from--the method is displayComment. It is coming from comment class

        }

        Console.WriteLine($"Total Number of Comments: {myCommentStorage1.Count}");
    }

}
