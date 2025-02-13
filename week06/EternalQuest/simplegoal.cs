// Derived class SimpleGoal
public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
        _isComplete = false;
    }

    // Override to record an event
    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }

    // Override to check if the goal is complete
    public override bool IsComplete()
    {
        return _isComplete;
    }

    // Method to set the goal as complete
    public void SetComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }

    // Override to get the string representation of the goal
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }
}
