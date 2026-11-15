using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    // A list to store multiple Entry objects
    public List<Entry> _entries = new List<Entry>();

    // Add a new entry to the list
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Display all entries in the journal
    public void DisplayJournal()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Your journal is currently empty.\n");
            return;
        }
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    // Save the journal to a file using a custom separator
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry.Date}~|~{entry.PromptText}~|~{entry.EntryText}");
            }
        }
        Console.WriteLine("Journal saved successfully! \n");
    }

    // Load the journal from a file, replacing current entries.

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found. \n");
            return;
        }

        // Clear existing entries before loading
        _entries.Clear();

    string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");
            if (parts.Length == 3)
            {
                Entry entry = new Entry();
                entry.Date = parts[0];
                entry.PromptText = parts[1];
                entry.EntryText = parts[2];
                _entries.Add(entry);
            }
        }
        Console.WriteLine("Journal loaded successfully! \n");
    }
}