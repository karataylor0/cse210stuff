using System;

using System;

public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string rsvpEmail, string eventTitle, string description, string date, string time, string address) : base(eventTitle, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override void FullDetails()
    {
        base.StandardDetails();
        Console.WriteLine($"RSVP @ {_rsvpEmail}");
    }
}