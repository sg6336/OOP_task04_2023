using System;
using LibraryGame;
using NUnit.Framework;

namespace TestGame
{
    [TestFixture]
    public class GuessNumberGameTests
    {
        [Test]
        public void GuessNumber_Game_GuessSmaller()
        {
            GuessNumberGame game = new GuessNumberGame();
            string result = game.Guess(50);
            Assert.AreEqual("Number is smaller.", result);
        }

        [Test]
        public void GuessNumber_Game_GuessBigger()
        {
            GuessNumberGame game = new GuessNumberGame();
            string result = game.Guess(150);
            Assert.AreEqual("Number is bigger.", result);
        }
    }
}
