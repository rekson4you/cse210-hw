// Derived class ChecklistGoal
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus)
        : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    // Override to record an event
    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Bonus: {_bonus} points!");
            return _points + _bonus;
        }
        return _points;
    }

    // Override to check if the goal is complete
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    // Method to set the amount completed
    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }

    // Override to get the details of the goal
    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} - Completed {_amountCompleted}/{_target} times";
    }

    // Override to get the string representation of the goal
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }
}
