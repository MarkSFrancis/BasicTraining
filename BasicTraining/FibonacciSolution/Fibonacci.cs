using System;
using System.Collections.Generic;
using System.Linq;

namespace FibonacciSolution
{
    public static class Fibonacci
    {
        public static IEnumerable<int> DoFibonacciUpTo(int numberUpTo)
        {
            int left = 1, right = 0;

            while (true)
            {
                left += right;

                if (left > numberUpTo)
                {
                    yield break;
                }

                yield return left;

                right += left;
                if (right > numberUpTo)
                {
                    yield break;
                }

                yield return right;
            }
        }

        public static IEnumerable<int> DoFibonacciForNValues(int n)
        {
            int left = 1, right = 0;
            for (int valCount = 0; valCount < n; ++valCount)
            {
                yield return left += right;

                if (++valCount >= n)
                {
                    yield break;
                }

                yield return right += left;
            }
        }

        public static int GetNthFibonacciValue(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException(nameof(n), "Cannot be less than or equal to 0");
            }

            return DoFibonacciForNValues(n).Last();
        }
    }
}
