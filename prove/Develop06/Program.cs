using System;

// I have created a save/ load option to the program

class Program
{
    static void Main(string[] args)
    {
        GoalManager _goalManager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nGoal Tracker Menu: \n");
            Console.WriteLine("1. Create New Goal \n2. Record Event \n3. View Goals \n4. View Score \n5. Save \n6. Load \n7. Exit");
            Console.WriteLine("\nPlease select your option: ");
            string input = Console.ReadLine();           

            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= 7)
            {
                switch (choice)
                {
                    case 1:
                        _goalManager.CreateGoal();
                        break;

                    case 2:
                        _goalManager.RecordEvent();
                        break;

                    case 3:
                        _goalManager.ViewGoals();
                        break;

                    case 4:
                        _goalManager.ViewScore();
                        break;
                    
                    case 5:
                        Console.Write("\nEnter File Name To Save: ");
                        string _saveFilename = Console.ReadLine();
                        if (string.IsNullOrEmpty(_saveFilename))
                        {
                            _saveFilename = "goalsData.txt";
                        }
                        _goalManager.SaveToFile(_saveFilename);
                        Console.WriteLine($"\nGoals saved as {_saveFilename}");
                        break;
                    
                    case 6:
                        Console.Write("\nEnter File Name For Saved Goals");
                        string _loadFilename = Console.ReadLine();
                        if (string.IsNullOrEmpty(_loadFilename))
                        {
                            _loadFilename = "goalsData.txt";
                        }
                        _goalManager.LoadFromFile(_loadFilename);
                        Console.WriteLine($"\nGoals Loaded from {_loadFilename}");
                        break;
                    
                    case 7:
                        running = false;
                        Console.WriteLine("Thank you for using your goal tracker! \nHave a nice day!");
                        break;
                                    
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a number between 1 and 7.");
            }
        }
    }
}