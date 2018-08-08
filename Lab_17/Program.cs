using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Lab_17;
using Microsoft.Win32;

namespace Lab_17
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<int> primeNumbers = new List<int>();
            bool isRunning = true;
            while (isRunning)
            {
                var num = 2;
                do
                {

                    if (IsPrimeNumber(num))
                    {
                        primeNumbers.Add(num);
                    }

                    num++;
                } while (primeNumbers.Count < 100);

                Console.WriteLine("Enter a number betwenn 1 and 100");
                var input = int.Parse(Console.ReadLine());

//            if (input < 1)
//            {
//                throw new Exception("Input cannot be less than 1");
//            }

                input = input - 1;
                Console.WriteLine(primeNumbers[input]);

                if (!PlayAgain.PlayAgainLoop())
                {
                    Console.WriteLine("Have a nice day!");
                    isRunning = false;
                }

                Console.ReadKey();
            }

            

        }

        public static bool IsPrimeNumber(int x)
        {
            if (x < 2)
            {
                return false;
            }

            if (x == 2)
            {
                return true;
            }

            if (x % 2 == 0)
            {
                return false;
            }

            var max = Math.Sqrt(x);
            for (var i = 3; i <= max; i += 2)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }

    
}
