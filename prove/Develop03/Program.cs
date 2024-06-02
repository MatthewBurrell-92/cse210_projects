using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture1 = new Scripture();
        string John316 = "For God so loved the world, that he gave his only begotten Son, "
        + "that whosoever believeth in him should not perish, but have everlasting life.";
        string[] words1 = John316.Split(" ");
        Reference new_ref1 = new Reference("John", 3, "16");
        scripture1.GetReference(new_ref1);

        Scripture scripture2 = new Scripture();
        string DC181011 = "Remember the worth of souls is great in the sight of God; For, behold, "
        + "the Lord your Redeemer suffered death in the flesh; wherefore he suffered the pain of "
        + "all men, that all men might repent and come unto him.";
        string[] words2 = DC181011.Split(" ");
        Reference new_ref2 = new Reference("Doctrine and Covenants", 18, "10-11");
        scripture2.GetReference(new_ref2);
        
        foreach (var word in words1)
        {
            Word new_word = new Word(word,false);
            scripture1.CreateWordList(scripture1, new_word);
        }

            foreach (var word in words2)
        {
            Word new_word = new Word(word,false);
            scripture2.CreateWordList(scripture2, new_word);
        }

        int which = WhichScripture();

        if (which == 1)
        {
            Output(scripture1);
        }
        else
        {
            Output(scripture2);
        }

    }
    static int WhichScripture()
    {
        Random rnd = new();
        int which_scripture = rnd.Next(0,2);
        return which_scripture;
    }
    static void Output(Scripture scripture)
    {
        bool quit = false;
        scripture.DisplayScripture();
        while (quit == false)
        {
            if (scripture.IsCompletelyHidden() == true)
            {
                quit = true;
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();
            if (input == "quit" || input == "QUIT")
            {
                quit = true;
            }
            else
            {
                scripture.HideWords();
                scripture.DisplayScripture();
            }
        }
    }
}