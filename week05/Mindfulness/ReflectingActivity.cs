using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        PopulatePrompts();
    }
    public void Run()
    {
        PopulateQuestions();
        DisplayStartingMessage();
        Console.WriteLine("");
        Console.WriteLine("Consider the Following Prompt: ");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
            ShowSpinner(4);
        }
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();

        if (_prompts.Count == 0)
        {
            PopulatePrompts();
            Console.WriteLine("All prompts have been used at least once, restarting list...");
        }
        
        int rndNumber = rnd.Next(0, _prompts.Count);
        string rndPrompt = _prompts[rndNumber];
        _prompts.RemoveAt(rndNumber);
        return rndPrompt;
    }

    public string GetRandomQuestion()
    {
        Random rnd = new Random();

        if (_questions.Count == 0)
        {
            PopulateQuestions();
            Console.WriteLine("All Questions have been used once for this prompt, Restarting List... ");
            Console.WriteLine("");
        }

        int rndNumber = rnd.Next(0, _questions.Count);
        string rndPrompt = _questions[rndNumber];
        _questions.RemoveAt(rndNumber);
        return rndPrompt;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }
    public void DisplayQuestions()
    {
        Console.WriteLine($"> {GetRandomQuestion()}");
    }
    private void PopulatePrompts()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
    }

    private void PopulateQuestions()
    {
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }


}