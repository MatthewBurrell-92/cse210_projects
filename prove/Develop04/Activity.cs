using System;

public class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;
    protected string _prepareMessage;
    protected string _endMessage;
    protected string _pauseAnimation;

    public Activity()
    {
        _activityName = "";
    }

    public void DisplayBeginningMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity! {System.Environment.NewLine}"
        + $"{System.Environment.NewLine}{_description}");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done! ");
        DisplayAnimation();
        Console.WriteLine(" ");
        Console.WriteLine($"You just participated in the {_activityName} Avticity for {_duration} seconds!");
        DisplayAnimation();
    }
    public int Duration()
    {
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out _duration))
        {
            return _duration;
        }
        else
        {
            Console.WriteLine("I'm sorry, I didn't understand that. Your session will run for 60 seconds. ");
            _duration = 60;
            return _duration;
        }
    }
    public void DisplayAnimation()
    {
        // I used the code provided in the assignment description
        // to build this method.
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            currentTime = DateTime.Now;
            Console.Write($"\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }

    }
}