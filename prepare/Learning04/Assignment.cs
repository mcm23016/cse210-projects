public class Assignment
{
    // Class states
    protected string _imStudentName;
    private string _imTopic;

    // Class Constructors
    public Assignment(string name, string topic)
    {
        _imStudentName = name;
        _imTopic = topic;
    }

    // Class Methods 
    public string ImGetSummary()
    {
        return _imStudentName + " - " + _imTopic;
    }
}