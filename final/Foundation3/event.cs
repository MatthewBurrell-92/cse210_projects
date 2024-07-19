using System;

public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    protected string _fullDetails;
    protected string _shortDetails;
    public Event(string title, string description, string date, string time, Address eventAddress)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = eventAddress;
    }

    public void DisplayAddress()
    {
        Console.WriteLine($"{_address.GetAddress()}");
    }

    //    Full details - Lists all of the above, plus type of event and information specific to that event type. 
    // For lectures, this includes the speaker name and capacity. 
    // For receptions this includes an email for RSVP. 
    // For outdoor gatherings, this includes a statement of the weather.
    //   Short description - Lists the type of event, title, and the date.

    public void DisplayStandard()
    {
        // Lists the title, description, date, time, and address.
        Console.Clear();
        Console.WriteLine($"The title of the event is {_title}. ");
        Console.WriteLine("");
        Console.WriteLine($"Here's a brief description:"); // \n{_description}\n");
        Console.WriteLine(_description);
        Console.WriteLine(" ");
        Console.WriteLine($"The event will take place on {_date} beginning at {_time}.");
        Console.WriteLine(" ");
        Console.WriteLine($"The address is as follows: "); //{_address.GetAddress()}");
        Console.WriteLine(_address.GetAddress());
    }

    public void DisplayFull()
    {
        Console.Clear();


        Console.WriteLine($"The title of the event is {_title}. ");
        Console.WriteLine("");
        Console.WriteLine($"Here's a brief description:"); // \n{_description}\n");
        Console.WriteLine(_description);
        Console.WriteLine(" ");
        Console.WriteLine($"The event will take place on {_date} beginning at {_time}.");
        Console.WriteLine(" ");
        Console.WriteLine($"The address is as follows: "); //{_address.GetAddress()}");
        Console.WriteLine(_address.GetAddress());
        // Console.WriteLine($"The title of the event is {_title}.\n");
        // Console.WriteLine($"Here's a brief description:\n{_description}\n");
        // Console.WriteLine($"The event will take place on {_date} beginning at {_time}.\n");
        // Console.WriteLine($"The address is as follows:\n{_address.GetAddress()}");
        // Console.WriteLine("");
        Console.WriteLine(_fullDetails);

    }
    public void DisplayShort()
    {
        Console.Clear();
        Console.WriteLine(_shortDetails);
    }
}