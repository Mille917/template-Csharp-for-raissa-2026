using System;

class Program
{
    static void Main(string[] args)
    {
        //create job 1
        Job job1 = new Job();
        job1. _jobTitle = "Software Engineer";
        job1. _company = "Microsoft";
        job1. _startYear = 2019;
        job1. _endYear = 2022;

        //create job 2
        Job job2 = new Job();
        job2. _jobTitle = "Web Developer";
        job2. _company = "Google";
        job2. _startYear = 2022;
        job2. _endYear = 2024;

        // Verify you can access member variables directly
        console.WriteLine(job1._company);
        console.WriteLine(job2._company);
    }
}