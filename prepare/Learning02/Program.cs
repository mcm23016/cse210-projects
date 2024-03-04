using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Sad Programer";
        job1._company = "Company XYZ";
        job1._startyear = 2000;
        job1._endyear = 2010;
        
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Company XZY";
        job2._startyear = 2010;
        job2._endyear = 2020;

        Resume resume1 = new Resume();
        resume1._name = "My Name";
        resume1._jobs.Add(job1);  
        resume1._jobs.Add(job2);

        resume1.Display();

    }
}