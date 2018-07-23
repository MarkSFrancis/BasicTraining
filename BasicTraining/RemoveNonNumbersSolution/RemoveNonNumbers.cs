using System;

namespace RemoveNonNumbersSolution
{
    public static class RemoveNonNumbers
    {
        public static int Remove(string removeFrom)
        {
            if (removeFrom == null)
            {
                throw new ArgumentNullException(nameof(removeFrom));
            }

            int number = 0;
            bool containsDigit = false;
            for (int charIndex = 0; charIndex < removeFrom.Length; ++charIndex)
            {
                if (char.IsDigit(removeFrom[charIndex]))
                {
                    try
                    {
                        number = checked((number * 10) + removeFrom[charIndex] - 48);
                    }
                    catch (OverflowException)
                    {
                        throw new InvalidCastException("Number is too large");
                    }

                    containsDigit = true;
                }
            }

            if (!containsDigit)
            {
                throw new InvalidCastException(nameof(removeFrom) + " contains no digits");
            }
            return number;
        }
    }
}
