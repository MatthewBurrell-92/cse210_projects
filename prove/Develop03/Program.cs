using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture1 = new Scripture();
        string John316 = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        string[] words = John316.Split(" ");
        Reference new_ref1 = new Reference("John", 3, "16");
        Console.WriteLine(new_ref1.GetReference());
        
        foreach (var word in words)
        {
            Word new_word = new Word(word,false);
            scripture1.CreateWordList(scripture1, new_word);
        }

        scripture1.DisplayScripture();
        
    }
}