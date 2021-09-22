using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Game
    {

        // Method that catches an exception if user enters an invalid variable
        public static int GetGuess()
        {
            int guess;
            string input;

            Console.WriteLine("Your guess:");
            input = Console.ReadLine();

            try
            {
                guess = Convert.ToInt32(input);
            }
            catch (Exception)
            {
                Console.WriteLine("This is not a valid guess.");
                guess = GetGuess();
            }
            return guess;
        }

        //Method for the mechanics of the game
        public static void GuessingNumber()
        {
            int guess;
            int answer;
            bool win = false;
            int tries = 8;

            Random rnd = new Random();
            answer = rnd.Next(1, 101);

            Console.WriteLine("\n Guess a number from 1 to 100. Can you do it in less than 8 tries?");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            do
            {
                guess = GetGuess();

                if (guess > answer && tries != 0)
                {
                    tries--;
                    Console.WriteLine("The answer is lower.");
                    Console.WriteLine($"You have {tries} tries left");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                }
                else if (guess < answer && tries != 0)
                {
                    tries--;
                    Console.WriteLine("The answer is higher.");
                    Console.WriteLine($"You have {tries} tries left");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                }
                else if (guess == answer && tries != 0)
                {

                    tries--;
                    Console.WriteLine($"Correct! You completed the challenge in {8 - tries} tries!");
                    win = true;
                }
                else if (tries == 0)
                {
                    Console.WriteLine("You have no tries left!");
                    win = true;
                }
            
            } while (win == false);
        }
    }

    class Program
    {
        static void Main()
        {
            char again;

            // Loop for repeating the game

            do
            {
                Game.GuessingNumber();
                Console.WriteLine("\n Would you like to play again? (y/n)");
                again = Convert.ToChar(Console.ReadLine());

            }
            while (again == 'y');

            Console.WriteLine("Thank you for playing! \nPress any key to exit.");
            Console.ReadKey();
        }

    }


}
