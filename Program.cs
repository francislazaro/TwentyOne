using System;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TwentyOne!");
            Console.WriteLine("Enter your name:");

            string playerName = Console.ReadLine();

            Console.WriteLine("Hello " + playerName + "! Let's play Blackjack.");

            bool playing = true;

            while (playing)
            {
                Console.WriteLine("Playing a round of TwentyOne...");

                Console.WriteLine("Do you want to play again? (yes/no)");
                string answer = Console.ReadLine();

                if (answer.ToLower() != "yes")
                {
                    playing = false;
                }
            }

            Console.WriteLine("Thanks for playing!");
        }
    }
}
