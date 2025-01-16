using static DevinetteGameApp.DevinetteGame;

namespace DevinetteGameAppTests
{
    [TestClass]
    public class gameAppTests
    {
        private Devinette _game;

        [TestInitialize]
        public void Setup()
        {
            _game = new Devinette();
        }
        [TestMethod]

        public void Guess_ShouldReturnPlusGrand_WhenGuessIsTooLow()
        {
            // Arrange
            var result = _game.Guess(1);

            // Act & Assert
            Assert.AreEqual("Plus grand !", result);
        }


        [TestMethod]
        public void Guess_ShouldReturnPlusPetit_WhenGuessIsTooHigh()
        {
            // Arrange
            var result = _game.Guess(100);

            // Act & Assert
            Assert.AreEqual("Plus petit !", result);
        }

        [TestMethod]
        public void Guess_ShouldReturnBravo_WhenGuessIsCorrect()
        {
            // Arrange
            var field = typeof(Devinette).GetField("_targetNumber", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            field.SetValue(_game, 50); 

            // Act
            var result = _game.Guess(50);

            // Assert
            Assert.AreEqual("Bravo, vous avez trouvé le bon nombre !", result);
        }


        [TestMethod]
        public void Guess_ShouldReturnError_WhenGuessOutOfRange()
        {
            // Arrange
            var result = _game.Guess(101);

            // Act & Assert
            Assert.AreEqual("Votre nombre doit être entre 1 et 100.", result);
        }

    }
}