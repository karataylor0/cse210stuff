using System;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {

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
    public void CreateGoal()
    {
        //Console.WriteLine("What is the name of the goal?");
        //string name = Console.ReadLine();
        //string description = ""; // add desrciption of type of goal
        //string points = ""; //should start as zero? or is it adding to the previous points?
        
        //Goal goal1 = new Goal(name, description, points);

        //_goals.Add(goal1);
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