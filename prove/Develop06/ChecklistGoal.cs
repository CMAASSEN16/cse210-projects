using System;

public class ChecklistGoal : Goals
{
    private int _targetCount {get; set;}
    private int _currentCount {get; set;}
    private int _bonusPoints {get; set;}

    public ChecklistGoal(string goalName, string goalDescription, int points, int targetCount, int bonusPoints) : base(goalName, goalDescription, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
    }

    public override void RecordEvent()
    {
        _currentCount++;
        Console.WriteLine($"\nRecent event recorded on {_goalName} goal. \nCurrent Progress: {_currentCount}/{_targetCount}");

        if (_currentCount >= _targetCount)
        {
            _isCompleted = true;
            Console.WriteLine($"\n{_goalName} goal has been achieved! \n{_points + _bonusPoints} earned for recording this event!");
        }
        else
        {
             Console.WriteLine($"\n{_points} earned for recording this event!");
        }
    }

    public override string DisplayStatus()
    {
        return _isCompleted ? $"|x| {_goalName} - Completed {_currentCount}/{_targetCount}" : $" | | {_goalName} - Progress {_currentCount}/{_targetCount}";
    }
}