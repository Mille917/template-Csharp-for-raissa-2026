using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain == "yes")
        {
            //Generate random number from 1 to 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int guessCount = 0;

            // Main game loop
            Console.WriteLine("I'm thinking of a number between 1 and 100.");
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess > magicNumber)
                {
                    Console.WriteLine("Your guess is too high.");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Your guess is too low.");
                }
                else
                {
                    Console.WriteLine("Congratulations! You guessed the magic number.");
                }
            }

            Console.WriteLine($"It took you {guessCount} guesses to find the magic number.");

            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();

            Console.WriteLine(); // Add a blank line for better readability
        }

        if (playAgain == "no")
        {
            Console.WriteLine("Thank you for playing!");
        }
        else if (playAgain != "yes")
        {
            Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
        }
    }
}