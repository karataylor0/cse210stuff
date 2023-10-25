using System;

public class Cycling : Activity
{
    private int _speed;

    public Cycling(int speed, string month, int day, int year, int length) : base(month, day, year, length)
    {
        _speed = speed;
    }
    public override int FindDistance()
    {
        return FindPace() / base.GetLength();
    }
    public override int FindPace()
    {
        return 60 / _speed;
    }
    public override int FindSpeed()
    {
        return _speed;
    }
    public override void DisplaySummary()
    {
        Console.WriteLine($"{base.GetDay()} {base.GetMonth()} Cycling ({base.GetLength()} min)-Distance: {FindDistance()} km, Speed: {FindSpeed()} kph, Pace: {FindPace()} min per km");
    }
}