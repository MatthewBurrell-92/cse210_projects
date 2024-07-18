using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address event_address, 
    string speaker, int capacity) : base(title,description,date,time,event_address)
    {
        _speaker = speaker;
        _capacity = capacity;
        _fullDetails = $"Speaker: {_speaker} \nCapacity: {_capacity}";
        _shortDetails = $"Lecture: {_title} on {_date}";
    }
}