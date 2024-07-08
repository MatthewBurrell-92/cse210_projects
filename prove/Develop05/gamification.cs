using System;

public class Gamification
{
    private int _totalPoints;

    public Gamification()
    {
        _totalPoints = 0;
    }
    public Gamification(int points)
    {
        _totalPoints = points;
    }

    public int AddPoints(int points)
    {
        _totalPoints += points;
        return _totalPoints;
    }
    public int DisplayPoints()
    {
        return _totalPoints;
    }

    public void SaveToFile(StreamWriter outputFile)
    {
        outputFile.Write($"{_totalPoints}");
    }
}