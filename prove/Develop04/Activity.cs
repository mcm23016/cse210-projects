public class Activity
{
    // Class States
    protected string _imName;
    protected string _imDescription;
    protected int _imDuration;

    // Class Constructor
    public Activity(string name = "Defualt Name", string description = "Defualt Description")
    {
        
        _imName = name;
        _imDescription = description;
    }

    // Class Methods
    public void ImRun()
    {
        // Gets activity duration
        Console.Write("Set the activity duration (seconds): ");
        _imDuration = int.Parse(Console.ReadLine());

        

    }

    
}