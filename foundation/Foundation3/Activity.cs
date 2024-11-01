using System;

public abstract class Activity
{
    private string _date;
    private int _duration;

    public Activity(string date, int duration)
    {
        _date = date ?? throw new ArgumentNullException(nameof(date), "Date cannot be null");
        _duration = duration;
    }

    public string Date => _date;
    public int Duration => _duration;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date} ({_duration} min): Distance {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min/mile";
    }
}