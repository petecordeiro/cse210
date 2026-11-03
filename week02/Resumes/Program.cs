using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2029;
        job1._endYear = 2032;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2029;
        job2._endYear = 2032;

        Resume resume = new Resume();
        resume._name = "Peterson Cordeiro";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        
        resume.Display();

    }
}