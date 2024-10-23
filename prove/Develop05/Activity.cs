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
        Console.WriteLine($"Starting {_name}\n");
        Console.WriteLine(_description);
        SetDuration();
        Console.WriteLine("\nPrepare to start . . .");
        ShowSpinner();
    }

    public void ShowEndMessage()
    {
        Console.WriteLine("\nFantastic!");
        Console.WriteLine($"You completed the {_name} activity with the selected time of {_duration} seconds");
        ShowSpinner();
    }



    protected void ShowSpinner()
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }

        Console.WriteLine();
    }

    public abstract void Run();
}