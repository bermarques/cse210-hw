public class Video
{
    public string _title { get; set; }
    public string _author { get; set; }
    public int _length { get; set; }
    private List<Comment> comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int CommentCount()
    {
        return comments.Count;
    }

    public List<Comment> GetComments()
    {
        return comments;
    }

    public void GetStringDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {CommentCount()}");
        Console.WriteLine("Comments:");
        foreach (var comment in GetComments())
        {
            Console.WriteLine($"  {comment._name}: {comment._text}");
        }
        Console.WriteLine(new string('-', 50));
    }
}