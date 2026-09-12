// I added a system that counts the total amount of days that the User has written for, to encourage continued use of the journal!
using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator rnd = new PromptGenerator();

        Journal journal = new Journal();
        // Menu System 
        string userChoice = "0";
        while (userChoice != "5")
        {
            Console.WriteLine("");
            Console.WriteLine("Please Select One Of The Following Choices (1-5): ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("");
            Console.Write("Select Your Choice: ");
            userChoice = Console.ReadLine();
            Console.WriteLine("");
            if (userChoice == "1")
            {
                string rndPrompt = rnd.GetRandomPrompt();

                if (rndPrompt == "")
                {
                    Console.WriteLine("Sorry, there are no more prompts to answer today!");
                }
                else
                {
                    Entry entry = new Entry();
                    entry._promptText = rndPrompt;
                    Console.WriteLine(entry._promptText);
                    Console.Write("> ");
                    string userEntry = Console.ReadLine();
                    entry._entryText = userEntry;
                    journal.AddEntry(entry);




                }
            }

            else if (userChoice == "2")
            {
                journal.DisplayAll();
            }

            else if (userChoice == "3")
            {
                Console.Write("What is the file you want to load? ");
                string fileToBeLoaded = Console.ReadLine();
                journal.LoadFromFile(fileToBeLoaded);
            }

            else if (userChoice == "4")
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();

                journal.SaveToFile(fileName);
            }

            else if (userChoice == "5")
            {
            }

            else
            {
                Console.WriteLine("Please enter a Number Between 1-5.");
            }
        }



    }
}