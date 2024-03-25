public class Circle : Shape
{
    // Class States
    private double _imRadius;

    // Class Constructors
    public Circle(){}

    public Circle(string color, double radius) : base(color)
    {
        _imColor = color;
        _imRadius = radius;
    }

    // Class Behaviors
    public override double ImGetArea()
    {
        // Finds the area of a circle
        double area = _imRadius * _imRadius * Math.PI;
        //Source used for Math.PI ^^ https://learn.microsoft.com/en-us/dotnet/api/system.math.pi?view=net-8.0 
        return area;
    }

}