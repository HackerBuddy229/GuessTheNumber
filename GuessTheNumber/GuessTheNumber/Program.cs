using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomNumber = new RandomNumber();

            while (randomNumber.Won())
            {
                try
                {
                    var guess = Convert.ToInt32(Console.ReadLine());
                    var result = randomNumber.Guess(guess:guess);

                    if (result == "you are right" && randomNumber.Won())
                    {
                        randomNumber.presentWinStatistics();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Invalid number {e}");
                    continue;
                }
                
            }
        }
    }
}