using System;

public class Reference
{
    // It took me like 5 minutes to build this class.
    // And like 5 hours to figure out how to use it.
    private string _book;
    private int _chapter;
    private string _verses;

    public Reference(string book, int chapter, string verses)
    {
        _book = book;
        _chapter = chapter;
        _verses = verses;
    }
    public string GetReference()
    {
        // I tried to have this method return a Reference
        // object, but I couldn't figure out how to make it work.
        string reference = $"{_book} {_chapter}:{_verses} ";
        return reference;
    }
}