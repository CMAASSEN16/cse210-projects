using System;

class Program
{
    static void Main(string[] args)
    {
        // This creates and stores all journal entries
        Journal journal = new Journal();

        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "If you could have seen one person today who would it be and why?",
            "Were you able to do any service today?",
            "If you could live in a video game which world would you choose and why?",
            "What would you do or think if the world was like Mario's from the Mario movie?"
        };

        string userChoice = "";
        

        // Main loop for the progam, runs until user enters 5
        while (userChoice != "5")
        {
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display entries");
            Console.WriteLine("3. Save your journal to a file.");
            Console.WriteLine("4. Load your journal from a file.");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Please select your option: ");
            userChoice = Console.ReadLine();
            // Allows User to choose between options

            // This part pulls information from Entry file to create new entry from user input
            if ( userChoice == "1")
            {
                Random random = new Random();
                string prompt = prompts[random.Next(prompts.Count)];
                Console.WriteLine(prompt);

                Console.WriteLine("Enter your response: ");
                string response = Console.ReadLine();

                string date = DateTime.Now.ToShortDateString();

                Entry newEntry = new Entry(prompt, response, date);
                journal.AddEntry(newEntry);
                Console.WriteLine("Entry added successfully.");
            }

            // Displays all entries in current file using information from Journal
            else if (userChoice == "2")
            {
                Console.WriteLine("Displaying current file entries.");
                journal.DisplayJournal();
            }

            // Saves all entries in current file using information from Journal
            else if (userChoice == "3")
            {
                Console.WriteLine("Enter the filename to save your journal: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }

            // Loads file from saved source using user input 
            else if (userChoice == "4")
            {
                Console.WriteLine("Enter your journal's filename to load it: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
        }

    }
}