public class Word
{
    // Class States
    private string _imWord;
    private bool _imIsHidden;
    
    // Class Constructors
    public Word(string word)
    {
        _imWord = word;
    }

    // Class Methods
    public void ImHideWord()
    {
        _imIsHidden = true;
    }

    public string ImGetWord()
    {
        if(_imIsHidden)
        {
            // Returns a string of _ the same length as the word
            string underscoreWord = "";
            foreach(char letter in _imWord)
            {
                underscoreWord = underscoreWord + "_";
            }
            return underscoreWord;
            
        } 
        else {
            // Returns the word as normal
            return _imWord;
        }

        

    }

}