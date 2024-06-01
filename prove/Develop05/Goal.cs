public abstract class Goal
{
    public string _shortName { get; protected set; }
    protected string _description;
    public int _points { get; protected set; }


    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
    public string GetDetailsString()
    {
        return $"{_shortName}+++{_description}+++{_points}+++{IsComplete()}";
    }
}