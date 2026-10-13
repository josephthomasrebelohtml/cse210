using System;

public abstract class Activity
{
    protected DateTime _date;
    protected int _length;

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {GetType().Name} ({_length} min): Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {Math.Round(GetPace(),2)} min per km";
    }
}