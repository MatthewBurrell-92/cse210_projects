using System;

public class Goal
{
    protected string _goalName;
    protected string _description;
    protected int _points;
    // public Goal(string name, string description, int points)
    // {
    //     _goalName = name;
    //     _description = description;
    //     _points = points;
    // }
    public Goal()
    {
        Console.WriteLine("What is the name of your Goal? ");
        _goalName = Console.ReadLine();
        Console.WriteLine("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.WriteLine("What is the the amount of points assiciated with this Goal? ");
    }
}