using System;

public class Cycling : Activity
{
    // See the Running class for an explanation of why I made _speed an attribute for Cycling.
    private float _speed;


    public Cycling(string date, int duration, float speed) : base(date, duration)
    {
        _speed = speed;
        _activityName = "Cycling";
    }

    public override float CalculateDistance()
    {
        float distance = _speed * _duration / 60;
        return distance;
    }
    public override float CalculateSpeed()
    {
        return _speed;
    }
    public override float CalculatePace()
    {
        float pace = 60 / _speed;
        return pace;
    }
}