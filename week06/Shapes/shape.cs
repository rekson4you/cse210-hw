// Shape.cs
public abstract class Shape
{
    // Color of the shape
    public string Color { get; set; }

    // Constructor to initialize the color
    public Shape(string color)
    {
        Color = color;
    }

    // Abstract method to get the area (must be overridden in derived classes)
    public abstract double GetArea();
}
