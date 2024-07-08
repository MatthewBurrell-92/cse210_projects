using System;

public class SimpleGoal : Goal
{
    private bool _complete;
    public SimpleGoal() : base()
    {
        _complete = false;
    }
    public SimpleGoal(string goalName, string description, int points, bool complete) : base(goalName, description, points)
    {
        _complete = complete;
    }
    // public override string IsComplete(Gamification game)
    // {
    //     game.AddPoints(_points);
    //     return "Your goal is complete!";
    // }
    public override void RecordEvent(Gamification game)
    {
        if (!_complete)
        {
            game.AddPoints(_points);
            _complete = true;
            Console.WriteLine($"You now have {game.DisplayPoints()} points. ");
        }
        else
        {
            Console.WriteLine("You've completed this goal. ");
        }
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
    public override void DisplayGoalName()
    {
        Console.WriteLine(_goalName);
    }
    public override void SaveToFile(StreamWriter outputFile)
    {
        outputFile.Write("1/");
        outputFile.Write($"{_goalName}/");
        outputFile.Write($"{_description}/");
        outputFile.Write($"{_points}/");
        outputFile.Write($"{_complete}/");
    }
}