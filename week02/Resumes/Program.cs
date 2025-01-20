using System;

class Program
{
    static void Main(string[] args)
    {
        var job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Google";
        job1._startYear = 2015;
        job1._endYear = 2018;

        var job2 = new Job();
        job2._jobTitle = "Software Developer";
        job2._company = "Microsoft";
        job2._startYear = 2018;
        job2._endYear = 2020;

        var resume = new Resume();
        resume._name = "Lehi Gomez";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        
        resume.Display();

    }
}