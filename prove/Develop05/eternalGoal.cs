using System;

public class EternalGoal : Goal
{
    private int _iterations;

    public EternalGoal() : base()
    {
        _iterations = 0;
    }
    public EternalGoal(string goalName, string description, int points, int iterations) : base(goalName, description, points)
    {
        _iterations = iterations;
    }

    public override void SaveToFile(StreamWriter outputFile)
    {
        outputFile.Write("2/");
        outputFile.Write($"{_goalName}/");
        outputFile.Write($"{_description}/");
        outputFile.Write($"{_points}/");
        outputFile.Write($"{_iterations}/");
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {_goalName} ({_description})");
    }
    public override void DisplayGoalName()
    {
        Console.WriteLine(_goalName);
    }
    public override void RecordEvent(Gamification game)
    {
        game.AddPoints(_points);
        _iterations += 1;
        Console.WriteLine($"You now have {game.DisplayPoints()} points. ");
    }
}