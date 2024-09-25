using System;

public class Resume
{
    // This allows the program file to pull the variable
    public string _name;
    
    // This creates the stored list that is created in the program using Job.cs file
    public List<Job> _jobs = new List<Job>();

    // This pulls everything and combines Job.cs and Resume.cs functions
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        
        foreach (Job job in _jobs)
        {
            job.DisplayJobInfo();
        }
    }
}
