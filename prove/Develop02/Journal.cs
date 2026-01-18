using System;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> Entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        Entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in Entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        List<string> lines = new List<string>();
        foreach (Entry entry in Entries)
        {
            lines.Add($"{entry.Date} | {entry.Category} | {entry.Prompt} | {entry.Response}");
        }

        File.WriteAllLines(filename, lines);
        Console.WriteLine("Journal entry saved");
    }

    public void LoadFromFile(string filename)
    {

        string[] lines = File.ReadAllLines(filename);
        Entries.Clear();
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            if (parts.Length == 4)
            {
                string date = parts[0];
                string category = parts[1];
                string prompt = parts[2];
                string response = parts[3];
                Entry entry = new Entry(date, prompt, response, category);
                Entries.Add(entry);
            }
        }
        Console.WriteLine("Loaded journal entry");
    }


}
