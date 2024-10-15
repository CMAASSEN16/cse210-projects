using System;

public class Video
{
    public string Title {get; set;}
    public string Author {get; set;}
    public int Length {get; set;}
    private List<Comment> Comments {get; set;}

    public Video(string _title, string _author, int _length)
    {
        Title = _title;
        Author = _author;
        Length = _length;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

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