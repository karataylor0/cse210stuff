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
        throw new NotImplementedException();
        //return string representation of goal
    }
    public override string GetDetailsString()
    {
        throw new NotImplementedException();
    }
    public override bool IsComeplete()
    {
        throw new NotImplementedException();
    }
}