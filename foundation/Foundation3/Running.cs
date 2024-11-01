using System;

public class Running : Activity
{
    private double _distance;

    public Running(string date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;
    public override double GetSpeed() => (_distance / Duration) * 60;
    public override double GetPace() => _distance == 0 ? 0 : Duration / _distance;
}