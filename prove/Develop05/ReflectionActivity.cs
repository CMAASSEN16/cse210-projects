using System;

public class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times when you have shown strength and perserverence.") {}

    public override void Run()
    {
        ShowStartMessage();
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine(prompt);
        ShowSpinner(3);
        
        int _elapsed = 0;
        while (_elapsed < _duration)
        {
            string question = questions[random.Next(questions.Count)];
            Console.WriteLine(question);
            ShowSpinner(5);
            _elapsed += 5;
        }
        ShowEndMessage();
    }
}