public class Square : Shape
{
    // Class States
    private double _imSide;

    // Class Constructors
    public Square(){}

    public Square(string color, double side) : base(color)
    {
        _imColor = color;
        _imSide = side;
    }

    // Class Behaviors
    public override double ImGetArea()
    {
        // Finds the area of a square
        double area = _imSide * _imSide;
        return area;
    }

}