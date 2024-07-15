using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to code like a pro", "Not me", 10842);
        Video video2 = new Video("How to Tig weld", "Also not me", 600);
        Video video3 = new Video("STORY AND LORE OF WARHAMMER 40K With ANIMATIONS", "Sandman of Terra", 3101);
        Video video4 = new Video("Reflexive Verbs in Spanish", "The Language Tutor - Spanish", 637);

        Comment comment1 = new Comment();
        comment1._author = "John";
        comment1._text = "I now code like a pro.";
        video1._commentList.Add(comment1);
        Comment comment2 = new Comment();
        comment2._author = "Jacob";
        comment2._text = "How do I write a comment in C#?";
        video1._commentList.Add(comment2);
        Comment comment3 = new Comment();
        comment3._author = "Jingleheimer";
        comment3._text = "Back in my day, we didn't write code in fancy programs. We wrote code on parchment, with quills!";
        video1._commentList.Add(comment3);
        Comment comment4 = new Comment();
        comment4._author = "Schmidt";
        comment4._text = "Porque no hay clases privadas en tu codigo?";
        video1._commentList.Add(comment4);

        Comment comment5 = new Comment();
        comment5._author = "Bubba";
        comment5._text = "Can you tig weld with a flux core welder?";
        video2._commentList.Add(comment5);
        Comment comment6 = new Comment();
        comment6._author = "Junior";
        comment6._text = "Nah man, but you can mig weld with a flux core.";
        video2._commentList.Add(comment6);
        Comment comment7 = new Comment();
        comment7._author = "Bubba Junior";
        comment7._text = "Can you post a video of how to use the foot pedal?";
        video2._commentList.Add(comment7);
        Comment comment8 = new Comment();
        comment8._author = "Fredrick";
        comment8._text = "Yump. This good.";
        video2._commentList.Add(comment8);

        Comment comment9 = new Comment();
        comment9._author = "UltraMarines00011420";
        comment9._text = "FOR THE EMPORER";
        video3._commentList.Add(comment9);
        Comment comment10 = new Comment();
        comment10._author = "Abaddon_the_despoiled_egg";
        comment10._text = "#the_planet_broke_before_the_guard_did";
        video3._commentList.Add(comment10);
        Comment comment11 = new Comment();
        comment11._author = "OrkBoiz";
        comment11._text = "MORE DAKKA";
        video3._commentList.Add(comment11);
        Comment comment12 = new Comment();
        comment12._author = "Bubba";
        comment12._text = "Can you tig weld with a mig welder?";
        video3._commentList.Add(comment12);

        Comment comment13 = new Comment();
        comment13._author = "Amanda";
        comment13._text = "My brother speaks Spanish.";
        video4._commentList.Add(comment13);
        Comment comment14 = new Comment();
        comment14._author = "Debby";
        comment14._text = "why is spanish so hard uhhhh.";
        video4._commentList.Add(comment14);
        Comment comment15 = new Comment();
        comment15._author = "Cristy";
        comment15._text = "*comment is removed due to racist remarks*";
        video4._commentList.Add(comment15);
        Comment comment16 = new Comment();
        comment16._author = "Holly";
        comment16._text = "Soy en casa, aprender espanish.";
        video4._commentList.Add(comment16);

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