using System;
using LibraryGame;

namespace ConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;

            Console.WriteLine("Game “Guess number”");

            while (playAgain)
            {
                GuessNumberGame game = new GuessNumberGame();
                Console.WriteLine("Try to guess the number from 0 to 100 (inclusive)");

                bool guessedCorrectly = false;

                while (!guessedCorrectly)
                {
                    Console.Write("Enter your guess: ");
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out int guess))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        continue;
                    }

                    string result = game.Guess(guess);
                    Console.WriteLine(result);

                    if (result.StartsWith("Congratulations"))
                    {
                        guessedCorrectly = true;
                    }
                }

                Console.WriteLine("Do you want to play again? (yes/no)");
                string playAgainInput = Console.ReadLine();

                playAgain = (playAgainInput.ToLower() == "yes");
                Console.WriteLine();
            }
        }
    }
}
