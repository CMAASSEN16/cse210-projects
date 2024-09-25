using System;

class Program
{
    static void Main(string[] args)
    {
        // These are the inputs for Job.cs
        Job job1 = new Job();
        job1._title = "Sales Associate";
        job1._startYear = 2024;
        job1._endYear = 2025;
        job1._company = "Arizona Lawn King";

        Job job2 = new Job();
        job2._title = "CNA/ Maintenance";
        job2._startYear = 2022;
        job2._endYear = 2024;
        job2._company = "Ensign";

        // This is calling the Resume.cs file function
        Resume myResume = new Resume();
        myResume._name = "Collin Maassen";

        // This adds the information from Job.cs to Resume.cs
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        //This pulls the display from Resume with the complete information
        myResume.DisplayResume();

    }
}