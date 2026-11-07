using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        // Compute the sum
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        // Compute the average (cast to double for decimal precision)
        double average = numbers.Count > 0 ? (double)sum / numbers.Count : 0;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");

        //Find the largest number
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"The Largest number is: {max}");

        //Find the smallest number
        int smallestPositive = int.MaxValue;
        foreach (int num in numbers)
        {
            if (num > 0 && num < smallestPositive)
            {
                smallestPositive = num;
            }
        }

        //Only display if a positive number was actually entered
        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        //Sorting and displaying the list
        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}