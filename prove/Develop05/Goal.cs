using System.Runtime.CompilerServices;

public abstract class Goal
{   
    // Class States
    protected string _imName;
    protected string _imDescription;
    protected int _imPoints;

    // Class Constructor
    public Goal(string name, string description, int points)
    {
        _imName = name;
        _imDescription = description;
        _imPoints = points;
    }

    // Class Behaviors
    public abstract string ImToString();
    public abstract string ImToCSV();
    public abstract int ImComplete();
    public abstract bool ImIsComplete();
}