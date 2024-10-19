using System;

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        this._name = name;
        this._description = description;
    }

    public void SetDuration()
    {
        Console.WriteLine("How many seconds would you like for this activity: ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void ShowStartMessage()
    {
        Console.WriteLine($"Starting {_name}");
        Console.WriteLine(_description);
        SetDuration();
        Console.WriteLine("Prepare to start . . .");
        ShowSpinner(3);
    }

    public void ShowEndMessage()
    {
        Console.WriteLine("Fantastic!");
        Console.WriteLine($"You completed the {_name} activity with the selected time of {_duration} seconds");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.WriteLine(". ");
            System.Threading.Thread.Sleep(2000);
        }

        Console.WriteLine();
    }

    public abstract void Run();
}