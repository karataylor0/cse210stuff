using System;

public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string weatherForecast, string eventTitle, string description, string date, string time, string address) : base(eventTitle, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }
    public override void FullDetails()
    {
        base.StandardDetails();
        Console.WriteLine($"The weather will be {_weatherForecast}");
    }
}