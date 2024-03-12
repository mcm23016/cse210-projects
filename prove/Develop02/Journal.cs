public class Journal
{
    // Class States
    public List<Entry> _entries = new List<Entry>();

    // Class Methods
    public string toString()
    {
        /*
        Returns a string[] of all the string entries in journal
            Parameters: None
            Returns: string[]
        */
        string journalString = "";
        return journalString;
    }
    public string toCSV()
    {
        /*
        Returns a string of all the string entries in journal
            Parameters: None
            Returns: string
        */
        string journalString = "";
        return journalString;
    }
    public void fromCSV(/*temp variable array of strings*/ string[] lines)
    {
        foreach (string line in lines)
        {
            //Entry.fromCSV(line)
        }
    }
}