using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        //Split the scripture text by spaces and create a Word object for each word
        string[] wordArray = text.Split(' ');
        foreach (string wordText in wordArray)
        {
            Word newWord = new Word(wordText);
            _words.Add(newWord);
        }
    }
    public void Display()
    {
        if (!Console.IsOutputRedirected)
        {
            Console.Clear();
        }

        Console.Write($"{_reference.GetDisplayText()} => ");
        foreach (Word word in _words)
        {
            Console.Write($"{word.GetDisplayText()} ");
        }
        Console.WriteLine("\n");
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        // Keep picking random words until we've hidden the desired amount
        // or until all words are already hidden.
        while (hiddenCount < numberToHide && !IsCompletelyHidden())
        {
            int index = random.Next(_words.Count);
            // If the word isn't hidden yet, hide it
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false; // Found at least one visible word
            }
        }
        return true; //All words are hidden
    }
}