using System;

class Program
{
    /*
     * EXCEEDING REQUIREMENTS:
     * This program loads scriptures locally from a custom "scritures.txt" file
     * using a BibleLoader class. Users can type a specific reference to search 
     * for it, or type "random" to have the program select a scripture from the library.
     */
    static void Main(string[] args)
    {
        BibleLoader loader = new BibleLoader();
        Scripture scripture = null;

        while (scripture == null)
        {
            if (!Console.IsOutputRedirected)
            {
                Console.Clear();
            }

            Console.WriteLine("--- Scripture Memorizer Library ---");
            Console.WriteLine("Type a scripture reference (e.g., John 3:16) or type 'random':");
            string userChoice = Console.ReadLine()?.Trim() ?? "";

            if (string.Equals(userChoice, "random", StringComparison.OrdinalIgnoreCase))
            {
                scripture = loader.GetRandomScripture();
            }
            else
            {
                scripture = loader.GetScripture(userChoice);
            }

            if (scripture == null)
            {
                Console.WriteLine("\nScripture not found in local file. Press Enter to try again.");
                Console.ReadLine();
            }
        }

        string input = "";

        while (input != "quit" && !scripture.IsCompletelyHidden())
        {
            scripture.Display();

            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");
            input = Console.ReadLine()?.Trim().ToLower() ?? "";

            if (input != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }

        scripture.Display();
        Console.WriteLine("Program ended. Great job memorizing!");
    }
}