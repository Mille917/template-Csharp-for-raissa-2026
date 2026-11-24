// VIDEO CLASS

using System;
using System.Collections.Generic;

public class Video
{
    public string _title;
    public string _author;
    public int _lengthSeconds;
    public List<Comment> _comments = new List<Comment>();

    public int GetCommentCount()
    {
        return _comments.Count;
    }
    
    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthSeconds} seconds");
        Console.WriteLine($"Comments ({GetCommentCount()}):");
        foreach (var comment in _comments)
        {
            comment.Display();
        }
        Console.WriteLine();
    }
}