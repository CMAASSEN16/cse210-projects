using System;

public class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") {}

    public override void Run()
    {
        ShowStartMessage();
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine(prompt);
        ShowSpinner();

        int _count = 0;
        int _elapsed = 0;

        while (_elapsed < _duration)
        {
            Console.WriteLine("Enter an item: ");
            string _item = Console.ReadLine();
            _count++;
            _elapsed += 5;
        }

        Console.WriteLine($"You listed {_count} items.");
        ShowEndMessage();
    }
}