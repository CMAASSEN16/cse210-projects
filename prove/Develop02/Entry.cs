public class Entry
{
    // This gets the information from user & program stores it
    public string Prompt {get; set;}
    public string Response {get; set;}
    public string Date { get; set;}

    // This defines the structure and parameters of entry
    public Entry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    // Formats how the display will look when entries are recalled and entered from the user
    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine();

    }
}