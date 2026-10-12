using System;

public abstract class Goal
{
    protected string _shortName = "";
    protected string _description = "";
    protected int _points = 0;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetStringRepresentation();

    public virtual string GetDetailsString()
    {
        string text;
        if (IsComplete() == true)
        {
            text = $"[X] {_shortName} ({_description})";
            return text;
        }
        else
        {
            text = $"[ ] {_shortName} ({_description})";
        }

        return text;
    }

    public int GetPoints()
    {
        return _points;
    }

    public string GetName()
    {
        return _shortName;
    }



}