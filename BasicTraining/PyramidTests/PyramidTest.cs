using NUnit.Framework;
using PyramidSolution;
using System;

namespace PyramidTests
{
    [TestFixture]
    public class PyramidTest
    {
        [Test]
        public void BuildPyramid_WithNegativeRows_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Pyramid.Build(-1));
        }

        [Test]
        public void BuildPyramid_With0Rows_ReturnsEmptyString()
        {
            var result = Pyramid.Build(0);

            Assert.AreEqual(string.Empty, result);
        }

        [Test]
        public void BuildPyramid_With1Row_ReturnsFlatPyramid()
        {
            var result = Pyramid.Build(1);

            Assert.AreEqual("□", result);
        }

        [Test]
        public void BuildPyramid_With10Rows_ReturnsPyramid()
        {
            var result = Pyramid.Build(10);
            var expected = string.Join(Environment.NewLine,
                new[] {
"         □         ",
"        □□□        ",
"       □□□□□       ",
"      □□□□□□□      ",
"     □□□□□□□□□     ",
"    □□□□□□□□□□□    ",
"   □□□□□□□□□□□□□   ",
"  □□□□□□□□□□□□□□□  ",
" □□□□□□□□□□□□□□□□□ ",
"□□□□□□□□□□□□□□□□□□□"
                });

            Assert.AreEqual(expected, result);
        }
    }
}
