using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string user_grade = Console.ReadLine();
        int percent = int.Parse(user_grade);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        
        else if (percent >= 80)
        {
            letter = "B";
        }
        
        else if (percent >= 70)
        {
            letter = "C";
        }
        
        else if (percent >= 60)
        {
            letter = "D";
        }
        
        else
        {
            letter = "F";
        }

        // This allows the program to find last digit
        int last_digit = percent % 10;

        if (letter != "F")
        {
            // This allows program to only produce A and A-
            if (letter == "A" && last_digit <= 2)
            {
                letter += "-";
            }
            else if (letter != "A")
            {
                // This portion determines if Letter grade gets a + or -
                if (last_digit >= 7)
                {
                    letter += "+";
                }
                else if (last_digit <= 2)
                {
                    letter += "-";
                }
            }
        }

        // This portion prints the results of the code
        Console.WriteLine($"Your Grade letter is an: {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time.");
        }
    }
}