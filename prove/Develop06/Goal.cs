using System;

public abstract class Goals
{
    protected string _goalName {get; set;}
    protected string _goalDescription {get; set;}
    protected int _points {get; set;}
    protected bool _isCompleted {get; set;}

    public Goals(string name, string goalDescription, int points)
    {
        _goalName = name;
        _goalDescription = goalDescription;
        _points = points;
        _isCompleted = false;
    }
    public int GetPoints()
    {
        return _points;
    }
    
    public string GetDescription()
    {
        return _goalDescription;
    }

    public string GetName()
    {
        return _goalName;
    }

    public bool IsCompleted
    {
        get { return _isCompleted; }
        set {_isCompleted = value;}
    }


    public abstract void RecordEvent();
    public abstract string DisplayStatus();
}