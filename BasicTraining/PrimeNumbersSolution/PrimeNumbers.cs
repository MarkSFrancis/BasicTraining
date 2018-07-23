using System;
using System.Collections.Generic;

namespace PrimeNumbersSolution
{
    public static class PrimeNumbers
    {
        public static IEnumerable<int> GetFactors(int factorsOf)
        {
            if (factorsOf < 0)
            {
                throw new NotSupportedException();
            }

            if (factorsOf == 0)
            {
                yield break;
            }

            yield return 1;

            for (int curVal = 2; curVal <= factorsOf / 2; ++curVal)
            {
                if (factorsOf % curVal == 0)
                {
                    yield return curVal;
                }
            }

            if (factorsOf > 1)
            {
                yield return factorsOf;
            }
        }

        public static IEnumerable<int> GetNPrimes(int numberOfPrimesToGet)
        {
            if (numberOfPrimesToGet < 0)
            {
                throw new ArgumentException(nameof(numberOfPrimesToGet), "Cannot be less than 0");
            }

            List<int> primes = new List<int>();

            int currentNumber = 1;
            while (primes.Count < numberOfPrimesToGet)
            {
                if (IsAPrimeNumber(++currentNumber, primes))
                {
                    primes.Add(currentNumber);
                }
            }

            return primes;
        }

        public static IEnumerable<int> GetPrimesUpTo(int upTo)
        {
            List<int> primes = new List<int>();

            for (int currentNumber = 2; currentNumber <= upTo; ++currentNumber)
            {
                if (IsAPrimeNumber(currentNumber, primes))
                {
                    primes.Add(currentNumber);
                }
            }

            return primes;
        }

        public static bool IsAPrimeNumber(int isThisAPrime)
        {
            if (isThisAPrime <= 1)
            {
                if (isThisAPrime < 0)
                {
                    throw new NotSupportedException();
                }
                return false;
            }

            for (int curVal = 2; curVal <= isThisAPrime / 2; ++curVal)
            {
                if (isThisAPrime % curVal == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsAPrimeNumber(int number, List<int> primesBelowThis)
        {
            for (int primeIndex = 0; primeIndex < primesBelowThis.Count; ++primeIndex)
            {
                if (number % primesBelowThis[primeIndex] == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
