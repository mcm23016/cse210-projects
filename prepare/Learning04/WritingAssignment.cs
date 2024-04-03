public class WritingAssignment : Assignment
{
    // Class States
    private string _imTitle;

    // Class Constructors
    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _imTitle = title;
    }

    // Class Methods
    public string ImGetWritingInformation()
    {
        return _imTitle + " by " + _imStudentName;
    }

}