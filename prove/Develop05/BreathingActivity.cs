using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you yo breathe in and out slowly.") {}

    public override void Run()
    {
        ShowStartMessage();
        Random random = new Random();
        int _elapsed = 0;

        while (_elapsed < _duration)
        {
            int breatheInTime = random.Next(2,6);
            int breatheOutTime = random.Next(5,10);

            Console.WriteLine($"Breathe in for {breatheInTime} seconds. . .");
            ShowCountDown(breatheInTime);
            _elapsed += breatheInTime;

            if (_elapsed < _duration)
            {
                Console.WriteLine($"Breathe out for {breatheOutTime} seconds. . .");
                ShowCountDown(breatheOutTime);
                _elapsed += breatheOutTime;
            }
        }
        
        ShowEndMessage();
    }


    private void ShowCountDown(int seconds)
    {
        for (int i = seconds; i>0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}