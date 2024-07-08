using System;

public class ChecklistGoal : Goal
{
    private int _iterationsDone;
    private int _iterationsNeeded;
    private int _bonus;
    public ChecklistGoal() : base()
    {
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        _iterationsNeeded = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        _bonus = int.Parse(Console.ReadLine());
    }
    public ChecklistGoal(string goalName, string description, int points, int iterationsNeeded, int iterationsDone, int bonus) : base(goalName, description, points)
    {
        _iterationsNeeded = iterationsNeeded;
        _iterationsDone = iterationsDone;
        _bonus = bonus;
    }
    public override void DisplayGoal()
    {
        if (_iterationsDone == _iterationsNeeded)
        {
            Console.WriteLine($"[X] {_goalName} ({_description})"
            + $" -- Currently completed: {_iterationsDone}/{_iterationsNeeded}.");
        }

        else
        {
            Console.WriteLine($"[ ] {_goalName} ({_description}) "
            +$"-- Currently completed: {_iterationsDone}/{_iterationsNeeded}.");
        }
    }
    public override void DisplayGoalName()
    {
        Console.WriteLine(_goalName);
    }
    public override void SaveToFile(StreamWriter outputFile)
    {
        outputFile.Write("3/");
        outputFile.Write($"{_goalName}/");
        outputFile.Write($"{_description}/");
        outputFile.Write($"{_points}/");
        outputFile.Write($"{_iterationsDone}/");
        outputFile.Write($"{_iterationsNeeded}/");
        outputFile.Write($"{_bonus}/");
    }

    public override void ReadFromFile(string line)
    {
        string[] parts = line.Split("/");
        _goalName = parts[1];
        _description = parts[2];
        _points = int.Parse(parts[3]);
        _iterationsDone = int.Parse(parts[4]);
        _iterationsNeeded = int.Parse(parts[5]);
        _bonus = int.Parse(parts[6]);
    }

    public override void RecordEvent(Gamification game)
    {
        game.AddPoints(_points);
        _iterationsDone += 1;
        if (_iterationsDone == _iterationsNeeded)
        {
            game.AddPoints(_bonus);
        }
        Console.WriteLine($"You now have {game.DisplayPoints()} points. ");
    }

}