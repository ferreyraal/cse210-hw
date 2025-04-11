public class GoalManager
{
    protected List<Goal> _goals = new List<Goal>();
    protected int _score = 0;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        Console.Clear();
        string user_entry = "";
        int option = 0;
        do
        {
            // Start menu options
            Console.WriteLine("");
            DisplayPlayerInfo();
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Extra Bonus Rules");
            Console.WriteLine("7. Quit");
            Console.Write("Select a choice from the menu: ");
            user_entry = Console.ReadLine();
            option = Convert.ToInt32(user_entry);
            if (option == 1)
            {
                CreateGoal();
            }
            if (option == 2)
            {
                ListGoalDetails();
            }
            if (option == 3)
            {
                SaveGoals();
            }
            if (option == 4)
            {
                LoadGoals();
            }
            if (option == 5)
            {
                RecordEvent();
            }
            if (option == 6)
            {
                // Showing Creativity and Exceeding Requirements
                // I'm creating a special prize every time I reach 5 simple or checklist type goals.
                // I'm going to add some additional code in RecordEvent()

                Console.Write("Extra Bonus Rules: ");
                Console.Write("Every time you complete 5 Simple goals, it will give you 1000 extra points.");
                Console.Write("Every time you complete 5 Checklist goals, it will give you 2000 extra points.");
            }
        } while (option != 7);

    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        string goalSelected_txt = Console.ReadLine();
        int goalSelected = Convert.ToInt32(goalSelected_txt);
        if (_goals[goalSelected - 1].isComplete())
        {
            Console.WriteLine($"  ***  This goal is already completed *** ");
        }
        else
        {
            _goals[goalSelected - 1].RecordEvent();
            _score = _score + _goals[goalSelected - 1].GetPoints();
            // Showing Creativity and Exceeding Requirements
            int simpleGoalCompleted = 0;
            int checklistGoalCompleted = 0;
            foreach (Goal x in _goals)
            {
                if (x is SimpleGoal)
                {
                    simpleGoalCompleted++;
                }
                if (x is ChecklistGoal)
                {
                    checklistGoalCompleted++;
                }
            }
            if (simpleGoalCompleted % 5 == 0)
            {
                Console.WriteLine($"Congratulatios 🎉 You have reached {simpleGoalCompleted} Simple goals!");
                _score = _score + 1000;
            }
            if (checklistGoalCompleted % 5 == 0)
            {
                Console.WriteLine($"Congratulatios 🎉 You have reached {checklistGoalCompleted} Simple goals!");
                _score = _score + 2000;
            }
            Console.WriteLine($"You now have {_score} points.");
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void CreateGoal()
    {
        DisplayGoalTypes();
        Console.Write("Which type of goal would you like to create? ");
        string goal_type = Console.ReadLine();
        // Common questions
        Console.Write("What is the name of your goal? ");
        string nameGoal = Console.ReadLine();
        Console.Write("What is the short description of it? ");
        string descriptionGoal = Console.ReadLine();
        int pointsGoal = 0;
        Console.Write("What is the amount of points associated with this goal? ");
        string pointsTxt = Console.ReadLine();
        pointsGoal = Convert.ToInt32(pointsTxt);
        if (goal_type == "1")
        {
            SimpleGoal sGoal = new SimpleGoal(nameGoal, descriptionGoal, pointsGoal, false);
            _goals.Add(sGoal);
        }
        if (goal_type == "2")
        {
            EternalGoal eGoal = new EternalGoal(nameGoal, descriptionGoal, pointsGoal);
            _goals.Add(eGoal);
        }
        if (goal_type == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string targetTxt = Console.ReadLine();
            int target = Convert.ToInt32(targetTxt);
            Console.Write("What is the bonus for accomplishing it that many times? ");
            string bonusTxt = Console.ReadLine();
            int bonus = Convert.ToInt32(bonusTxt);
            ChecklistGoal cGoal = new ChecklistGoal(nameGoal, descriptionGoal, pointsGoal, target, bonus, 0);
            _goals.Add(cGoal);
        }
    }
    public void ListGoalNames()
    {
        Console.WriteLine("The Goals are:");
        int count = 0;
        foreach (Goal x in _goals)
        {
            count++;
            Console.WriteLine($"{count}. {x.GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The Goals are:");
        int count = 0;
        foreach (Goal x in _goals)
        {
            count++;
            Console.WriteLine($"{count}. {x.GetStringRepresentation()}");
        }
    }
    public void DisplayGoalTypes()
    {
        Console.WriteLine("The Types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetDetailsString());
            }
        }
    }

    public void LoadGoals()
    {
        int counter = 0;
        _goals.Clear();
        _score = 0;
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            counter++;
            if (counter == 1)
            {
                _score = Convert.ToInt32(line);
            }
            else
            {
                string[] parts = line.Split(":", 2);
                string goalType = parts[0].Trim();
                string[] data = parts[1].Split(",");
                if (goalType == "Simple Goal")
                {
                    string name = data[0].Trim();
                    string description = data[1].Trim();
                    int points = int.Parse(data[2].Trim());
                    bool iscomplete = bool.Parse(data[3].Trim());
                    _goals.Add(new SimpleGoal(name, description, points, iscomplete));
                }
                if (goalType == "Eternal Goal")
                {
                    string name = data[0].Trim();
                    string description = data[1].Trim();
                    int points = int.Parse(data[2].Trim());
                    _goals.Add(new EternalGoal(name, description, points));
                }
                if (goalType == "Checklist Goal")
                {
                    string name = data[0].Trim();
                    string description = data[1].Trim();
                    int points = int.Parse(data[2].Trim());
                    int amountCompleted = int.Parse(data[3].Trim());
                    int target = int.Parse(data[4].Trim());
                    int bonus = int.Parse(data[5].Trim());
                    _goals.Add(new ChecklistGoal(name, description, points, target, bonus, amountCompleted));
                }
            }
        }
    }
}