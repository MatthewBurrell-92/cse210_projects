using System;

public class Running : Activity
{
    // I made _distance an attribute of Running only because the prompt says that the program
    // is not to save the values for distance, speed, and pace for all of the derived classes, but
    // for running to save the distance, cycling the pace, and swimming the laps.
    // "For each activity, they want to track the the date and the length of the activity in minutes.
    // Then, for each activity, they would like to also track the following:
        // Running: distance
        // Cycling: speed
        // Swimming: number of laps
    // For each activity, they do not want to store this information, but they would like to be able to get following
    // information (by calculation if it is not stored directly):
        // The distance
        // The speed (miles per hour or kilometers per hour)
        // The pace (minutes per mile or minutes per kilometer)
    private float _distance;
    public Running(string date, int duration, float distance) : base(date, duration)
    {
        _distance = distance;
        _activityName = "Running";
    }
    public override float CalculateDistance()
    {
        return _distance;
    }
    public override float CalculateSpeed()
    {
        float speed = CalculateDistance() / _duration * 60;
        return speed;
    }
    public override float CalculatePace()
    {
        float pace = _duration / _distance;
        return pace;
    }
}