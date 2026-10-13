using System;

public class Swimming : Activity
{
    private double _laps;

    public Swimming(DateTime date, int length, double laps) : base(date, length)
    {
        _laps = laps;
    }

        public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _length) * 60;
    }
    public override double GetPace()
    {
        return _length / GetDistance();
    }
}