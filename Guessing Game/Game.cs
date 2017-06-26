/*
Ryan Doiron
04/20/2016
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class Game
    {
        private RangedRandomNumber secretNumberGenerator; // Composition - "has a"
        private UInt16 guessCount;
        private string guess;

        // method
        private UInt16 GameSetup(byte menuOption)
        {
            UInt16 secretNumber = 0;
            secretNumberGenerator.SetMinimum(1);
            switch (menuOption)
            {
                case 0:
                    break;
                case 1:
                    secretNumberGenerator.SetMaximum(20);
                    secretNumber = Convert.ToUInt16(secretNumberGenerator.GenerateRandomNumber());
                    break;
                case 2:
                    secretNumberGenerator.SetMaximum(100);
                    secretNumber = Convert.ToUInt16(secretNumberGenerator.GenerateRandomNumber());
                    break;
                case 3:
                    secretNumberGenerator.SetMaximum(1000);
                    secretNumber = Convert.ToUInt16(secretNumberGenerator.GenerateRandomNumber());
                    break;
                default:
                    break;
            }
            return secretNumber;
        }

        // constructor
        public Game()
        {
            guessCount = 0;
            guess = string.Empty;
            secretNumberGenerator = new RangedRandomNumber();
        }

        // method
        public UInt16 DisplayMenu()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Amazing Guessing Game!\n");
            Console.WriteLine("Please select an option:\n");
            Console.WriteLine("1: Easy: Guess a number between 1 and 20");
            Console.WriteLine("2: Normal: Guess a number between 1 and 100");
            Console.WriteLine("3: Hard: Guess a number between 1 and 1000");
            Console.WriteLine("0: Exit\n");
            Console.Write("Choose your option: ");

            bool validInput = false;
            string menuInput = string.Empty;
            byte menuOption = 4;
            do
            {
                try
                {
                    menuInput = Console.ReadLine();
                    menuOption = Convert.ToByte(menuInput);
                }
                catch (SystemException e)
                {
                    Console.WriteLine("Please enter a value between 0 and 3!");
                }
                validInput = (menuOption >= 0) && (menuOption <= 3); // verify the range
                if (!validInput)
                {
                    Console.Write("Please enter 0, 1, 2 or 3: ");
                }
            } while (!validInput); // loop until valid input is given
            return GameSetup(menuOption);
        }

        // method
        public void PlayGame(UInt16 secretNumber)
        {
            UInt16 guessedNum = 0;
            guessCount = 0;
            do
            {
                Console.Write("Guess the number: ");
                try
                {
                    guess = Console.ReadLine();
                    guessedNum = Convert.ToUInt16(guess);
                }
                catch (SystemException e)
                {
                    Console.WriteLine("You did not enter in a valid number, please try again.");
                }
                if (guessedNum != secretNumber)
                {
                    if (guessedNum > secretNumber)
                    {
                        Console.WriteLine("\nToo high, try again.\n");
                    }
                    else
                    {
                        Console.WriteLine("\nToo low, try again.\n");
                    }
                }
                guessCount++;
            } while (guessedNum != secretNumber);
            Console.WriteLine("\nYou guessed the right number! Congrats!");
            if (guessCount == 1)
            {
                Console.WriteLine("You took " + guessCount + " guess to get the right number.");
            }
            else
            {
                Console.WriteLine("You took " + guessCount + " guesses to get the right number.");
            }
        }


    }
}
