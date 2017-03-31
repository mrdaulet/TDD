using System;
using System.Collections.Generic;

namespace Exercise1
{
    public class PrimeNumbersGenerator
    {
        public IEnumerable<int> Generate(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (n > 2)
            {
                return new[] {2};
            }

            return new int[] {};
        }
    }
}
