using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();     //"new List<Video>() is the constructor; it creates a instance and the form for the instance; type first/object name/   hold an object of a class; class=List<Video> custom variable designed to hold a class Video 


        Video vid1 = new Video("SunshineBoy", "How to Make Awesome Fries", 280); //customized class, not a list

        vid1.myCommentStorage1.Add(new Comment("Abraham Lincoln", "I love your video!"));
        vid1.myCommentStorage1.Add(new Comment("Sister Stowell", "This makes me hungry!"));
        vid1.myCommentStorage1.Add(new Comment("Woody", "Give me some of your tots!"));

        Video vid2 = new Video("SquirrelKing", "NumisNumnum", 300);

        vid2.myCommentStorage1.Add(new Comment("E.T", "Take me to your leader."));
        vid2.myCommentStorage1.Add(new Comment("Hello Kitty", "Did you mean nom nom or num num?"));
        vid2.myCommentStorage1.Add(new Comment("Lucas", "I know exactly what you mean, brother!"));

        Video vid3 = new Video("IzzyBoo4U", "Love Your Chicken 101", 450);

        vid3.myCommentStorage1.Add(new Comment("The Cows", "Do you have any electric blankets?"));
        vid3.myCommentStorage1.Add(new Comment("Farmer Duck", "Give us a diving board."));
        vid3.myCommentStorage1.Add(new Comment("Mom", "Did you clean the coop?"));

        vid1.showVideo();
        vid2.showVideo();
        vid3.showVideo();
    }




}






//creates 3 video objects--including setting their values; each video creates and sets 3 comment objects including setting their values. the video objects are stored in a list
//iterates through list of video objects and displays each one's title, author, length, number of comments (using the method). for each video, displays the comments(commenter's name and text)
//Classes and methods use TitleCase, member variables use _underscoreCamelCase, local variables use camelCase.



