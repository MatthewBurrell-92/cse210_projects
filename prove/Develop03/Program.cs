using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture1 = new Scripture();
        string John316 = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        string[] words = John316.Split(" ");
        foreach (var word in words)
        {
            Word new_word = new Word(word);
            scripture1.SetWords(scripture1, new_word);
        }
        scripture1.DisplayScripture();
        
    }
}