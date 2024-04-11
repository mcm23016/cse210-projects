public class ChecklistGoal : Goal
{
    // Class States
    private bool _imIsComplete;
    private int _imComplete;
    private int _imCompleteOutOf;
    private int _imBonusPointValue;

    // Class Constructor
    public ChecklistGoal(string name, string description, int completeOutOf, int points, int bonusPoints) : base(name, description, points) 
    {
        _imIsComplete = false;
        _imComplete = 0;
        _imCompleteOutOf = completeOutOf;
        _imBonusPointValue = bonusPoints;
    }
        public ChecklistGoal(string name, string description, string isComplete, int completeOutOf, int points, int bonusPoints) : base(name, description, points) 
    {
        if (isComplete == "true")
        {
            _imIsComplete = true;
        }
        else
        {
            _imIsComplete = false;    
        }
        _imComplete = 0;
        _imCompleteOutOf = completeOutOf;
        _imBonusPointValue = bonusPoints;
    }

    // Class Methods
    public override string ImToString()
    {
        if (_imIsComplete)
        {
            return $"[X] {_imName} ({_imDescription}) -- Completed {_imComplete}/{_imCompleteOutOf} ";
        }
        else
        {
            return $"[ ] {_imName} ({_imDescription}) -- Currently completed {_imComplete}/{_imCompleteOutOf}";
        }
    }
    public override string ImToCSV()
    {
        //Class type~~PointsEarned~~Name~~Description~~Completed(Bool)~~Completed(int)~~CompletedOutOf(int)~~PointValues~~BonusPointValue
        return $"Checklist~~ ~~{_imName}~~{_imDescription}~~{_imIsComplete}~~{_imComplete}~~{_imCompleteOutOf}~~{_imPoints}~~ ";
    }
    public override int ImComplete()
    {
        // Adds to how many times it has been completed
        _imComplete ++;

        // Sees if it has been complete the specified amount of times
        // and returns a value based on that
        if (_imComplete == _imCompleteOutOf)
        {
            _imIsComplete = true;
            return _imPoints + _imBonusPointValue;
        } 
        else
        {
            return _imPoints;
        } 

    }
    public override bool ImIsComplete()
    {
        return _imIsComplete;
    }

}