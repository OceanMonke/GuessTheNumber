using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{

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
