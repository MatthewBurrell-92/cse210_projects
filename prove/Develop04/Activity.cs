using System;

public class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _activityName = "";
    }

    public void RunActivity(int activity)
    {
        // This method runs the activity. The 
        
        if (activity == 1)
        {
            BreathingActivity breathing1 = new BreathingActivity();
            breathing1.DisplayBeginningMessage();
            Console.WriteLine(" ");
            breathing1.Duration();
            Console.Clear();
            Console.Write("Get ready...");
            DisplayAnimation();
            Console.Clear();
            breathing1.DisplayInandOut(breathing1._duration);
            breathing1.DisplayEndingMessage();
        }
        if (activity == 2)
        {
            ReflectionActivity reflection1 = new ReflectionActivity();
            reflection1.DisplayBeginningMessage();
            Console.WriteLine(" ");
            reflection1.Duration();
            Console.Clear();
            Console.WriteLine($"---{reflection1.GetRandomPrompt()}---");
            Console.WriteLine(" ");
            Console.WriteLine("When you think have something in mind, press enter. ");
            Console.ReadLine();
            Console.WriteLine("Now ponder on each of the following questions" +
            " as they relate to this experience.");
            Console.Write("You may begin in ");
            FiveSecondPause();
            Console.Clear();
            reflection1.CycleRandomQuestions(reflection1._duration);
            reflection1.DisplayEndingMessage();
        }
        if (activity == 3)
        {
            ListingActivity listing1 = new ListingActivity();
            listing1.DisplayBeginningMessage();
            Console.WriteLine(" ");
            listing1.Duration();
            Console.Clear();
            Console.Write("Get ready...");
            DisplayAnimation();
            Console.WriteLine(" ");
            listing1.GetRandomPrompt();
            listing1.DisplayPrompt();
            Console.WriteLine(" ");
            Console.Write($"You may begin in 5 seconds...");
            FiveSecondPause();
            Console.Clear();
            listing1.DisplayPrompt();
            listing1.GetAnswers(listing1._duration);
            listing1.DisplayEndingMessage();
        }
    }
    public void GetInput()
    {
        int activity = 0;
        while (activity != 4)
        {
            Console.WriteLine("Menu options: ");
            Console.WriteLine("1. Breathing Activity ");
            Console.WriteLine("2. Reflection Activity ");
            Console.WriteLine("3. Listing Activity ");
            Console.WriteLine("4. Quit ");
            Console.Write("Please choose an option from the menu: ");
            string input = Console.ReadLine();
            int.TryParse(input, out activity);
            if (activity >= 1 & activity <=3)
            {
                RunActivity(activity);
            }
            else if (activity != 4)
            {
                Console.WriteLine(" ");
                Console.WriteLine("I'm sorry, I didn't understand. ");
                Console.WriteLine("Please enter a number between 1 and 4. ");
                Console.WriteLine(" ");
            }
        }
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
        Console.WriteLine($"You just participated in the {_activityName} Activity for {_duration} seconds!");
        DisplayAnimation();
        Console.Clear();
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
    public void FiveSecondPause()
    {
        // For the reflection and listing activities, there is a 5 second count down.
        // I just threw the code in here, getting it from my breathing in and out method.
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
    }
}