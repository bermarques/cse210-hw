class QuoteActivity : Activity
{
    private List<string> _quotes = new List<string>();
    public QuoteActivity() : base()
    {
        _name = "Quote activity.";
        _description = "This activity will help you by giving you some inspring quotes for you";
        _quotes.Add("The only way to do great work is to love what you do. - Steve Jobs");
        _quotes.Add("Success is not final, failure is not fatal: It is the courage to continue that counts. - Winston Churchill");
        _quotes.Add("Believe you can and you're halfway there. - Theodore Roosevelt");
        _quotes.Add("What lies behind us and what lies before us are tiny matters compared to what lies within us. - Ralph Waldo Emerson");
        _quotes.Add("The best way to predict the future is to create it. - Peter Drucker");
        _quotes.Add("Your time is limited, don't waste it living someone else's life. - Steve Jobs");
        _quotes.Add("You miss 100% of the shots you don't take. - Wayne Gretzky");
        _quotes.Add("The only limit to our realization of tomorrow is our doubts of today. - Franklin D. Roosevelt");
        _quotes.Add("It does not matter how slowly you go as long as you do not stop. - Confucius");
        _quotes.Add("The journey of a thousand miles begins with one step. - Lao Tzu");
    }

    public string GetRandomQuote()
    {
        Random random = new Random();
        int index = random.Next(_quotes.Count);
        return _quotes[index];
    }

    public void Run()
    {
        int duration = _duration;
        Console.WriteLine("Relax.");
        ShowSpinner(2);
        Console.WriteLine("Try to reflect on the words said by the following personalities.");
        ShowSpinner(2);
        Console.WriteLine("You may begin in...");
        ShowCountDown(5);

        DateTime currentTime = DateTime.Now;
        DateTime targetTime = currentTime.AddSeconds(duration);
        while (targetTime > currentTime)
        {
            Console.Clear();
            Console.WriteLine(GetRandomQuote());
            ShowSpinner(5);
            currentTime = DateTime.Now;
        }
    }

}