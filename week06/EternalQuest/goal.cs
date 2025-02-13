using System;

// Base class Goal
public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    // Method to record an event (abstract, must be overridden)
    public abstract int RecordEvent();

    // Method to check if the goal is complete (abstract, must be overridden)
    public abstract bool IsComplete();

    // Method to get the details of the goal
    public virtual string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName} - {_description}";
    }

    // Method to get a string representation of the goal (abstract, must be overridden)
    public abstract string GetStringRepresentation();

    // Method to get the points of the goal
    public int GetPoints()
    {
        return _points;
    }
}
