// I added a Leveling up system that increases the requirement for the next level based on how the level of the user. 
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}