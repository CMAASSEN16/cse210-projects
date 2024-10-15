using System;
using System.Collections.Generic;

public class Comment
{
    // Variables set to store name and text of the comments
    public string Name {get; set;}
    public string Text {get; set;}

    // Constructor that set values with each new comment
    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}