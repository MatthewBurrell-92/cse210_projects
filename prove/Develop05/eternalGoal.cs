using System;

public class EternalGoal : Goal
{
    int _iterations;

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
        // This function was pretty easy for me to figure out.
        // using (StreamWriter outputFile = new StreamWriter(file_name))
        // {
        outputFile.Write("2/");
        outputFile.Write($"{_goalName}/");
        outputFile.Write($"{_description}/");
        outputFile.Write($"{_points}/");
        outputFile.Write($"{_iterations}/");
        // }
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
    }
}