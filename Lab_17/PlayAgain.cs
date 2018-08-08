using System;

namespace Lab_17
{
    public class PlayAgain
    {
        public static bool PlayAgainLoop()
        {
            Console.WriteLine("Would you like to find another prime number?");
            var response = Console.ReadLine().ToLower();
            if (response.StartsWith("y"))
            {
                return true;
            }

            return false;

        }
    }
}