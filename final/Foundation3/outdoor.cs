using System;

public class Outdoor : Event
{
    private string _weather;
    public Outdoor(string title, string description, string date, string time, 
    Address event_address, string weather) : base(title,description,date,time,event_address)
    {
        _weather = weather;
        // For outdoor gatherings, this includes a statement of the weather.
        _fullDetails = $"The weather for the event is forcasted to be {_weather}.";
        _shortDetails = $"Outdoor Event: {_title} on {_date}";
    }
}