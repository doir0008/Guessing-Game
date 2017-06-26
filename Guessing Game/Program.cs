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
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Game game = new Game(); // setup game object
            do
            {
                UInt16 secretNumber = game.DisplayMenu(); // display the game menu
                if (secretNumber == 0) // 0 exits the game
                {
                    break;
                }
                else
                {
                    Console.WriteLine("The secret number is " + secretNumber + "\n"); // just here for testing purposes
                    game.PlayGame(secretNumber); // play the game
                }
                Console.Write("\n\nPlay again? (N/n = No) ");
                input = Console.ReadLine();
            } while (!input.Equals("n", StringComparison.CurrentCultureIgnoreCase)); // loop while input is not N
            Console.WriteLine("\n\nThanks for playing!");
        }
    }
}
