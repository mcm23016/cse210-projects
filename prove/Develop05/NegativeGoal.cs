public class NegativeGoal : Goal
{
    // Class States
    // None

    // Class Constructor
    public NegativeGoal(string name, string description, int points) : base(name, description, points) {}

    // Class Methods
    public override string ImToString()
    {
        return $"[ ] {_imName} ({_imDescription})";
    }
    public override string ImToCSV()
    {
        //Class type~~PointsEarned~~Name~~Description~~Completed(Bool)~~Completed(int)~~CompletedOutOf(int)~~PointValues~~BonusPointValue
        return $"Negative~~ ~~{_imName}~~{_imDescription}~~ ~~ ~~ ~~{_imPoints}~~ ";
    }
    public override int ImComplete()
    {
        return _imPoints;
    }
    public override bool ImIsComplete()
    {
        //It is never complete
        return false;
    }
}