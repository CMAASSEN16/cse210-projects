using System;

public class MathAssignment : Assignment
{
    private string _bookSection;
    private string _questions;

    public MathAssignment(string studentName, string topic, string bookSection, string questions) : base(studentName, topic)
    {
        _bookSection = bookSection;
        _questions = questions;
    }

    public string GetHomeworkList()
    {
        return $"Section: {_bookSection} | Questions {_questions}";
    }
}