using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address eventAddress, 
    string speaker, int capacity) : base(title,description,date,time,eventAddress)
    {
        _speaker = speaker;
        _capacity = capacity;
        _fullDetails = $"Speaker: {_speaker} \nCapacity: {_capacity}";
        _shortDetails = $"Lecture: {_title} on {_date}";
    }
}