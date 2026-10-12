using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private int _originalPoints;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
        _originalPoints = points;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (IsComplete() == true)
        {
            Console.WriteLine($"Congratulations! You have earned {_points + _bonus} points!");
            TurnPointsIntoBonus();
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
        }
    }

    public override bool IsComplete()
    {
        if (_target == _amountCompleted)
        {
            return true;
        }
        return false;
    }

    public override string GetDetailsString()
    {
        string text = base.GetDetailsString() + $" -- Currently Completed: {_amountCompleted}/{_target}";
        return text;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName}/{_description}/{_originalPoints}/{_bonus}/{_target}/{_amountCompleted}";
    }

    private void TurnPointsIntoBonus()
    {
        _points = _bonus;
    }
    
    public void SetAmountComplete(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }
}