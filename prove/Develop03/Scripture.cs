using System;

public class Scripture
{
    private List<Word> _words = new List<Word>();

    public void DisplayScripture()
    {
        foreach (Word word in _words)
        {
            word.GetWord();
        } 
    }
    public void SetWords(Scripture scripture, Word w)
    {
        scripture._words.Add(w);
    }
    public void GetWords(Scripture scripture)
    {
        foreach (Word word in scripture._words)
        {
            Console.WriteLine(word);
        }
    }
}