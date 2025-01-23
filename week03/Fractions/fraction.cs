using System;
public class Fraction
{
    private int _top;
    private int _bottom;

    // Constructor with no parameters, initializes to 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor with one parameter, initializes to numerator/1
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Constructor with two parameters
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter for _top
    public int GetTop()
    {
        return _top;
    }

    // Setter for _top
    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter for _bottom
    public int GetBottom()
    {
        return _bottom;
    }

    // Setter for _bottom
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Method to return the fraction in the form "top/bottom"
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Method to return the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
