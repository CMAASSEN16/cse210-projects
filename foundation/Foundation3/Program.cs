using System;
using System.Collections.Generic; // Ensure this import is here

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold activity objects
        List<Activity> activities = new List<Activity>();

        try
        {
            // Add activities to the list, wrapped in individual try-catch blocks
            activities.Add(new Swimming("05 Aug 2024", 30, 10));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Swimming activity creation failed: {ex.Message}");
        }

        try
        {
            activities.Add(new Running("10 Aug 2024", 30, 2.5));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Running activity creation failed: {ex.Message}");
        }

        try
        {
            activities.Add(new Cycling("21 Oct 2024", 30, 17.9));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Cycling activity creation failed: {ex.Message}");
        }

        // Iterate over the activities and print their summaries
        foreach (var activity in activities)
        {
            if (activity != null)
            {
                Console.WriteLine(activity.GetSummary());
            }
            else
            {
                Console.WriteLine("Encountered null activity");
            }
        }
    }
}
