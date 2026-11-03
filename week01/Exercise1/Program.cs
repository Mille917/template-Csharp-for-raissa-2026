using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        Console.Write("What is your first name?: ");
        string firstName = Console.ReadLine();

        Console.Write("What is your Last name?: ");
        string LastName = Console.ReadLine();

        Console.WriteLine($"Hello, your name is {LastName}, {firstName} {LastName}.");

    }
}