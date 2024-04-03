public class MathAssignment : Assignment
{
    // Class States
    private string _imTextBookSection;
    private string _imProblems;

    // Class Constructors
    public MathAssignment(string name, string topic, string textBookSection, string problems) : base(name, topic)
    {
        _imTextBookSection = textBookSection;
        _imProblems = problems;
        
    }

    // Class Methods
    public string ImGetHomeworkList()
    {
        return "Section " + _imTextBookSection + " Problems " + _imProblems;
    }

}