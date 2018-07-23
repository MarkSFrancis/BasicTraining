using NUnit.Framework;
using System;
using System.Collections.Generic;
using TimesTablesSolution;

namespace TimesTablesTests
{
    [TestFixture]
    public class TimesTablesTest
    {
        [Test]
        public void TimesTable_ContainingPositiveNumbers_DoesNotThrowAnError()
        {
            Assert.DoesNotThrow(() => TimesTables.GetTimesTableFor(1, 1));
        }

        [Test]
        public void TimesTable_ContainingNegativeBase_DoesNotThrowAnError()
        {
            Assert.DoesNotThrow(() => TimesTables.GetTimesTableFor(-1, 1));
        }

        [Test]
        public void TimesTable_ContainingNegativeBase_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => TimesTables.GetTimesTableFor(-1, 1));
        }

        [Test]
        public void TimesTable_For1UpTo1_GetsTimesTable()
        {
            Assert.AreEqual(
                new List<int> { 1 },
                TimesTables.GetTimesTableFor(1, 1));
        }

        [Test]
        public void TimesTable_ForMinus1UpTo1_GetsTimesTable()
        {
            Assert.AreEqual(
                new List<int> { -1 },
                TimesTables.GetTimesTableFor(-1, 1));
        }

        [Test]
        public void TimesTable_For5UpTo12_GetsTimesTable()
        {
            Assert.AreEqual(
                new List<int> { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60 },
                TimesTables.GetTimesTableFor(5, 12));
        }

        [Test]
        public void TimesTable_ForMinus5UpTo12_GetsTimesTable()
        {
            Assert.AreEqual(
                new List<int> { -5, -10, -15, -20, -25, -30, -35, -40, -45, -50, -55, -60 },
                TimesTables.GetTimesTableFor(-5, 12));
        }
    }
}
