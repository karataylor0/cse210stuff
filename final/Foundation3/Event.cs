using System;

public abstract class Event
{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private string _address;

    public Event(string eventTitle, string description, string date, string time, string stringAddress)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = stringAddress;
    }

    public void StandardDetails()
    {
        Console.WriteLine($"{_eventTitle}: {_description}\n{_date} at {_time}\n{_address}");
    }
    public abstract void FullDetails();

    public string GetEventTitle()
    {
        return _eventTitle;
    }
    public string GetDescription()
    {
        return _description;
    }
    public string GetDate()
    {
        return _date;
    }
    public string GetTime()
    {
        return _time;
    }
}