using System;
using System.Collections.Generic;

namespace Exercise1
{
    public class PrimeNumbersGenerator
    {
        public IEnumerable<int> Generate(int upperBound)
        {
            if (upperBound < 0 || upperBound > 1000)
            {
                throw new ArgumentOutOfRangeException();
            }

            var primes = new List<int>();
            for (int number = 2; number < upperBound; number++)
            {
                bool divisible = false;
                for (int divisor = 2; divisor < number; divisor++)
                {
                    if (number % divisor == 0)
                    {
                        divisible = true;
                        break;
                    }
                }
                if (!divisible)
                {
                    primes.Add(number);
                }
            }

            return primes;
        }
    }
}
