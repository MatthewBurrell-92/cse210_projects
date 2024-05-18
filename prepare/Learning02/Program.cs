using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Paramedic";
        job1._company = "Madison Fire Department";
        job1._startYear = "2023";
        job1._endYear = "2025";
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Anywhere";
        job2._startYear = "Eventually";
        job2._endYear = "NEVER!!!";
        job2.Display();

        Resume resume1 = new Resume();
        resume1._name = "Matthew Burrell";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();

        // Console.WriteLine(job1._company);
    }
}