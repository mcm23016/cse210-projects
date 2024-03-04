using System;

public class Job
{
    // Variables of a Job class.
    public string _jobTitle;
    public string _company; 
    public int _startyear;
    public int _endyear;

/*
    This is something the teacher suggested using is return the data as a string 
    and go from there instead of displaying straight frim the class itself.

    public string toString()
    {
        // Making the variables of a job into one string and returns it.
        string jobString = _jobTitle + "(" + _company + ")" + _startyear + "-" + _endyear;
        return jobString;   
    }   
*/

    public void Display()
    {
        // Displays the the variables of a job through one string
        Console.WriteLine($"{_jobTitle} ({_company}) {_startyear}-{_endyear}");
    }
}