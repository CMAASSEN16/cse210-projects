using System;
public class Scripture
{
    // Identifying variables and pulling from classes
    private Reference _reference;
    private List<Word> _words;

    // Constructor to build scripture and break text into individual word objects
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(wordText => new Word(wordText)).ToList();
    }

    // This is the method that hides random words filtering out what is already hidden as it iterates through program
    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        var wordsToHide = _words.Where(word => !word.IsHidden()).ToList();

        for (int i = 0; i < numberToHide && wordsToHide.Count > 0; i++)
        {
            int index = rand.Next(wordsToHide.Count);
            wordsToHide[index].Hide();
            wordsToHide.RemoveAt(index);
        }        
    }

    // Method to replace hidden words with "____"
    public string GetDisplayText()
    {
        string wordsText = string.Join(" ", _words.Select(Word => Word.GetDisplayText()));
        return $"{_reference.GetDisplayText()}\n{wordsText}";
    }

    // Checks to see if words are all hidden and if so provides info to program to print congrats message
    public bool IsCompletelyHidden()
    {
        return _words.All(Word => Word.IsHidden());
    }
}
