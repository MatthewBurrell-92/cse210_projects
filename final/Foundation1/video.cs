using System;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _commentList = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public int GetNumberOfComments()
    {
        int totalComments = 0;
        foreach (Comment comment in _commentList)
        {
            totalComments += 1;
        }
        return totalComments;
    }
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"{_title}, by {_author}.");
        Console.WriteLine($"The video is {_length} seconds long and has {GetNumberOfComments()} comments.");
    }

    public void DisplayComments()
    {
        Console.WriteLine("\nThe comments for the video are: \n");
        foreach (Comment comment in _commentList)
        {
            comment.DisplayComment();
        }
    }
}