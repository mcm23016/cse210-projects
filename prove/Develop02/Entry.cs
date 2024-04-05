public class Entry
{
    // Class States
    private string _imPrompt;
    private string _imDate; 
    private string _imResponse;
    private string _imDailyRating;

    // Class Cunstructors
    public Entry(string date, string prompt, string response, string dailyRating)
    {
        _imDate = date;
        _imPrompt = prompt;
        _imResponse = response;
        _imDailyRating = dailyRating;
    }

    // Class Methods 
    public string ImToString()
    {
        return $"Date: {_imDate} - Prompt: {_imPrompt}\n{_imResponse}\nYou rated the day as an overal {_imDailyRating}/10.\n";
    }
    public string ImToCSV()
    {
        return $"{_imDate}~~{_imPrompt}~~{_imResponse}~~{_imDailyRating}"; 
    }

}