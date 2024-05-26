using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class GoalManager
{
    private List<Goal> _goals = new();
    private int _score;

    public void Start()
    {
        string choice; 

        do
        {Console.WriteLine(""); 
            Console.WriteLine($"> Your actual score is: {_score}"); 
            Console.WriteLine(""); 
            Console.WriteLine("Menu Options");
            Console.WriteLine("     1. Create New Goal");
            Console.WriteLine("     2. List goals");
            Console.WriteLine("     3. Save goals");
            Console.WriteLine("     4. Load goals");
            Console.WriteLine("     5. Record Event");
            Console.WriteLine("     6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                Console.Write("What is the name of your file?: ");
                string fileName = Console.ReadLine();
                LoadGoals(fileName);
                Console.WriteLine($"{fileName} opened correctly.");
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Please enter a valid character from the menu");
            }

        } while (choice != "6");
    }

    public void DisplayPlayerInfo()
    {
        Console.Write("Which goal did you accomplished?: ");
        int get = int.Parse(Console.ReadLine());
        Console.WriteLine(); // Move to the next line
        int index = get - 1;
        int points = _goals[index].RecordEvent();
        if (points == 0)
        {
            Console.WriteLine("Goal already completed.");
        }
        else
        {
            _score += points;
            Console.WriteLine($"Score: {_score}");
        }

    }

    public void ListGoalNames()
    {
        int counter = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(counter + ". " + goal.GetDetailString2());
            counter++;
        }

    }

    public void ListGoalDetails()
    {
        int counter = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(""); // BLANK
            Console.WriteLine(counter + ". " + goal.GetDetailsString());
            counter++;
        }
    }

    public void CreateGoal()
    {
        string choice1;
        Console.WriteLine(" "); 
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        choice1 = Console.ReadLine();
        Console.WriteLine(""); 

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.WriteLine(""); 
        Console.Write("What is a short description of it: ");
        string description = Console.ReadLine();
        Console.WriteLine(""); 
        Console.Write("What is the ammount of points associated with this goal?: ");
        int points = int.Parse(Console.ReadLine());
        Console.WriteLine(""); 

        if (choice1 == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (choice1 == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (choice1 == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine(); 
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            Console.WriteLine(); 
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are: ");
        ListGoalNames();
        Console.Write("Which goal did you accomplished?: ");
        int get = int.Parse(Console.ReadLine());
        Console.WriteLine(); 
        int index = get - 1;
        int points = _goals[index].RecordEvent();
        if (points == 0)
        {
            Console.WriteLine("Goal already completed.");
        }
        else
        {
            _score += points;
        }
    }

    public void SaveGoals()
    {
        Console.Write("With what name you want to save the file: ");
        string fileName = Console.ReadLine();
        Console.WriteLine(); 
        using StreamWriter outputFile = new(fileName);
        outputFile.WriteLine(_score); 
        foreach (Goal goal in _goals)
        {
            outputFile.WriteLine(goal.GetStringRepresentation());
        }
        Console.WriteLine($"File saved as {fileName}");
        _score = 0;
        Console.WriteLine(""); 
        _goals.Clear(); 
    }

    public void LoadGoals(string fileName)
    {

        string[] lines = System.IO.File.ReadAllLines(fileName);

        if (lines.Length > 0)
        {
            int lastScore = int.Parse(lines[0]); 
            _score = lastScore;
        }

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            if (parts.Length >= 4)
            {
                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
            
                if (type == "SimpleGoal")
                {
                    bool isComplete = bool.Parse(parts[4]);
                    _goals.Add(new SimpleGoal(name, description, points, isComplete));
                }
                else if (type == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(name, description, points));
                }
                else if (type == "ChecklistGoal")
                {
                    if (parts.Length >= 6) 
                    {
                        int target = int.Parse(parts[4]);
                        int bonus = int.Parse(parts[5]);
                        int amount = int.Parse(parts[6]);
                        bool isCompleteCheckList = bool.Parse(parts[7]);
                        _goals.Add(new ChecklistGoal(name, description, points, target, bonus, amount, isCompleteCheckList));
                    }
                }
            }
        }
    }
}