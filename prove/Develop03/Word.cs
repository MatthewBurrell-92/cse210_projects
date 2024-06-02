using System;

public class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word, bool hidden = false)
    {
        // I have come to appreciate constructors.
        _word = word;
        _isHidden = hidden;
    }

    public void Hide() 
    {
        // This is pretty obvious, right?
        _isHidden = true;
    }

    public bool IsHidden()
    {
        // I had this method return a Boolean so that I
        // could use it to determine if the word is hidden.
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
            // Again, this was working and I didn't want to break it...
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