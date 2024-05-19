using System;

public class Journal
{
    public string _journalTitle;
    public string _journalPrompt;
    public List<Entry> _entries = new List<Entry>();
    public Entry AddEntry(string prompt)
    {
        Entry new_entry = new Entry();
        Console.WriteLine(prompt);
        Console.Write("< ");
        new_entry._entryInput = Console.ReadLine();
        new_entry._entryDate = DateTime.Today.ToString("d");
        new_entry._entryPrompt = prompt;
        return new_entry;
    }
    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }
    public void SaveToFile(string file_name)
    {
        // This function was pretty easy for me to figure out.
        using (StreamWriter outputFile = new StreamWriter(file_name))
        {
            foreach (Entry entry in _entries)
            {
                string file_line = entry.WriteFileHelp();
                outputFile.WriteLine(file_line);
            }
        }
    }
    
    public List<Entry> LoadFromFile(string filename)
    {
        // That video about writing and reading files really saved my butt here.
        // I had no idea how to get this done.
        List<Entry> entries = new List<Entry>();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("*");
            Entry new_entry = new Entry();
            new_entry._entryDate = parts[0];
            new_entry._entryPrompt = parts[1];
            new_entry._entryInput = parts[2];
            entries.Add(new_entry);
        }
        return entries;
    }


}