using System;
using System.Collections.Generic;


public class Video
{
    private List<Comment> _comments = new List<Comment>();
    private string _title;
    private string _author;
    private double _length;

    public Video(string title, string author, double length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    private int NumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayVideoDetails()
    {
        int totalComments = NumberOfComments();
        Console.WriteLine($"Title: {_title}\nCreator: {_author}\nDuration: {_length} minutes");
        Console.WriteLine($"{totalComments} Comments:\n");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.GetDisplayText());
            Console.WriteLine("");
        }
        
    }

}
