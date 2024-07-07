using System;

public class Gamification
{
    private int _totalPoints;

    public Gamification()
    {
        _totalPoints = 0;
    }

    public int AddPoints(int points)
    {
        _totalPoints += points;
        return _totalPoints;
    }
    public void DisplayPoints()
    {
        Console.WriteLine($"You have {_totalPoints} points. ");
    }
}