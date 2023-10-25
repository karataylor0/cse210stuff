using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {

    }
    public override void RecordEvent()
    {
        throw new NotImplementedException();
        //record event for eternal goal
        
    }
    public override string GetStringRepresentation()
    {
        //return string representation of goal
        return $"{_name}: {_description}";
    }
    public override string GetDetailsString()
    {
        //return string representation of details
        return $"";
    }
    public override bool IsComeplete()
    {
        //return true if completed, false if not
        throw new NotImplementedException();
    }
}