using System;

public class GoalManager
{
    private List<Goals> _goals;
    private int _totalScore;

    public GoalManager()
        {
            _goals = new List<Goals>();
            _totalScore = 0;
        }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_totalScore);
            foreach (Goals goal in _goals)
            {
                writer.WriteLine($"{goal.GetType().Name} ~ {goal.GetName()} ~ {goal.GetDescription()} ~ {goal.GetPoints()} ~ {goal.IsCompleted}");
            }
        }
        Console.WriteLine("\nGoal Progress Saved.");
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            _goals.Clear();
            string[] lines = File.ReadAllLines(filename);

            if (lines.Length > 0 && int.TryParse(lines[0], out int totalScore))
            {
                _totalScore = totalScore;
            }

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(" ~ ");
                if (parts.Length >= 5)
                {
                    string goalType = parts[0];
                    string goalName = parts[1];
                    string goalDescription = parts[2];
                    // int points = int.Parse(parts[3]);
                    // bool isCompleted = bool.Parse(parts[4]);

                    if (int.TryParse(parts[3], out int points) && bool.TryParse(parts[4], out bool isCompleted))
                    {
                        Goals goal = null;
                        switch (goalType)
                        {
                            case nameof(SimpleGoal):
                                goal = new SimpleGoal(goalName, goalDescription, points);
                                break;
                            case nameof(EternalGoal):
                                goal = new EternalGoal(goalName, goalDescription, points);
                                break;
                            case nameof(ChecklistGoal):
                                if(parts.Length >= 7 && int.TryParse(parts[5], out int targetCount) && int.TryParse(parts[6], out int bonusPoints))
                                {
                                    goal = new ChecklistGoal(goalName, goalDescription, points, targetCount, bonusPoints);
                                }
                                break;
                            default:
                            Console.WriteLine($"\nUnknown Goal Type: {goalType}");
                            break;
                        }
                        if (goal != null)
                        {
                            goal.IsCompleted = isCompleted;
                            _goals.Add(goal);
                        }
                        else
                        {
                            Console.WriteLine($"Failed To Create Goal On Line {i + 1}");
                        }
                    }
                }
            }
            Console.WriteLine("\nGoal Progress Loaded");
        }
        else
        {
            Console.WriteLine("\nFile Not Found");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nSelect Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        if (int.TryParse(Console.ReadLine(), out int _goalType))
        {
            Goals _newGoal = null;
            Console.WriteLine("\nEnter Goal Name: ");
            string _goalname = Console.ReadLine();
            Console.WriteLine("\nEnter Goal Description: ");
            string _goalDescription = Console.ReadLine();
            Console.WriteLine("\nEnter Points For The Goal: ");

            if (int.TryParse(Console.ReadLine(), out int _points))
            {
                switch (_goalType)
                {
                    case 1:
                        _newGoal = new SimpleGoal(_goalname, _goalDescription, _points);
                        break;
                    case 2:
                        _newGoal = new EternalGoal(_goalname, _goalDescription, _points);
                        break;
                    case 3:
                        Console.WriteLine("\nEnter Target Count For Goal: ");
                        int _targetCount = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nEnter Bonus Point For Achieving Target Goal: ");
                        int _bonusPoints = int.Parse(Console.ReadLine());
                        _newGoal = new ChecklistGoal(_goalname, _goalDescription, _points, _targetCount, _bonusPoints);
                        break;
                    default:
                    Console.WriteLine("\nInvalid Goal Option");
                    return;
                }
                _goals.Add(_newGoal);
                Console.WriteLine("\nGoal Created!");
            }
            else
            {
                Console.WriteLine("Invalid Input For Goal Points. \nPlease Select A Valid Number: ");
            }
        }
        else
        {
            Console.WriteLine("\nInvalid Input. \nPlease Enter A Number: ");
        }
    }
    
    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("\nNo Goals Available At This Time.");
            return;
        }

        Console.WriteLine("\nSelect A Goal To Record An Event: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"\n{i + 1}: {_goals[i].DisplayStatus()}");
        }

        if (int.TryParse(Console.ReadLine(), out int _goalIndex) && _goalIndex > 0 && _goalIndex <= _goals.Count)
        {
            _goals[_goalIndex - 1].RecordEvent();
            _totalScore += _goals[_goalIndex - 1].GetPoints();
        }
        else
        {
            Console.WriteLine("Invalid Goal Number.");
        }
    }

    public void ViewGoals()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("\nNo Goals Available At The Moment.");
                return;
            }

            Console.WriteLine("\nGoals: ");
            foreach (Goals goal in _goals)
            {
                Console.WriteLine(goal.DisplayStatus());
            }
        }
    
    public void ViewScore()
    {
        Console.WriteLine($"\nTotal Score: {_totalScore}");
    }
}