using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("26 N Center Street", "Rexburg", "Idaho", "USA");
        Address receptionAddress = new Address("2570 N 3000 W", "Rexburg", "Idaho", "USA");
        Address outdoorAddress = new Address("5th West and 3rd North", "Rexburg", "Idaho", "USA");

        string lectureDescription = "This is a two hour lecture on how you and your family can prepare for significant wildfire activity.";
        Lecture lectureEvent = new Lecture("Preparing for Wildfires", lectureDescription, "7/24/2024", "1300", lectureAddress, "Fire Chief Corey Child", 17);

        string receptionDescription = "Come celebrate Matthew and Holly's wedding!";
        Reception receptionEvent = new Reception("Matthew and Holly's wedding reception", receptionDescription, "7/11/24", "1600", receptionAddress);

        string outdoorDescription = "Come play Pickleball until you hate it!";
        Outdoor outdoorEvent = new Outdoor("Pickleball Tournamet", outdoorDescription, "7/23/1904", "0400", outdoorAddress, "Clear skies");

        // Console.WriteLine("Standard:\n");
        // lectureEvent.DisplayStandard();

        // Console.WriteLine("\nFull:\n");
        // lectureEvent.DisplayFull();

        // Console.WriteLine("\nShort:\n");
        // lectureEvent.DisplayShort();
        bool quit = false;
        while (quit == false)
        {
            Console.Clear();
            Console.WriteLine("For which event would you like the information? ");
            Console.WriteLine("1. Lecture ");
            Console.WriteLine("2. Reception ");
            Console.WriteLine("3. Outdoor ");
            Console.WriteLine("4. Quit ");
            int whichEvent = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("What information do you want? ");
            Console.WriteLine("1. Standard Details\n2. Full Details\n3. Short Details ");
            int whatInformation = int.Parse(Console.ReadLine());

            if (whichEvent == 1)
            {
                CallInformationMethod(lectureEvent, whatInformation);
            }
            if (whichEvent == 2)
            {
                CallInformationMethod(receptionEvent, whatInformation);
            }
            if (whichEvent == 3)
            {
                CallInformationMethod(outdoorEvent, whatInformation);
            }
        }
    }
    static void CallInformationMethod(Event chosenEvent, int whatInformation)
    {
        if (whatInformation == 1)
        {
            chosenEvent.DisplayStandard();
        }
        if (whatInformation == 2)
        {
            chosenEvent.DisplayFull();
        }
        if (whatInformation == 3)
        {
            chosenEvent.DisplayShort();
        }
        Console.WriteLine("\nPress enter to continue. ");
        Console.ReadLine();
    }
}