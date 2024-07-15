using System;

public class Comment
{
    public string _author;
    public string _text;

    public void DisplayComment()
    {
        Console.WriteLine($"{_author} wrote: {_text}");
    }
}