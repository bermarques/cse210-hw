using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Learning C#", "Felipe Deschamps", 300);
        Video video2 = new Video("Learning Javascript", "Deyvin", 600);
        Video video3 = new Video("Learning .NET", "Gustavo Guanabara", 1200);
        Video video4 = new Video("Guitar Tutorial", "Lorenzo", 450);

        video1.AddComment(new Comment("John", "Great tutorial!"));
        video1.AddComment(new Comment("Doe", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Smith", "Awesome video!"));

        video2.AddComment(new Comment("John", "Great tutorial!"));
        video2.AddComment(new Comment("Doe", "Very helpful, thanks!"));
        video2.AddComment(new Comment("Charlie", "Awesome video!"));

        video3.AddComment(new Comment("John", "Great tutorial!"));
        video3.AddComment(new Comment("Doe", "Very helpful, thanks!"));
        video3.AddComment(new Comment("Smith", "Awesome video!"));

        video4.AddComment(new Comment("John", "Great tutorial!"));
        video4.AddComment(new Comment("Doe", "Very helpful, thanks!"));
        video4.AddComment(new Comment("Smith", "Awesome video!"));

        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        foreach (var video in videos)
        {
            video.GetStringDetails();
        }
    }
}