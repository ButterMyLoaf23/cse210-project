using System;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        List<string> lines = new List<string>();
        foreach (Entry entry in _entries)
        {
            lines.Add($"{entry._date} | {entry._category} | {entry._prompt} | {entry._response}");
        }

        File.WriteAllLines(filename, lines);
        Console.WriteLine("Journal entry saved");
    }

    public void LoadFromFile(string filename)
    {
        
        string[] lines = File.ReadAllLines(filename);
        _entries.Clear();
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
                _entries.Add(entry);
            }
        }
        Console.WriteLine("Loaded journal entry");
    }


}
