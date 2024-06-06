using System;

class Program
{
    static void Main(string[] args)
    {
        Activity running = new Running(new DateTime(2022, 11, 3), 30, 4.8);
        Activity cycling = new Cycling(new DateTime(2022, 11, 3), 60, 20.0);
        Activity swimming = new Swimming(new DateTime(2022, 11, 3), 45, 30);

        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine(new string('-', 50));
        }

    }
}