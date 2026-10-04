// I added some checks in the Reflection and Listing Activities to prevent constant repetition of prompts/questions
// When a list runs out of values, it warns the user and repopulates them again.
using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();

        string userChoice = "0";

        while (userChoice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu (1-4) ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                breathingActivity.Run();
            }
            else if (userChoice == "2")
            {
                reflectingActivity.Run();
            }

            else if (userChoice == "3")
            {
                listingActivity.Run();
            }
            else
            {
            }
        }
    }
}