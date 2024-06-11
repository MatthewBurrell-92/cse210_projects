using System;

public class Activity
{
    protected string _activityName;
    protected string _description;
    protected string _duration;
    protected string _prepareMessage;
    protected string _endMessage;
    protected string _pauseAnimation;

    public Activity()
    {
        _activityName = "Muh deek";
    }

    public void DisplayBeginningMesasge()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity! {System.Environment.NewLine}"
        + $"{System.Environment.NewLine}{_description}");
    }
    public string DisplayEndingMesasge()
    {
        return _endMessage;
    }
    public void DisplayAnimation()
    {
        Console.WriteLine("WAIT");
    }
    public void DisplayCountdown()
    {
        Console.WriteLine("WAIT MORE");
    }
}