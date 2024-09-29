public class Journal
{
    private List<Entry> entries = new List<Entry>();

    // Adds new entry to active journal
    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    // Displays all entries in active file
    public void DisplayJournal()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }

    // This allows the program to save to a specified file
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{entry.Date} ~ {entry.Prompt} ~ {entry.Response}");
            }
        }
    }

    // This will clear all entries that are in active in the p[rogram and then read in entries from a saved file using specific file names.
    public void LoadFromFile(string filename)
    {
        entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            // Iterates through the file to assign variables to each part
            string[] parts = line.Split(" ~");
            if (parts.Length == 3)
            {
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];
                entries.Add(new Entry(prompt, response, date));
            }
        }
    }
}