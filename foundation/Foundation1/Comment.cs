using System;
using System.Collections.Generic;

public class Comment
{
    public string Name {get;}
    public string Text {get;}

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}