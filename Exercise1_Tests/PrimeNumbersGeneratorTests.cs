using System;
using System.Collections.Generic;
using Exercise1;
using NUnit.Framework;

namespace Exercise1_Tests
{
    [TestFixture]
    public class PrimeNumbersGeneratorTests
    {
        [Test]
        public void GivenZero_ReturnsEmptyResult()
        {
            Assert.That(GenerateNumbers(0), Is.EquivalentTo(new int[] {}));
        }

        [Test]
        public void GivenNegative_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => GenerateNumbers(-1));
        }

        [Test]
        [TestCase(3, new [] { 2 })]
        [TestCase(4, new [] { 2, 3 })]
        public void GivenUpperBound_ReturnsCorrectPrimes(int n, IEnumerable<int> primes)
        {
            Assert.That(GenerateNumbers(n), Is.EquivalentTo(primes));
        }

        private static IEnumerable<int> GenerateNumbers(int n)
        {
            return new PrimeNumbersGenerator().Generate(n);
        }
    }
}
