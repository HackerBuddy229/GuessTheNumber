using System;
using System.Collections.Generic;

namespace GuessTheNumber
{
    public class RandomNumber
    {
        private int _number;
        private List<int> Guesses;
        private bool WinScenario { get; set; }

        public RandomNumber()
        {
            Guesses = new List<int>();

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

        public void PresentWinStatistics()
        {
            Console.WriteLine("Congratulations, you have won!!!");
            Console.WriteLine("You guessed the following numbers");
            foreach (var guess in Guesses)
            {
                Console.WriteLine(guess);
            }
            
            Console.WriteLine($"totalling a number of {Guesses.Count} guesses");
        }
    }
}