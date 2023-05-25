namespace LibraryGame
{
    public class GuessNumberGame
    {
        private readonly int targetNumber;

        public GuessNumberGame()
        {
            targetNumber = GenerateRandomNumber();
        }

        public string Guess(int number)
        {
            if (number < targetNumber)
            {
                return "Number is bigger.";
            }
            else if (number > targetNumber)
            {
                return "Number is smaller.";
            }
            else
            {
                number = GenerateRandomNumber();
                return "Congratulations! You guessed the number.";
            }
        }

        private int GenerateRandomNumber()
        {
            Random random = new Random();
            return random.Next(0, 101);
        }
    }
}
