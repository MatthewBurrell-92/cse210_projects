using System;

public class Word
{
    private string _word;
    private bool _isHidden;

        public Word(string word, bool hidden = false)
    {
        _word = word;
        _isHidden = hidden;
    }

    public void GetWord()
    {
        Console.Write($"{_word} ");
    }
    // private HideWord(string word, bool hide)
    // {

    // }
}