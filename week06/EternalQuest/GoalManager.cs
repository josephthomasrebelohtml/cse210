using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
    }

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

    }

    private void ListGoalDetails()
    {
    }

    private void CreateGoal()
    {
        string userTypeChoice;
        string goalName;
        string description;
        int points = 0;

        Console.WriteLine("The Types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create?");
        userTypeChoice = Console.ReadLine();

        if (userTypeChoice == "1")
        {

        }
        else if (userTypeChoice == "2")
        {

        }
        else if (userTypeChoice == "3")
        {

        }
    }

    private List<string> CreateGoalBasicInformation()
    {

    }

    private void RecordEvent()
    {

    }

    private void SaveGoals()
    {

    }

    private void LoadGoals()
    {

    }




}