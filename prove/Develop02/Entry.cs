public class Entry
{
    // Class States
    public string _imPrompt;
    public string _imDate; 
    public string _imResponse;

    // Class Methods 
    public string toString()
    {
        string imEntryString = $"Date: {_imDate} - Prompt: {_imPrompt}\n{_imResponse}\n";
        return imEntryString;
    }
    public string toCSV()
    {
        string imEntryString = $"{_imDate}~~{_imPrompt}~~{_imResponse}";
        return imEntryString;
    }
    public void fromCSV(string _imCsvLine)
    {
        string[] imCsvLineParts = _imCsvLine.Split("~~");
        _imDate = imCsvLineParts[0];
        _imPrompt = imCsvLineParts[1];
        _imResponse = imCsvLineParts[2];
    }
}