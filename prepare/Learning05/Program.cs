using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Assignment hw1 = new Assignment("Collin Maassen", "Triganometry");
        Console.WriteLine(hw1.GetSummary());

        MathAssignment hw2 = new MathAssignment("Ashley Peterson", "Fractions", "9.1", "1-14");
        Console.WriteLine(hw2.GetSummary());
        Console.WriteLine(hw2.GetHomeworkList());

        WritingAssignment hw3 = new WritingAssignment("Jessica Truitt", "American History", "Causes of Civil War");
        Console.WriteLine(hw3.GetSummary());
        Console.WriteLine(hw3.GetWritingInformation());


    }
}