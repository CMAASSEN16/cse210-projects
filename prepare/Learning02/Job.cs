using System;

public class Job
{
    // These are taking info from input from Program.cs file
    public string _title;
    public int _startYear;
    public int _endYear;
    public string _company;

    // This puts Job info into the form we want it displayed
    public void DisplayJobInfo()
    {
        Console.WriteLine($"{_title} {_startYear}-{_endYear} ({_company})");
    }
}