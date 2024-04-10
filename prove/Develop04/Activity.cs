public abstract class Activity
{
    // Class States
    protected string _imName;
    protected string _imDescription;
    protected int _imDuration;
    protected List<string> _imAnimations = new List<string>();
    protected DateTime _imCurrentTime;
    protected DateTime _imEndTime;

    // Class Constructor
    public Activity(int duration, string name = "Defualt Name", string description = "Defualt Description")
    {
        _imDuration = duration;
        _imName = name;
        _imDescription = description;
        _imAnimations.Add("|");
        _imAnimations.Add("/");
        _imAnimations.Add("-");
        _imAnimations.Add("\\");

    }

    // Class Methods
    public void ImRun()
    {
        ImBegining();
        ImMiddle();
        ImEnding();
    }

    public void ImBegining()
    {
        //Wirte Activity name and Discription
        Console.Clear();
        Console.WriteLine($"Welcome to the {_imName} Activity\n");
        Console.WriteLine($"{_imDescription}\n");
        Console.Write("Press enter to continue: ");
        Console.ReadLine();
        Console.Clear();
    }

    public abstract void ImMiddle();
    
    public void ImEnding()
    {
        Console.WriteLine("Well Done!!");
        Console.WriteLine($"You completed another {_imDuration} seconds of {_imName} activity!\n");
        
    }

    public void ImAnimation(int length)
    {
        while (length > 0)
        {
            foreach(String animation in _imAnimations)
            {
                Console.Write(animation);
                Thread.Sleep(100);
                Console.Write("\b");
            }
            length --;
        }
        Console.Write(" \n");
    }

    public void ImTimer(int length)
    {
        while (length > 0)
        {
            Console.Write(length);
            Thread.Sleep(1000);
            Console.Write("\b");
            length --;
        }

    }

    public void ImGetEndTime()
    {
        _imCurrentTime = DateTime.Now;
        _imEndTime = _imCurrentTime.AddSeconds(_imDuration);

    }

    public bool ImCheckTime()
    {
        _imCurrentTime = DateTime.Now;

        if (_imCurrentTime < _imEndTime)
        {
            return true;
        } else {
            return false;
        }


    }    
}