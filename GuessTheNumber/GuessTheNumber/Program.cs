using System;

namespace GuessTheNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            var randomNumber = new RandomNumber();

            while (!randomNumber.Won())
            {
                try
                {
                    var guess = Convert.ToInt32(Console.ReadLine());
                    var result = randomNumber.Guess(guess);
                    Console.WriteLine(result);

                    if (result == "you are right" && randomNumber.Won())
                    {
                        randomNumber.PresentWinStatistics();
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