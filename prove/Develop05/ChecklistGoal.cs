public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private bool _isComplete;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0; // 
        _isComplete = false; // First time running
    }

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amount, bool isComplete) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amount; // 
        _isComplete = isComplete; // Loading from a file
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _amountCompleted++;
            if (_amountCompleted == _target)
            {
                _isComplete = true;
                return _points + _bonus;
            }
            else
            {
                return _points;
            }
        }
        else
        {
            return 0;
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{_shortName},{_description},{_points},{_target},{_bonus},{_amountCompleted},{_isComplete}";
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $" - {_amountCompleted}/{_target}";
    }
}