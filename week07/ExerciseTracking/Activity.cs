using System;
using System.Collections.Generic;

public abstract class Activity
{
    // Protected members accessible by derived classes
    protected DateTime date;
    protected int lengthInMinutes;

    // Constructor to initialize date and length
    public Activity(DateTime date, int lengthInMinutes)
    {
        this.date = date;
        this.lengthInMinutes = lengthInMinutes;
    }

    // Abstract methods to be overridden in derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Method to get summary of the activity
    public virtual string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")} - Length: {lengthInMinutes} min";
    }
}