using NUnit.Framework;
using SimpleCalculatorSolution;
using System;

namespace SimpleCalculatorTests
{
    [TestFixture]
    public class SimpleCalculatorTest
    {
        [Test]
        public void DoSum_WithNullSum_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => SimpleCalculator.Calculate(null));
        }

        [Test]
        public void DoSum_WithEmptySum_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => SimpleCalculator.Calculate(string.Empty));
        }

        [Test]
        public void DoSum_WithWhiteSpaceSum_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => SimpleCalculator.Calculate("     "));
        }

        [Test]
        public void DoSum_WithSingleDigit_ReturnsValue()
        {
            var result = SimpleCalculator.Calculate("7");

            Assert.AreEqual(7, result);
        }

        [Test]
        public void DoSum_WithTextSum_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => SimpleCalculator.Calculate("a"));
        }

        [Test]
        public void DoSum_WithOperatorOnly_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => SimpleCalculator.Calculate("/"));
        }

        [Test]
        public void DoSum_WithOperatorAndOneSideOnly_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => SimpleCalculator.Calculate("5 /"));
        }

        [Test]
        public void DoSum_WithOperatorAndOneSideAsNumberAndOneSideAsText_ThrowsInvalidCastException()
        {
            Assert.Throws<InvalidCastException>(() => SimpleCalculator.Calculate("5 / a"));
        }

        [Test]
        public void DoSum_WithIntegerResultDivide_ReturnsResult()
        {
            var result = SimpleCalculator.Calculate("5 / 5");

            Assert.AreEqual(1, result);
        }

        [Test]
        public void DoSum_WithDecimalResultDivide_ReturnsResult()
        {
            var result = SimpleCalculator.Calculate("4 / 5");

            Assert.AreEqual(0.8, result);
        }

        [Test]
        public void DoSum_WithMultiply_ReturnsResult()
        {
            var result = SimpleCalculator.Calculate("5 * 10");

            Assert.AreEqual(50, result);
        }

        [Test]
        public void DoSum_WithAddition_ReturnsResult()
        {
            var result = SimpleCalculator.Calculate("25 + 10");

            Assert.AreEqual(35, result);
        }

        [Test]
        public void DoSum_WithSubtraction_ReturnsResult()
        {
            var result = SimpleCalculator.Calculate("25 - 17");

            Assert.AreEqual(8, result);
        }
    }
}
