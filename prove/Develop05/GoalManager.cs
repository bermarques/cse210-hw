public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        _goals = new List<Goal>();
        _score = 0;



        int menu = 0;

        while (menu != 6)
        {
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        // Implementation for displaying player information
    }

    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal._shortName);
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points!");
    }

    public void CreateGoal()
    {
        int goalType = 0;
        string name;
        string description;
        int points;


        while (goalType != 4)
        {
            Console.WriteLine("The types of goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("4. Go back to the main menu");
            Console.WriteLine("What type of goal would you like to create?");
            try
            {
                goalType = int.Parse(Console.ReadLine());
                switch (goalType)
                {
                    case 1:


                        Console.WriteLine("What is the name of your goal?");

                        name = Console.ReadLine();

                        Console.WriteLine("What is a short description of it?");

                        description = Console.ReadLine();

                        Console.WriteLine("What is the amount of points associated with this goal?");

                        points = int.Parse(Console.ReadLine());

                        _goals.Add(new SimpleGoal(name, description, points));



                        break;
                    case 2:

                        Console.WriteLine("What is the name of your goal?");

                        name = Console.ReadLine();

                        Console.WriteLine("What is a short description of it?");

                        description = Console.ReadLine();

                        Console.WriteLine("What is the amount of points associated with this goal?");

                        points = int.Parse(Console.ReadLine());

                        _goals.Add(new EternalGoal(name, description, points));



                        break;
                    case 3:

                        Console.WriteLine("What is the name of your goal?");

                        name = Console.ReadLine();

                        Console.WriteLine("What is a short description of it?");

                        description = Console.ReadLine();

                        Console.WriteLine("What is the amount of points associated with this goal?");

                        points = int.Parse(Console.ReadLine());

                        Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");

                        string _checkTarget = Console.ReadLine();

                        Console.WriteLine("What is the bonus for accomplishing it that many times?");

                        string _checkBonus = Console.ReadLine();

                        _goals.Add(new ChecklistGoal(name, description, points, int.Parse(_checkTarget), int.Parse(_checkBonus)));

                        break;
                    case 4:
                        Console.WriteLine("Going back to the main menu");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Invalid input");

            }
        }

    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish?");
        foreach (var goal in _goals.Select((item, index) => (item, index)))
        {
            Console.WriteLine($"{goal.index + 1}{goal.item._shortName}");
        }
        int goalIndex = int.Parse(Console.ReadLine()) - 1;
        Goal selectedGoal = _goals[goalIndex];

        if (selectedGoal.IsComplete())
        {
            Console.WriteLine($"You already completed that goal.");
        }
        else
        {
            selectedGoal.RecordEvent();

            _score += selectedGoal._points;
        }
    }

    public void SaveGoals()
    {
        Console.WriteLine("What is the filename for the goal file?");

        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {

            outputFile.WriteLine("goalType,shortName,description,points,isComplete,bonus,amountCompleted,target");
            outputFile.WriteLine(_score);
            foreach (var goal in _goals)
            {
                if (goal is SimpleGoal)
                {

                    outputFile.WriteLine($"simpleGoal+++{goal.GetDetailsString()}+++null+++null+++null");
                }
                if (goal is EternalGoal)
                {
                    outputFile.WriteLine($"eternalGoal+++{goal.GetDetailsString()}+++null+++null+++null");
                }
                if (goal is ChecklistGoal checklistGoal)
                {
                    outputFile.WriteLine($"checklistGoal+++{checklistGoal.GetDetailsString()}+++{checklistGoal._bonus}+++{checklistGoal._amountCompleted}+++{checklistGoal._target}");
                }
            }
        }
    }

    public void LoadGoals()
    {
        Console.WriteLine("What is the filename for the goal file?");
        string filename = Console.ReadLine();


        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename).Skip(1).ToArray();
            int.TryParse(lines[0], out _score);

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] parts = line.Split("+++");
                string goalType = parts[0];
                string shortName = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                string isComplete = parts[4];
                int bonus = parts[5] == "null" ? 0 : int.Parse(parts[5]);
                int amountCompleted = parts[6] == "null" ? 0 : int.Parse(parts[6]);
                int target = parts[7] == "null" ? 0 : int.Parse(parts[7]);



                if (parts.Length >= 2)
                {
                    if (goalType == "simpleGoal")
                    {
                        _goals.Add(new SimpleGoal(shortName, description, points));
                    }
                    else if (goalType == "eternalGoal")
                    {
                        _goals.Add(new EternalGoal(shortName, description, points));
                    }
                    else if (goalType == "checklistGoal")
                    {
                        _goals.Add(new ChecklistGoal(shortName, description, points, target, bonus));
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }

    }
}