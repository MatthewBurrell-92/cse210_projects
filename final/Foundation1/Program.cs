using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to code like a pro", "Not me", 10842);
        Video video2 = new Video("How to Tig weld", "Also not me", 600);
        Video video3 = new Video("STORY AND LORE OF WARHAMMER 40K With ANIMATIONS", "Sandman of Terra", 3101);
        Video video4 = new Video("Reflexive Verbs in Spanish", "The Language Tutor - Spanish", 637);

        Comment newComment = new Comment("John", "I now code like a pro.");
        video1._commentList.Add(newComment);
        newComment = new Comment("Jacob", "How do I write a comment in C#?");
        video1._commentList.Add(newComment);
        newComment = new Comment("Jingleheimer", "Back in my day, we didn't write code in fancy programs. We wrote code on parchment, with quills!");
        video1._commentList.Add(newComment);
        newComment = new Comment("Schmidt", "Porque no hay clases privadas en tu codigo?");
        video1._commentList.Add(newComment);

        newComment = new Comment("Bubba", "Can you tig weld with a flux core welder?");
        video2._commentList.Add(newComment);
        newComment = new Comment("Junior", "Nah man, but you can mig weld with a flux core.");
        video2._commentList.Add(newComment);
        newComment = new Comment("Bubba Junior", "Can you post a video of how to use the foot pedal?");
        video2._commentList.Add(newComment);
        newComment = new Comment("Fredrick", "Yump. This good.");
        video2._commentList.Add(newComment);

        newComment = new Comment("UltraMarines00011420", "FOR THE EMPORER");
        video3._commentList.Add(newComment);
        newComment = new Comment("Abaddon_the_despoiled_egg", "#the_planet_broke_before_the_guard_did");
        video3._commentList.Add(newComment);
        newComment = new Comment("OrkBoiz", "MORE DAKKA");
        video3._commentList.Add(newComment);
        newComment = new Comment("Bubba", "Can you tig weld with a mig welder?");
        video3._commentList.Add(newComment);

        newComment = new Comment("Amanda", "My brother speaks Spanish.");
        video4._commentList.Add(newComment);
        newComment = new Comment("Debby", "why is spanish so hard uhhhh.");
        video4._commentList.Add(newComment);
        newComment = new Comment("Cristy", "*comment is removed due to racist remarks*");
        video4._commentList.Add(newComment);
        newComment = new Comment("Holly", "Soy en casa, aprender espanish.");
        video4._commentList.Add(newComment);

        video1.DisplayVideoInfo();
        video1.DisplayComments();
        Console.WriteLine("");
        video2.DisplayVideoInfo();
        video2.DisplayComments();
        Console.WriteLine("");
        video3.DisplayVideoInfo();
        video3.DisplayComments();
        Console.WriteLine("");
        video4.DisplayVideoInfo();
        video4.DisplayComments();
    }
}