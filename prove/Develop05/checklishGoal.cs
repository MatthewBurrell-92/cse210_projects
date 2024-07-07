using System;

public class ChecklistGoal : Goal
{
    private int _iterations;
    private int _bonus;
    public ChecklistGoal() : base()
    {
        Console.WriteLine("How many times deos this goal need to be accomplished for a bonus? ");
        _iterations = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        _bonus = int.Parse(Console.ReadLine());
    }
}