abstract class Activity
{
    private DateTime date;
    private int duration; // in minutes

    public Activity(DateTime date, int duration)
    {
        this.date = date;
        this.duration = duration;
    }

    public DateTime Date
    {
        get { return date; }
    }

    public int Duration
    {
        get { return duration; }
    }

    public abstract double GetDistance(); // Distance in miles or kilometers
    public abstract double GetSpeed();    // Speed in mph or kph
    public abstract double GetPace();     // Pace in minutes per mile or kilometer

    public virtual string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")} {GetType().Name} ({duration} min) - Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}
