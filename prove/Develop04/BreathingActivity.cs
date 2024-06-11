using System;

public class BreathingActivity : Activity
{
    private string _action;
    private int _seconds;

    public BreathingActivity() : base()
    {
        _activityName = "Breathing";
        _description = "This activity will help you relax by walking you through " +
        "breathing in and out slowly. Clear your mind and focus on your breathing. ";
        // Console.WriteLine("How long, in seconds, would you like your session? ");
        // string input = Console.ReadLine();
        // int.TryParse(input, out _seconds);
    }
    public int SetSeconds()
    {
        Console.WriteLine(" ");
        Console.WriteLine("How long do you want to breath? ");
        _seconds = int.Parse(Console.ReadLine());
        return _seconds;
    }
}
