using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1.jobTitle = "Software Engineering";
        job1.company = "Microsoft";
        job1.startYear = 2019;
        job1.endYear = 2022;

        Job job2 = new Job();
        job2.jobTitle = "Manager";
        job2.company = "Apple";
        job2.startYear = 2022;
        job2.endYear = 2024;

        Resume myResume = new Resume();
        myResume.name = "Allison Rose";

        myResume.jobs.Add(job1);
        myResume.jobs.Add(job2);

        myResume.Display();
    }
}