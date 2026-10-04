using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    }

    public void Run()
    {
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("");
            Console.Write("Breathe in... ");
            ShowCountDown(3);
            Console.Write("\nNow breathe out... ");
            ShowCountDown(5);
            Console.WriteLine("");
        }
        DisplayEndingMessage();   
    }
}