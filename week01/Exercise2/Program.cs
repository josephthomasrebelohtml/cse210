using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userGrade = Console.ReadLine();
        int number = int.Parse(userGrade);
        Console.WriteLine("");

        string letterGrade = "";

        if (number >= 90)
        {
            letterGrade = "A";
        }
        else if (number >= 80)
        {
            letterGrade = "B";
        }
        else if (number >= 70)
        {
            letterGrade = "C";
        }
        else if (number >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        Console.Write($"Your grade is {letterGrade}.");
        Console.WriteLine("");

        if (number >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }

        else
        {
            Console.WriteLine("You failed, try studying more for next time. ");
        }

    }
}