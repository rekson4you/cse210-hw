// Derived class EternalGoal
public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
    }

    // Override to record an event
    public override int RecordEvent()
    {
        return _points; // Points awarded each time
    }

    // Override to check if the goal is complete (always false)
    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }

    // Override to get the string representation of the goal
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}
