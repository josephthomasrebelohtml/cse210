// I added an option for the user to show moderately sized words as a hint on what has been hidden, in hopes that this can help the user try to place each word where it was before being hidden.
using System;

class Program
{
    static void Main(string[] args)
    {
        string verseText = "Wherefore, my beloved brethren, if ye have not charity, ye are nothing, for charity never faileth. Wherefore, cleave unto charity, which is the greatest of all, for all things must fail But charity is the pure love of Christ, and it endureth forever; and whoso is found possessed of it at the last day, it shall be well with him.";
        Reference ref1 = new Reference("Moroni", 7, 46, 47);
        Scripture scrip1 = new Scripture(ref1, verseText);
        Console.WriteLine(scrip1.GetDisplayText());

        bool done = false;
        while (done != true)
        {
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue, type Show for a list of hidden words, or type 'quit' to finish: ");
            Console.WriteLine("");
            string userInput = Console.ReadLine();
            if (userInput == "")
            {
                scrip1.HideRandomWords(6);

                if (scrip1.IsCompletelyHidden() == true)
                {
                    Console.Clear();
                    Console.WriteLine(scrip1.GetDisplayText());
                    Console.WriteLine("");
                    Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
                    done = true;
                    break;
                }
                else
                {
                }
                Console.Clear();
                Console.WriteLine(scrip1.GetDisplayText());
            }



            else if (userInput != "")
            {
                if (userInput.ToLower() == "quit")
                {
                    done = true;
                    break;
                }
                else if (userInput.ToLower() == "show")
                {
                    Console.Clear();
                    Console.WriteLine(scrip1.GetDisplayText());
                    Console.WriteLine("");
                    Console.WriteLine("List of Hidden Words: ");
                    scrip1.ShowHiddenWords();
                }
                else
                {
                    Console.WriteLine("Please press Enter, or type Show or Quit");
                }


            }

            else
            {

            }
        }





    }
}