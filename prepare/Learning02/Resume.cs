using System;

public class Resume
{
    // Variables of the Resume class
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // Method of the Resume class
    public void Display()
    {
        // Writes out the Resume to the terminal
        Console.WriteLine(_name);
        Console.WriteLine("Jobs:");
        
        foreach (var job in _jobs)
        {
            job.Display();
        }
    }

}