public class SimpleGoal : Goal
{
    // Class States
    private bool _imIsComplete;


    // Class Constructor
    public SimpleGoal(string name, string description, int points) : base(name, description, points) 
    {
        _imIsComplete = false;
    }
    public SimpleGoal(string name, string description, string isComplete, int points) : base(name, description, points) 
    {
        if (isComplete == "true")
        {
            _imIsComplete = true;
        }
        else
        {
            _imIsComplete = false;
        }

    }

    // Class Methods
    public override string ImToString()
    {
        if (_imIsComplete)
        {
            return $"[X] {_imName} ({_imDescription})";
        }
        else
        {
            return $"[ ] {_imName} ({_imDescription})";
        }
    }
    public override string ImToCSV()
    {
        //Class type~~PointsEarned~~Name~~Description~~Completed(Bool)~~Completed(int)~~CompletedOutOf(int)~~PointValues~~BonusPointAmount
        return $"Simple~~ ~~{_imName}~~{_imDescription}~~{_imIsComplete}~~ ~~ ~~{_imPoints}~~ ";
    }
    public override int ImComplete()
    {
        _imIsComplete = true;
        return _imPoints;
    }
    public override bool ImIsComplete()
    {
        return _imIsComplete;
    }
}