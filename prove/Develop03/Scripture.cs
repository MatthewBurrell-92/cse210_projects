using System;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;

    public Reference()
    {
        // NEEDS WORK
        _reference = reference.GetReference();
    }

    public void DisplayScripture()
    {
        Console.Clear();
        // _reference.GetReference();
        foreach (Word word in _words)
        {
            word.Render();
        } 
    }

    public void CreateWordList(Scripture scripture, Word w)
    {
        // DON'T TOUCH
        scripture._words.Add(w);
    }

    public void HideWords()
    {
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
                

        //for i: 1 to 3
        //   pick random word
        //   while random word is hidden
        //     pick another random word
        //   hide word
        
    }
    public bool IsCompletelyHidden()
    {
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