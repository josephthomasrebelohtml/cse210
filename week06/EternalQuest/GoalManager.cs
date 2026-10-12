using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private int _level = 1;

    public void Start()
    {
        string userChoice = "-1";
        while (userChoice != "6")
        {
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                CreateGoal();
            }

            else if (userChoice == "2")
            {
                ListGoalDetails();
            }
            else if (userChoice == "3")
            {
                SaveGoals();
            }
            else if (userChoice == "4")
            {
                LoadGoals();
            }
            else if (userChoice == "5")
            {
                RecordEvent();
            }
            else if (userChoice == "6")
            {

            }
        }
    }

    private void DisplayPlayerInfo()
    {
        DetermineLevel();
        Console.WriteLine("");
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine($"You are Level {_level}!");
        Console.WriteLine("");
    }
    private void DetermineLevel()
    {
        int percentageMultiplier = _level;
        double pointsTarget = 500 * (1.10 * (percentageMultiplier));
        while (_score >= pointsTarget)
        {
            _level++;
            percentageMultiplier = _level;
            pointsTarget = 500 * (1.10 * (percentageMultiplier));
        }

    }

    private void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        int i = 0;
        foreach (Goal goal in _goals)
        {
            i++;
            Console.WriteLine($"{i}. {goal.GetName()}");
        }
    }

    private void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        int i = 0;
        foreach (Goal goal in _goals)
        {
            i++;
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
        }
    }

    private void CreateGoal()
    {
        string userTypeChoice;
        string goalName;
        string description;
        int points;
        List<string> commonInformation = new List<string>();

        Console.WriteLine("The Types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        userTypeChoice = Console.ReadLine();

        commonInformation = GetCreateGoalCommonInformation();
        goalName = commonInformation[0];
        description = commonInformation[1];
        points = int.Parse(commonInformation[2]);

        if (userTypeChoice == "1")
        {
            SimpleGoal simpleGoal = new SimpleGoal(goalName, description, points);
            _goals.Add(simpleGoal);
        }
        else if (userTypeChoice == "2")
        {
            EternalGoal eternalGoal = new EternalGoal(goalName, description, points);
            _goals.Add(eternalGoal);
        }
        else if (userTypeChoice == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checklistGoal = new ChecklistGoal(goalName, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }
    }

    private List<string> GetCreateGoalCommonInformation()
    {
        List<string> parts = new List<string>();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();
        parts.Add(name);
        parts.Add(description);
        parts.Add(points);

        return parts;
    }

    private void RecordEvent()
    {
        int limiter = _goals.Count();
        string userChoice;
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        userChoice = Console.ReadLine();
        int userNumberChoice = int.Parse(userChoice);
        userNumberChoice--;

        if (userNumberChoice < limiter)
        {

            if (_goals[userNumberChoice].IsComplete() == false)
            {
                _score += _goals[userNumberChoice].GetPoints();
                _goals[userNumberChoice].RecordEvent();
                if (_goals[userNumberChoice] is ChecklistGoal)
                {
                    if (_goals[userNumberChoice].IsComplete() == true)
                    {
                        _score += _goals[userNumberChoice].GetPoints();
                    }
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("That goal is already complete.");
            }

        }

    }

    private void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    private void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        bool scoreSet = false;
        foreach (string line in lines)
        {
            if (scoreSet == false)
            {
                _score = int.Parse(line);
                scoreSet = true;
            }
            else
            {
                string[] parts = line.Split(":");
                string classType = parts[0];
                string classDetails = parts[1];
                LoadClassCreator(classType, classDetails);
            }
        }
    }

    private void LoadClassCreator(string classType, string classDetails)
    {
        string[] details = classDetails.Split("/");

        if (classType == "SimpleGoal")
        {
            string name = details[0];
            string description = details[1];
            int points = int.Parse(details[2]);
            bool booleanValue = bool.Parse(details[3]);

            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            simpleGoal.SetComplete(booleanValue);
            _goals.Add(simpleGoal);
        }

        else if (classType == "EternalGoal")
        {
            string name = details[0];
            string description = details[1];
            int points = int.Parse(details[2]);

            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }
        
        else if (classType == "ChecklistGoal")
        {
            string name = details[0];
            string description = details[1];
            int points = int.Parse(details[2]);
            int bonus = int.Parse(details[3]);
            int target = int.Parse(details[4]);
            int amountCompleted = int.Parse(details[5]);

            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            checklistGoal.SetAmountComplete(amountCompleted);
            _goals.Add(checklistGoal);
        }

    }

}
