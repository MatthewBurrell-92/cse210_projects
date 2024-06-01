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

    public void DisplayWords()
    {
        Console.WriteLine(_word);
    }
    public void Hide() 
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        if (_isHidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void Render()
    {
        if (_isHidden == false)
        {
            // DON'T TOUCH
            Console.Write($"{_word} ");
        }
        else
        {
            // I spent a lot of time looking up how to do this. I forgot all the websites I
            // used to figure it out.
            // This is the site that brought it all together:
            // https://www.linkedin.com/pulse/c-keywords-tutorial-part-14-char-amr-saafan/
            int length = (_word.Length);
            char c = '_';
            String hidden_word = new String(c, length);
            Console.Write($"{hidden_word} ");
        }
    }
     
}