using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the hardest part of my day?",
        "What did I learn today?",
        "What do I need to improve?",
    };

    Random rnd = new Random();


      
    public string GetRandomPrompt()
    {
        if (_prompts.Count != 0)
        {
            int rndNumber = rnd.Next(0, _prompts.Count);
            string rndPrompt = _prompts[rndNumber];
            _prompts.RemoveAt(rndNumber);
            return rndPrompt;
        }

        else
        {
            return "";
        }

    }
}