using System;
using System.Linq;

namespace SmallestBiggestSolution
{
    public static class SmallestBiggest
    {
        public static int GetSmallest(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                throw new ArgumentException();
            }

            return numbers.Min();
        }

        public static int GetBiggest(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                throw new ArgumentException();
            }

            return numbers.Max();
        }
    }
}
