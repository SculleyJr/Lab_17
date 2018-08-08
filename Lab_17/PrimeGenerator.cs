using System;
using System.Collections.Generic;


namespace Lab_17
{
    public class PrimeGenerator
    {
        public string PrimeNumberGenerator(int num)
        {
            List<int> primeNumbers = new List<int>();
            if (num < 2)
            {
                throw new Exception("Sorry but 2 is the first prime number");
            }

            if (num % 2 == 0 && num != 2)
            {
                throw new Exception("Even numbers after 2 are not prime");
            }

            if (num == int.MaxValue)
            {
                throw new Exception("Sorry but that is out of range of a 32 bit integer");
            }
            throw new NotImplementedException();
        }
    }
}