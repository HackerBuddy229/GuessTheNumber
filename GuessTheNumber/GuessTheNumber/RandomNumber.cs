using System;
using System.Collections.Generic;

namespace GuessTheNumber
{
    public class RandomNumber
    {
        private int _number;
        private List<int> Guesses { get; set; }
        private bool WinScenario { get; set; }

        public RandomNumber()
        {

            WinScenario = false;
            InitNumber();
        }

        public bool Won()
        {
            return WinScenario;
        }

        private void InitNumber()
        {
            var rd = new Random();
            _number = rd.Next(maxValue:500);
        }


        public string Guess(int guess)
        {
            Guesses.Add(guess);
            if (guess < _number)
            {
                return "bigger";
            } else if (guess > _number)
            {
                return "smaller";
            }
            else if (guess == _number)
            {
                WinScenario = true;
                return "you are right";
            }
            else
            {
                throw new SystemException();
            }
        }

        public void presentWinStatistics()
        {
            throw new NotImplementedException();
        }
    }
}