using System;

// Extras are multiple style timers, count of activity in session, loop to keep accidental inputs from breaking program.
class Program
{
    static int breathingCount = 0;
    static int reflectionCount = 0;
    static int listingCount = 0;
    static int activitySum = 0;

    static void Main(string[] args)
    {
        bool running = true;

        Console.WriteLine("Welcome To The Mindfullness App\n");

        while (running)
        {
            Console.WriteLine("Mindfulness Activities");
            Console.WriteLine("1: Breathing Activity");
            Console.WriteLine("2: Reflection Activity");
            Console.WriteLine("3: Listing Activity");
            Console.WriteLine("4: View Activity Log");
            Console.WriteLine("5: Exit");

            int choice;
            while (true)
            {
                Console.WriteLine("\nChoose an Activity or Exit:");

                string input = Console.ReadLine();
                if (int.TryParse(input, out choice))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a number between 1 and 5.");
                }
            }

            switch (choice)
            {
                case 1:
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    breathingCount++;
                    break;

                case 2:
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Run();
                    reflectionCount++;
                    break;

                case 3:
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    listingCount++;
                    break;
                
                case 4:
                    DisplayActivityLog();
                    break;

                case 5:
                    running = false;
                    Console.WriteLine("\nThank you for practicing your mindfulness today!");
                    Console.WriteLine("\nGoodbye!");
                    break;
                
                default:
                    Console.WriteLine("Option not available. Please try again.");
                    break;
            }
        }
        
    }
static void DisplayActivityLog()
{
    activitySum = breathingCount + reflectionCount + listingCount; 
    Console.WriteLine("Activity Log:\n");
    Console.WriteLine($"Breathing Activity: {breathingCount}");
    Console.WriteLine($"Reflection Activity: {reflectionCount}");
    Console.WriteLine($"Listing Activity: {listingCount}");
    Console.WriteLine($"A total of {activitySum}. \nGreat Job!\n");       
}
}