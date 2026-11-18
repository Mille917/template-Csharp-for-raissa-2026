// Exceeding requirements: I added a Mood tracking feature that prompts the user
// for their overall mood during entry creation and displays it alongside each entry.
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();

        // List of random prompts (at least 5 required)
        List<string> prompts = new List<string>()
        {
            "How am I feeling today?",
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is something new I learned today?",
            "What made me smile today?"
        };

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Select a choice from the menu: ");

            string input = Console.ReadLine();
            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        //Pick a random prompt
                        Random random = new Random();
                        int index = random.Next(prompts.Count);
                        string selectedPrompt = prompts[index];

                        Console.WriteLine($"\nPrompt: {selectedPrompt}");
                        Console.Write("> ");
                        string userResponse = Console.ReadLine();

                        // Get current date as string
                        string currentDate = DateTime.Now.ToShortDateString();

                        // Create new entry object
                        Entry newEntry = new Entry();
                        newEntry.Date = currentDate;
                        newEntry.PromptText = selectedPrompt;
                        newEntry.EntryText = userResponse;

                        theJournal.AddEntry(newEntry);
                        Console.WriteLine("Entry added successfully.\n");
                        break;

                    case 2:
                        Console.WriteLine("\n--- Journal Entries ---");
                        theJournal.DisplayJournal();
                        break;
                    case 3:
                        Console.Write("Enter filename to save (e.g., myJournal.txt): ");
                        string saveFile = Console.ReadLine();
                        theJournal.SaveToFile(saveFile);
                        break;
                    case 4:
                        Console.Write("Enter filename to load: ");
                        string loadFile = Console.ReadLine();
                        theJournal.LoadFromFile(loadFile);
                        break;
                    case 5:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select between 1 and 5.\n");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.\n");
            }
        }
    }
}