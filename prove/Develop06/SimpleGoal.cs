using System;

public class SimpleGoal : Goals
{
    public SimpleGoal(string goalName, string goalDescription, int points) : base(goalName, goalDescription, points) {}

    public override void RecordEvent()
    {
        _isCompleted = true;
        Console.WriteLine($"The goal {_goalName} is completed! \nYou earned {_points} points!");
    }
    public override string DisplayStatus()
    {
        return _isCompleted ? "|X|" + _goalName : "| |" + _goalName;
    }
}