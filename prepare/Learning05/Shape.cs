using System.Drawing;

public abstract class Shape
{
    // Class States
    protected string _imColor;

    // Class Constructors
    public Shape(){}

    public Shape(string color)
    {
        _imColor = color;
    }

    // Class Behaviors
    public string ImGetColor()
    {
        return _imColor;
    }

    public abstract double ImGetArea();
}