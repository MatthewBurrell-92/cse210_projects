using System;
public class Reception : Event
{
    public Reception(string title, string description, string date, string time, 
    Address eventAddress) : base(title,description,date,time,eventAddress)
    {
        _fullDetails = $"Please join us for {_title} on {_date}. The reception begins at {_time}\n" +
        $"and will begin at {_time}. The address for the event is: \n{_address.GetAddress()}\n" +
        "We hope you can join us!";
        _shortDetails = $"Reception: {_title} on {_date}";
    }
}