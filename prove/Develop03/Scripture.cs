using System;

public class Scripture
{
    public List<Word> _words = new List<Word>();
    private int _length;

    public void DisplayScripture()
    {
        foreach (Word word in _words)
        {
            word.Render();
        } 
    }

    public void CreateWordList(Scripture scripture, Word w)
    {
        scripture._words.Add(w);
    }

    public void HideWords(Scripture scripture)
    {
        Random rnd = new();
        int indeces = (scripture._words.Count);
        for (int i = 0; i < 4; i++)
        {
            int which_hide = rnd.Next(0,indeces);
            _words
            while (Word.Hide(word) == false)
            {
                which_hide = rnd.Next(0,indeces);
            }
        }
    }
            
    

}