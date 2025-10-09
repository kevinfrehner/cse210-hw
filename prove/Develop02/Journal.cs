using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(string text, DateTime date, string prompt = "")
    {
        Entry newEntry = new Entry(text, date, prompt);
        _entries.Add(newEntry);
    }

    public void DisplayJournal()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty.");
        }
        else
        {
            Console.WriteLine("Your Journal Entries:");
            foreach (Entry entry in _entries)
            {
                Console.WriteLine(entry.GetFullEntry());
            }
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename, true))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._prompt}|{entry._text}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length >= 3)
            {
                if (DateTime.TryParse(parts[0], out DateTime date))
                {
                    string prompt = parts[1];
                    string text = parts[2];
                    Entry entry = new Entry(text, date, prompt);
                    _entries.Add(entry);
                }
            }
            Console.WriteLine($"Loaded {_entries.Count} entries from '{filename}'.");
        }
        
    }
    



}
