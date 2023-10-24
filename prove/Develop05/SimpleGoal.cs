using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(bool isComplete, string name, string description, string points) : base(name, description, points)
    {
        _isComplete = isComplete; 
    }
    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
    public override bool IsComeplete()
    {
        throw new NotImplementedException();
    }
    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }
    public override string GetDetailsString()
    {
        throw new NotImplementedException();
    }
}