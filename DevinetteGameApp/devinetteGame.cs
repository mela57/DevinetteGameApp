using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevinetteGameApp
{
    public class DevinetteGame
    {
        public class Devinette
        {
            private readonly int _targetNumber;
            private int _attempts;

            public Devinette()
            {
                var random = new Random();
                _targetNumber = random.Next(1, 101); 
                _attempts = 0;
            }

            public int Attempts => _attempts;

            public string Guess(int playerGuess)
            {
                _attempts++;

                if (playerGuess < 1 || playerGuess > 100)
                    return "Votre nombre doit être entre 1 et 100.";

                if (playerGuess < _targetNumber)
                    return "Plus grand !";

                if (playerGuess > _targetNumber)
                    return "Plus petit !";

                return "Bravo, vous avez trouvé le bon nombre !";
            }
        }

    }
}
