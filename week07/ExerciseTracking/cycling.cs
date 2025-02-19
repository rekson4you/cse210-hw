
public class Cycling : Activity
{
    private double speed; // Speed in mph

    public Cycling(DateTime date, int lengthInMinutes, double speed)
        : base(date, lengthInMinutes)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return (speed * lengthInMinutes) / 60;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60 / speed;
    }

    public override string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")} Cycling ({lengthInMinutes} min) - Speed: {speed} mph, Distance: {GetDistance():0.0} miles, Pace: {GetPace():0.0} min per mile";
    }
}