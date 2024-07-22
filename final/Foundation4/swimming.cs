using System;

public class Swimming : Activity
{
    // See the Running class for an explanation of why I made _laps an attribute for Swimming.
    private float _laps;

    public Swimming(string date, int duration, float laps) : base(date, duration)
    {
        _laps = laps;
        _activityName = "Swimming";
    }
    public override float CalculateDistance()
    {
        float distance = _laps * 50 / 1000 * 0.62F;
        return distance;
    }
    public override float CalculateSpeed()
    {
        float speed = CalculateDistance() / _duration * 60;
        return speed;
    }
    public override float CalculatePace()
    {
        float pace = _duration / CalculateDistance();
        return pace;
    }
}