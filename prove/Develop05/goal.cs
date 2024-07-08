using System;

public abstract class Goal
{
    protected string _goalName;
    protected string _description;
    protected int _points;
    public Goal(string goalName, string description, int points)
    {
        _goalName = goalName;
        _description = description;
        _points = points;
    }
    public Goal()
    {
        Console.WriteLine("What is the name of your Goal? ");
        _goalName = Console.ReadLine();
        Console.WriteLine("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.WriteLine("What is the the amount of points associated with this Goal? ");
        _points = int.Parse(Console.ReadLine());
    }
    public virtual string IsComplete(Gamification game)
    {
        return "nothing";
    }
    public virtual void DisplayGoal(){}
    public virtual void DisplayGoalName(){}
    public virtual void SaveToFile(StreamWriter outputFile){}
    public virtual void ReadFromFile(string line){}
    public virtual void RecordEvent(Gamification game){}
}