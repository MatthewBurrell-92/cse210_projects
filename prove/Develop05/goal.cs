using System;

public abstract class Goal
{
    protected string _goalName;
    protected string _description;
    protected int _points;
    // private List<Goal> Goals = new List<Goal>();

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
        _points = int.Parse(Console.ReadLine());
    }

    public virtual string IsComplete(Gamification game)
    {
        return "nothing";
    }
    // public void AddGoal(Goal goal)
    // {
    //     Goals.Add(goal);
    // }
    public virtual void DisplayGoal()
    {
        Console.WriteLine(_goalName);
        Console.WriteLine(_description);
    }
}