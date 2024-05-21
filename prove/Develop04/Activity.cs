class Activity
{
    protected string _name { get; set; }
    protected string _description { get; set; }
    protected int _duration { get; set; }

    public Activity()
    {

    }

    public void DisplayStartingMessaging()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the " + _name);
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(2);
        Console.WriteLine("");
        Console.WriteLine($"\bYou have completed {_duration} seconds of the {_name}");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        DateTime currentTime = DateTime.Now;
        DateTime targetTime = currentTime.AddSeconds(seconds);
        char[] spinner = ['|', '/', '-', '\\'];
        int index = 0;
        while (currentTime < targetTime)
        {
            Console.Write("\r" + spinner[index]);
            index = (index + 1) % spinner.Length;
            Thread.Sleep(200);
            currentTime = DateTime.Now;
        }
    }

    public void ShowCountDown(int seconds)
    {
        DateTime currentTime = DateTime.Now;
        DateTime targetTime = currentTime.AddSeconds(seconds);
        do
        {
            Console.Write(seconds);
            seconds--;
            Thread.Sleep(1000);
            currentTime = DateTime.Now;
            Console.Write("\b");
        } while (currentTime < targetTime);
        Console.Write(" ");
        Console.WriteLine("");
    }
}