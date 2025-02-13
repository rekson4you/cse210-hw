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
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Select a choice from the menu:");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Create Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    CreateGoal();
                    break;
                case "4":
                    RecordEvent();
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    private void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("Enter Goal Type (Simple, Eternal, Checklist):");
        string type = Console.ReadLine();
        Console.WriteLine("Enter Goal Name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Goal Description:");
        string description = Console.ReadLine();
        Console.WriteLine("Enter Goal Points:");
        int points = int.Parse(Console.ReadLine());

        Goal goal = null;
        if (type == "Simple")
        {
            goal = new SimpleGoal(name, description, points);
        }
        else if (type == "Eternal")
        {
            goal = new EternalGoal(name, description, points);
        }
        else if (type == "Checklist")
        {
            Console.WriteLine("Enter Target Completions:");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Bonus Points:");
            int bonus = int.Parse(Console.ReadLine());
            goal = new ChecklistGoal(name, description, points, target, bonus);
        }

        if (goal != null)
        {
            _goals.Add(goal);
            Console.WriteLine("Goal created successfully!");
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }

    private void RecordEvent()
    {
        Console.WriteLine("Enter Goal Index to Record Event:");
        int index = int.Parse(Console.ReadLine());
        if (index >= 0 && index < _goals.Count)
        {
            Goal goal = _goals[index];
            int points = goal.RecordEvent();
            _score += points;
            Console.WriteLine($"Event recorded. You earned {points} points!");
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    private void SaveGoals()
    {
        string fileName = "goals.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }

    private void LoadGoals()
    {
        string fileName = "goals.txt";
        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);
            _score = int.Parse(lines[0]);
            _goals.Clear();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(':');
                string type = parts[0];
                string[] goalData = parts[1].Split(',');
                if (type == "SimpleGoal")
                {
                    SimpleGoal goal = new SimpleGoal(goalData[0], goalData[1], int.Parse(goalData[2]));
                    goal.SetComplete(bool.Parse(goalData[3]));
                    _goals.Add(goal);
                }
                else if (type == "EternalGoal")
                {
                    EternalGoal goal = new EternalGoal(goalData[0], goalData[1], int.Parse(goalData[2]));
                    _goals.Add(goal);
                }
                else if (type == "ChecklistGoal")
                {
                    ChecklistGoal goal = new ChecklistGoal(goalData[0], goalData[1], int.Parse(goalData[2]), int.Parse(goalData[4]), int.Parse(goalData[5]));
                    goal.SetAmountCompleted(int.Parse(goalData[3]));
                    _goals.Add(goal);
                }
            }
            Console.WriteLine("Goals loaded successfully!");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }
}           
