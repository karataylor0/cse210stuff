using System;

public class BirthdayParty : Event
{
    private int _attendees;
    private string _snacks;

    public BirthdayParty(int attendees, string snacks, string eventTitle, string description, string date, string time, string address) : base(eventTitle, description, date, time, address)
    {
        _attendees = attendees;
        _snacks = snacks;
    }

    public override void FullDetails()
    {
        base.StandardDetails()
        Console.WriteLine($"There will be {_attendees} invited. {_snacks} will be provided");
    }
}