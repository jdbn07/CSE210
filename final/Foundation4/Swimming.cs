class Swimming : Activity
{
    private int laps;
    private const double LapLengthInMeters = 50;
    private const double MetersToMilesConversionFactor = 0.000621371;

    public Swimming(DateTime date, int duration, int laps) 
        : base(date, duration)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * LapLengthInMeters * MetersToMilesConversionFactor;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Duration) * 60;
    }

    public override double GetPace()
    {
        return Duration / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} Swimming ({Duration} min) - Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}