using System;

public class Word
{
    // Assigning variables tracking word hidden 
    private string _text;
    private bool _isHidden;

    // Initializes the word as not hidden
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // method to hide word
    public void Hide()
    {
        _isHidden = true;
    }

    // Checks if word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Method for display of "____" for hidden words
    public string GetDisplayText()
    {
        return _isHidden ? "____" : _text;
    }
}