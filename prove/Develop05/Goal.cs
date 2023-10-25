using System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent();
    public abstract bool IsComeplete();
    public abstract string GetDetailsString();
    {
        return $"{_shortName}: {_description}. {_points}";
    }
    public abstract string GetStringRepresentation();
    {
        return $"{_shortName}";
    }

    //i would like to take a nap now please
    //sleepy time for kara!
}