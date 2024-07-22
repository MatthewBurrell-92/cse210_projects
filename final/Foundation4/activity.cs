using System;

public abstract class Activity
{
    protected string _activityName;
    protected string _date;
    protected int _duration;

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }
    public string GetSummary()
    {
        string summary = $"{_date} {_activityName} ({_duration} min)- Distance {CalculateDistance().ToString("0.00")} miles," +
        $" Speed {CalculateSpeed().ToString("0.00")}, Pace: {CalculatePace().ToString("0.00")} min per mile.";
        return summary;
    }
    public virtual float CalculateDistance()
    {
        // miles
        return 1.0F;
    }
    public virtual float CalculateSpeed()
    {
        // miles per hour
        return 2.0F;
    }
    public virtual float CalculatePace()
    {
        return 3.0F;
    }

}