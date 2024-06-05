public class Comment
{
    public string _name { get; }
    public string _text { get; }

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }
}