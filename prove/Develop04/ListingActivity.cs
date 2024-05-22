class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _answers = new List<string>();
    public ListingActivity() : base()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

    }

    public void Run()
    {
        int duration = _duration;
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);

        DateTime currentTime = DateTime.Now;
        DateTime targetTime = currentTime.AddSeconds(duration);
        do
        {
            Console.Write("> ");
            string answer = Console.ReadLine();
            currentTime = DateTime.Now;
            _answers.Add(answer);
        } while (targetTime > currentTime);
        Console.WriteLine($"You listed {GetListFromUser().Count} items!");
        ShowSpinner(10);
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        return _answers;
    }

}