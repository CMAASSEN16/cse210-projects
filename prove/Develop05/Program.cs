using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("Mindfulness Activities");
            Console.WriteLine("1: Breathing Activity");
            Console.WriteLine("2: Reflection Activity");
            Console.WriteLine("3: Listing Activity");
            Console.WriteLine("4: Exit");

            Console.WriteLine("\nChoose an Activity or Exit:");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;

                case 2:
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Run();
                    break;

                case 3:
                    running = false;
                    Console.WriteLine("Thank you for practicing your mindfulness today!");
                    Console.WriteLine("Goodbye!");
                    break;
                
                default:
                    Console.WriteLine("Option not available. Please try again.");
                    break;
            }
        }
        
    }
}