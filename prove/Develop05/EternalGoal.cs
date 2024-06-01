public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }


    public override bool IsComplete()
    {
        return false;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Registered eternal goal '{_shortName}'. You earned {_points} points.");
    }
    public override string GetStringRepresentation()
    {
        return $"[ ] {_shortName} ({_description})";

    }
}