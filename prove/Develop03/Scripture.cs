public class Scripture
{
    // Class States
    Refrence _imRefrence;
    Passage _imPassage;

    // Class Constructors
    public Scripture(string refrence, string passage)
    {
        _imRefrence = new Refrence(refrence);
        _imPassage = new Passage(passage);
    }

    // Class Methods
    public int ImHideWords(int hideAmount)
    {
        int isDone = _imPassage.ImHideWords(hideAmount);
        return isDone; // 0 == Done, 1 == Not done
    }

    public string ImGetCurrentString()
    {
        return $"{_imRefrence.ImGetRefrence()} {_imPassage.ImGetPassage()}";
    }

}