using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(int laps, string month, int day, int year, int length) : base(month, day, year, length)
    {
        _laps = laps;
    }
    public override int FindDistance()
    {
        return _laps * 50 / 1000;
    }
    public override int FindPace()
    {
        return base.GetLength() / FindDistance();
    }
    public override int FindSpeed()
    {
        return FindDistance() / base.GetLength() * 60;
    }
    public override void DisplaySummary()
    {
        Console.WriteLine($"{base.GetDay()} {base.GetMonth()} Swimming ({base.GetLength()} min)-Distance: {FindDistance()} km, Speed: {FindSpeed()} kph, Pace: {FindPace()} min per km");
    }
}