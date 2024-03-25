public class Rectangle : Shape
{
    // Class States
    private double _imSideOne;
    private double _imSideTwo;

    // Class Constructors
    public Rectangle(){}

    public Rectangle(string color, double sideOne, double sideTwo) : base(color)
    {
        _imColor = color;
        _imSideOne = sideOne;
        _imSideTwo = sideTwo;
    }

    // Class Behaviors
    public override double ImGetArea()
    {
        // Finds the area of a rectangle
        double area = _imSideOne * _imSideTwo;
        return area;
    }

}