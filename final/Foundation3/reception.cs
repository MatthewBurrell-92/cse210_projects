using System;
public class Reception : Event
{
    public Reception(string title, string description, string date, string time, 
    Address event_address) : base(title,description,date,time,event_address)
    {
        // For receptions this includes an email for RSVP. 
        _fullDetails = $"Please join us for {_title} on {_date}. The reception begins at {_time}\n" +
        $"and will begin at {_time}. The address for the event is: \n{_address.GetAddress()}\n" +
        "We hope you can join us!";
        _shortDetails = $"Reception: {_title} on {_date}";
    }
}