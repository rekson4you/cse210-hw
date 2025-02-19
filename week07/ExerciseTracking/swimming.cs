
public class Swimming : Activity
{
    private int laps; // Number of laps

    public Swimming(DateTime date, int lengthInMinutes, int laps)
        : base(date, lengthInMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000 * 0.62; // Convert meters to miles
    }

    public override double GetSpeed()
    {
        return (GetDistance() / lengthInMinutes) * 60;
    }

    public override double GetPace()
    {
        return lengthInMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")} Swimming ({lengthInMinutes} min) - Laps: {laps}, Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}