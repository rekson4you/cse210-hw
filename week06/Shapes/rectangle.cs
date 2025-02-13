// Rectangle.cs
public class Rectangle : Shape
{
    private double _length;
    private double _width;

    // Constructor to initialize the color, length, and width
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    // Override the GetArea method to compute the area of the rectangle
    public override double GetArea()
    {
        return _length * _width;
    }
}
