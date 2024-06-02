using System;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    private string _reference;

    public void GetReference(Reference reference)
    {
        // This method took a while to figure out...
        // I hope its ok that I parsed the reference to the
        // scripture attribute as a string and not a reference.
        // I couldn't figure out how to parse it as a reference.
        // It took me so long. I'm exhausted.
        _reference = reference.GetReference();
    }

    public void DisplayScripture()
    {
        // This method displays all the words of the scripture
        // as well as the reference.
        Console.Clear();
        Console.WriteLine(_reference);
        foreach (Word word in _words)
        {
            word.Render();
        } 
    }

    public void CreateWordList(Scripture scripture, Word w)
    {
        // DON'T TOUCH
        // I wrote this method early in my design of the code
        // and didn't want to mess it up because it worked.
        scripture._words.Add(w);
    }

    public void HideWords()
    {
        // This method randomly chooses three words to hide.
        // When there are less than three words to hide, the 
        // method hides the rest of the displayed words.
        Random rnd = new();
        int indeces = (_words.Count);
        int remaining = 0;
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                remaining += 1;
            }
        }
        if (remaining >= 3)
        {
            for (int i = 0; i < 3; i++)
            {
                int which_hide = rnd.Next(0,indeces);
                while (_words[which_hide].IsHidden() == true)
                {
                    which_hide = rnd.Next(0,indeces);
                }
                _words[which_hide].Hide();
            }
        }
        else
        {
            foreach (Word word in _words)
            {
                word.Hide();
            }
        }        
    }
    public bool IsCompletelyHidden()
    {
        // This method determines if the scripture that has been
        // displayed is completely hidden.
        bool shown = false;
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
            else
            {
                shown = true;
            }
        }
        return shown;
    }
}