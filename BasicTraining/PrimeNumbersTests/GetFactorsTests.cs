using NUnit.Framework;
using PrimeNumbersSolution;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeNumbersTests
{
    [TestFixture]
    class GetFactorsTests
    {
        [Test]
        public void GetFactors_Of1_DoesNotThrowAnError()
        {
            Assert.DoesNotThrow(() => PrimeNumbers.GetFactors(1));
        }

        [Test]
        public void GetFactors_OfNegativeNumber_ThrowsNotSupportedException()
        {
            Assert.Throws<NotSupportedException>(() => PrimeNumbers.GetFactors(-74), "Negative numbers are not supported. Technically, all negative numbers have the same factors as positive numbers, and positive numbers have both negative and positive factors, but let's keep things simple and not support negative numbers");
        }

        [Test]
        public void GetFactors_Of0_GetsEmptyList()
        {
            var results = PrimeNumbers.GetFactors(0);

            Assert.AreEqual(0, results.Count());
        }

        [Test]
        public void GetFactors_For1_GetsFactors()
        {
            var results = PrimeNumbers.GetFactors(1);

            Assert.AreEqual(
                new List<int> { 1 }, results);
        }

        [Test]
        public void GetFactors_For96_GetsFactors()
        {
            var results = PrimeNumbers.GetFactors(96);

            Assert.AreEqual(
                new List<int> { 1, 2, 3, 4, 6, 8, 12, 16, 24, 32, 48, 96 }, results);
        }

        [Test]
        public void GetFactors_For84_GetsFactors()
        {
            var results = PrimeNumbers.GetFactors(84);

            Assert.AreEqual(
                new List<int> { 1, 2, 3, 4, 6, 7, 12, 14, 21, 28, 42, 84 }, results);
        }
    }
}
