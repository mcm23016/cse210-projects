public class Passage
{
    // Class States
    private List<Word> _imWords = new List<Word>();
    private List<int> _imHidableWordIndexes = new List<int>();

    // Class Constructor
    public Passage(string passage)
    {
        string[] words = passage.Split(" ");
        foreach (string word in words)
        {
            _imHidableWordIndexes.Add(_imWords.Count());
            _imWords.Add(new Word(word));
        }
    }

    // Class Methods
    public int ImHideWords(int hideAmount)
    {
        /*
        The returned int essentially says if this is the last guess
        becuase all the words have been hidden.
        */


        // Random object to select random indexes
        Random random = new Random();

        // Hides as many words as the hideAmount indicates
        while(hideAmount != 0)
        {
            if (_imHidableWordIndexes.Count() != 0) 
            {
                // Creates a random index using the length of _imHidableWords
                int randomIndex = random.Next(0, _imHidableWordIndexes.Count - 1);

                // Removes the index from _imHidableWordIndexes and hides corresponding word
                int indexNumber = _imHidableWordIndexes.ElementAt(randomIndex);
                _imHidableWordIndexes.RemoveAt(randomIndex);
                _imWords.ElementAt(indexNumber).ImHideWord();

                // Reduces the amount of words to hide (to exit while loop)
                hideAmount = hideAmount - 1;

            } else {
                // Return a 0 to indicate no more words to hide
                return 0;
            }

        }

            // Check to se whether or not the _imHidableWords list is empty
            if (_imHidableWordIndexes.Count != 0)
            {
                // Not empty
                return 1;

            } else {
                // Empty
                return 0;

            }

    }

    public string ImGetPassage()
    {
        // Pulls all the words in passage and returns them
        // (Words may be hidden)
        string passage = "";
        foreach(Word word in _imWords)
        {
            passage = passage + word.ImGetWord() + " ";
        }
        return passage;

    }

}