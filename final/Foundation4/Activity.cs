using System;
using System.Security.Cryptography.X509Certificates;

public abstract class Activity
{
    private string _month;
    private int _day;
    private int _year;
    private int _length; //in minutes
    public Activity(string month, int day, int year, int length)
    {
        _month = month;
        _day = day;
        _year = year;
        _length = length;
    }

    public abstract int FindDistance();
    public abstract int FindSpeed();
    public abstract int FindPace();
    public abstract void DisplaySummary();
    public int GetLength()
    {
        return _length;
    }
    public string GetMonth()
    {
        return _month;
    }
    public int GetDay()
    {
        return _day;
    }
    public int GetYear()
    {
        return _year;
    }
    
}