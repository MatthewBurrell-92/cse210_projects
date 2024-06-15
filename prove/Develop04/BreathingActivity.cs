using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        // Constructor
        _activityName = "Breathing";
        _description = "This activity will help you relax by walking you through " +
        "breathing in and out slowly. Clear your mind and focus on your breathing. ";
    }
    public void RunBreathingActivity()
    {
        // I used to have a lot of my code in Program.cs.
        // I decided that since I had a Run___Activity method in each of
        // my child classes, that I would make a parent method of
        // RunActivity, and then put in a decision algorithm and each
        // of the necessary methods for each of the activities.
        // It took some work to figure out, but it worked in the end. 


        // Practicing Abstraction here. I think.
        // This method runs through everything for each breathing session.
        // DisplayBeginningMessage();
        // Console.WriteLine(" ");
        // Duration();
        // Console.Clear();
        // Console.WriteLine("Get ready...");
        // DisplayAnimation();
        // Console.Clear();
        // DisplayInandOut(_duration);
        // DisplayEndingMessage();
        // DisplayAnimation();
        // Console.Clear();
    }
    public void DisplayInandOut(int duration)
    {
        // I made this method to separate it from the RunBreathingActivity method.
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {
            Console.Write("Breath in...");
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("\n");
            Console.Write("Breath out...");
            Console.Write("6");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("5");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.WriteLine("\n");
            currentTime = DateTime.Now;
        }
    }
}
