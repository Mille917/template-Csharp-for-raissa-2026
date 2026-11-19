using System;
using System.IO;
using System.Collections.Generic;

public class BibleLoader
{
    private readonly string _filePath = Path.Combine(AppContext.BaseDirectory, "scritures.txt");

    public Scripture GetScripture(string referenceText)
    {
        if (string.IsNullOrWhiteSpace(referenceText) || !File.Exists(_filePath))
        {
            return null;
        }

        string[] lines = File.ReadAllLines(_filePath);
        foreach (string line in lines)
        {
            if (TryParseScripture(line, out Scripture scripture, out string storedReference) &&
                string.Equals(storedReference, referenceText.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                return scripture;
            }
        }

        return null;
    }

    public Scripture GetRandomScripture()
    {
        if (!File.Exists(_filePath))
        {
            return null;
        }

        List<Scripture> scriptures = new List<Scripture>();
        foreach (string line in File.ReadAllLines(_filePath))
        {
            if (TryParseScripture(line, out Scripture scripture, out _))
            {
                scriptures.Add(scripture);
            }
        }

        return scriptures.Count == 0 ? null : scriptures[Random.Shared.Next(scriptures.Count)];
    }

    private bool TryParseScripture(string line, out Scripture scripture, out string referenceText)
    {
        scripture = null;
        referenceText = string.Empty;
        int separator = line.IndexOf('|');
        if (separator <= 0)
        {
            return false;
        }

        referenceText = line.Substring(0, separator).Trim();
        string text = line.Substring(separator + 1).Trim();
        if (string.IsNullOrWhiteSpace(text) || !TryParseReference(referenceText, out Reference reference))
        {
            return false;
        }

        scripture = new Scripture(reference, text);
        return true;
    }

    private bool TryParseReference(string fullReference, out Reference reference)
    {
        reference = null;
        int lastSpace = fullReference.LastIndexOf(' ');
        if (lastSpace <= 0)
        {
            return false;
        }

        string book = fullReference.Substring(0, lastSpace).Trim();
        string chapterAndVerse = fullReference.Substring(lastSpace + 1);
        string[] parts = chapterAndVerse.Split(':');
        if (string.IsNullOrWhiteSpace(book) || parts.Length != 2 ||
            !int.TryParse(parts[0], out int chapter) || chapter <= 0)
        {
            return false;
        }

        if (parts[1].Contains('-'))
        {
            string[] verses = parts[1].Split('-');
            if (verses.Length != 2 ||
                !int.TryParse(verses[0], out int startVerse) ||
                !int.TryParse(verses[1], out int endVerse) ||
                startVerse <= 0 || endVerse < startVerse)
            {
                return false;
            }

            reference = new Reference(book, chapter, startVerse, endVerse);
            return true;
        }

        if (!int.TryParse(parts[1], out int verse) || verse <= 0)
        {
            return false;
        }

        reference = new Reference(book, chapter, verse);
        return true;
    }
}
