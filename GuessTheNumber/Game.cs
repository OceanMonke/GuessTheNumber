using System;

namespace GuessTheNumber
{
    static class Game
    {

        // Method that catches an exception if user enters an invalid variable
        public static int GetGuess()
        {

            Console.WriteLine("Your guess:");
            var input = Console.ReadLine();

            try
            {
                var guess = Convert.ToInt32(input);
                return guess;
            }
            catch (Exception)
            {
                Console.WriteLine("This is not a valid guess.");
                return GetGuess();
            }
            
        }

        //Method for the mechanics of the game
        public static void GuessingNumber()
        {
            bool win = false;
            int tries = 8;

            Random rnd = new Random();
            var answer = rnd.Next(1, 101);

            Console.WriteLine("\n Guess a number from 1 to 100. Can you do it in less than 8 tries?");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            do
            {
                var guess = GetGuess();

                if (guess > answer && tries != 0)
                {

                    Console.WriteLine("The answer is lower.");
                    Console.WriteLine($"You have {--tries} tries left");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                }
                else if (guess < answer && tries != 0)
                {

                    Console.WriteLine("The answer is higher.");
                    Console.WriteLine($"You have {--tries} tries left");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                }
                else if (guess == answer && tries != 0)
                {

                    Console.WriteLine($"Correct! You completed the challenge in {8 - (--tries)} tries!");
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


}
