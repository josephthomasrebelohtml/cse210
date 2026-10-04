using System;
using System.Collections.Generic;
public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>();

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        PopulatePrompts();
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("");
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        List<string> userList = new List<string>();
        userList = GetListFromUser();
        _count = userList.Count;
        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random rnd = new Random();
        if (_prompts.Count == 0)
        {
            PopulatePrompts();
            Console.WriteLine("All prompts have been used at least once, restarting list...");
            Console.WriteLine("");
        }

        int rndNumber = rnd.Next(0, _prompts.Count);
        string rndPrompt = _prompts[rndNumber];
        _prompts.RemoveAt(rndNumber);
        Console.WriteLine($"--- {rndPrompt} ---");
    }
    
    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        Console.WriteLine("");
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string userInput = Console.ReadLine();

            if (userInput != "")
            {
                userList.Add(userInput);
            }
            else { }
        }

        return userList;

    }

    private void PopulatePrompts()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }


}