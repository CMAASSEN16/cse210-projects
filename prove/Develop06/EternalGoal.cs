using System;

public class EternalGoal : Goals
{
    public EternalGoal(string goalName, string goalDescription, int points) : base(goalName, goalDescription, points) {}

    public override void RecordEvent()
    {
        Console.WriteLine($"Recorded event for goal: {_goalName} \nYou earned {_points} points, great job!");
    }

    public override string DisplayStatus()
    {
        return "|☯| " + _goalName;
    }
}