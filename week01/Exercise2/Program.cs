using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade percentage: ");
        int percentage = int.Parse(Console.ReadLine());

        if (percentage >= 90)
        {
            Console.WriteLine("Your grade is A");
        }
        else if (percentage >= 80)
        {
            Console.WriteLine("Your grade is B");
        }
        else if (percentage >= 70)
        {
            Console.WriteLine("Your grade is C");
        }
        else if (percentage >= 60)
        {
            Console.WriteLine("Your grade is D");
        }
        else
        {
            Console.WriteLine("Your grade is F");
        }

        //Show the grade letter
        string letter = "";
        if (percentage >= 90)
        {
            letter = "A";

        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        //Sign the grade with a + or - based on the percentage
        string sign = "";
        int lastDigit = percentage % 10;
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit <= 3)
        {
            sign = "-";
        }
        //Handle A+ exception
        if (letter == "A" && sign == "+")
        {
            sign = "";
        }

        //Handle F- exception (F+ or F-)
        if (letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your full grade is: {letter}{sign}");

        //Pass if the grade is B or Higher
        if (percentage >= 80)
        {
            Console.WriteLine("Congratulations! You passed the course. ");
        }
        else
        {
            Console.WriteLine("Don't give up! You will do better next time.");
        }


    }
}