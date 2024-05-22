class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        int duration = _duration;

        Console.Clear();
        do
        {
            Console.Write("Breathe in...");
            ShowCountDown(5);
            Console.Write("");
            duration -= 5;

            if (duration <= 0)
            {
                break;
            }

            Console.Write("Breathe out...");
            ShowCountDown(8);
            Console.Write("");
            duration -= 8;
        } while (duration > 0);
    }
}