using NUnit.Framework;
using PrimeNumbersSolution;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeNumbersTests
{
    [TestFixture]
    class GetNPrimesTests
    {
        [Test]
        public void GetNPrimes_1Prime_DoesNotThrowAnError()
        {
            Assert.DoesNotThrow(() => PrimeNumbers.GetNPrimes(1));
        }

        [Test]
        public void GetNPrimes_NegativeNumberOfPrimes_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => PrimeNumbers.GetNPrimes(-1));
        }

        [Test]
        public void GetNPrimes_0Primes_ReturnsEmptyList()
        {
            var results = PrimeNumbers.GetNPrimes(0);

            Assert.AreEqual(0, results.Count());
        }

        [Test]
        public void GetNPrimes_1Prime_GetsPrimes()
        {
            var results = PrimeNumbers.GetNPrimes(1);

            Assert.AreEqual(
                new List<int> { 2 }, results);
        }

        [Test]
        public void GetNPrimes_For3_GetsPrimes()
        {
            var results = PrimeNumbers.GetNPrimes(3);

            Assert.AreEqual(
                new List<int> { 2, 3, 5 }, results);
        }

        [Test]
        public void GetNPrimes_16Primes_GetsPrimes()
        {
            var results = PrimeNumbers.GetNPrimes(16);

            Assert.AreEqual(
                new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53 }, results);
        }
    }
}
