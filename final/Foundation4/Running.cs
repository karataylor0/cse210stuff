using System;

public class Running : Activity
{
    private int _distance;

    public Running(int distance, string month, int day, int year, int length) : base(month, day, year, length)
    {
        _distance = distance;
    }
    public override int FindDistance()
    {
        return _distance;
    }
    public override int FindPace()
    {
        return base.GetLength() / _distance;
    }
    public override int FindSpeed()
    {
        return _distance / base.GetLength();
    }
    public override void DisplaySummary()
    {
        Console.WriteLine($"{base.GetDay()} {base.GetMonth()} Running ({base.GetLength()} min)-Distance: {FindDistance()} km, Speed: {FindSpeed()} kph, Pace: {FindPace()} min per km");
    }
}