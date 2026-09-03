using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //Old Code
        //Console.Write("What is your magic number? ");
        //string userNumber = Console.ReadLine();
        //int magicNumber = int.Parse(userNumber);

        //Random Number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        string guessed = "no";

        while (guessed !="yes")
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            int guessNumber = int.Parse(guess);

            if (guessNumber != magicNumber)
            {
                if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Lower");
                }
            }

            else
            {
                Console.WriteLine("You guessed it!");
                guessed = "yes";
            }
        }




    }
}