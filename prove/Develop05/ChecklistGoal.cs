public class ChecklistGoal : Goal
{
    public int _amountCompleted { get; protected set; }
    public int _target { get; protected set; }
    public int _bonus { get; protected set; }
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Goal '{_shortName}' completed! You earned {_points} points.");
        _amountCompleted++;
        if (
            _amountCompleted >= _target
        )
        {
            Console.WriteLine($"You also earned {_bonus} bonus points!");
        }
    }
    public override string GetStringRepresentation()
    {
        return $"{(IsComplete() ? "[X]" : "[ ]")} {_shortName} ({_description}) - Currently completed: {_amountCompleted}/{_target}";
    }
}