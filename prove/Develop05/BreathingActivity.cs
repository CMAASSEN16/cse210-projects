using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you yo breathe in and out slowly.") {}

    public override void Run()
    {
        ShowStartMessage();
        int _elapsed = 0;
        while (_elapsed < _duration)
        {
            Console.WriteLine("Breathe in . . .");
            ShowSpinner(4);
            _elapsed += 4;

            if (_elapsed < _duration)
            {
                Console.WriteLine("Breathe out . . .");
                ShowSpinner(6);
                _elapsed += 6;
            }
        } 
        ShowEndMessage();
    }
}