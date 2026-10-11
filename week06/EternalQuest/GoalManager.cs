using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

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

            }
            else if (userChoice == "4")
            {

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
        Console.WriteLine("");
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine("");
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

        }
        else if (userTypeChoice == "3")
        {

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
                _goals[userNumberChoice].RecordEvent();
                _score += _goals[userNumberChoice].GetPoints();
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

    }

    private void LoadGoals()
    {

    }

}