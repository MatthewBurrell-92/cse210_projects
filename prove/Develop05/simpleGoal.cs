using System;

public class SimpleGoal : Goal
{
    bool _complete;
    public SimpleGoal() : base()
    {
        _complete = false;
    }
    public override string IsComplete(Gamification game)
    {
        game.AddPoints(_points);
        return "Your goal is complete!";
    }

    public override void DisplayGoal()
    {
        if (_complete == false)
        {
            Console.WriteLine($"[ ] {_goalName} ({_description})");
        }
        else
        {
            Console.WriteLine($"[X] {_goalName} ({_description})");
        }
    }
}