using System;

public class Video
{
    // Initiates properties and stores values
    public string Title {get; set;}
    public string Author {get; set;}
    public int Length {get; set;}
    
    // A private list to store comments to keep it encapsulated
    private List<Comment> Comments {get; set;}

    // Constructor to build list of comments for videos with each new video
    public Video(string _title, string _author, int _length)
    {
        Title = _title;
        Author = _author;
        Length = _length;
        Comments = new List<Comment>();
    }

    // Function to add comments to comments list
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    //Returns # of comments for each video instance
    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
    
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title} \nAuthor: {Author} \nLength: {Length} seconds");
        Console.WriteLine($"\nNumber of Comments: {GetNumberOfComments()}");

        foreach (var comment in Comments)
        {
            Console.WriteLine($"\nComment by {comment.Name}: {comment.Text}");
        }
    }
}