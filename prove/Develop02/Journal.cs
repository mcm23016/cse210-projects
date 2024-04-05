public class Journal
{
    // Class States
    private List<Entry> _imEntries = new List<Entry>();

    // Class Methods
    public string ImToString()
    {
        // Creates string to hold entries
        string journalString = "";

        // Adds each entry to the string
        foreach(Entry entry in _imEntries)
        {
            journalString = journalString + entry.ImToString() + "\n"; 
        }
        
        // Returns final string
        return journalString;

    }
    public string ImToCSV()
    {
        // Creates string to hold entries
        string journalString = "";

        // Adds each entry to the string
        foreach(Entry entry in _imEntries)
        {
            journalString = journalString + entry.ImToCSV() + "\n"; 
        }
        
        // Returns final string
        return journalString;
        
    }

    public void ImNewEntry(string date, string prompt, string response, string dailyRating)
    {
        _imEntries.Add(new Entry(date, prompt, response, dailyRating));
    }
}