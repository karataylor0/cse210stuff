using System;
using System.Runtime.CompilerServices;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager(List<Goal> goals, int score)
    {
        _goals = goals;
        _score = score;
    }
    public void Start()
    {
        _score = 0;
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"{_goals} : {_score}");
    }
    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goal.GetStringRepresentation()}");
        }
    }
    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goal.GetDetailsString()}");
        }
    }
    public string CreateGoal()
    {
        Console.WriteLine("What is the name of the goal?");
        string name = Console.ReadLine();
        Console.WriteLine("What type of goal would you like to create?\n1. Checklist Goal\n2. Eternal Goal\n3. Simple Goal");
        string goalType = Console.ReadLine();

        return name + "~|~" + goalType;
    }
    public void RecordGoal()
    {
        //record goal
    }
    public void SaveGoals()
    {
        //save goal to file
    }
    public void LoadGoals()
    {
        //load goal to file
    }
}