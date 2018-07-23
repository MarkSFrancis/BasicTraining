using System;

namespace SimpleCalculatorSolution
{
    public static class SimpleCalculator
    {
        public static double Calculate(string sum)
        {
            if (sum == null)
            {
                throw new ArgumentNullException();
            }

            var sumParts = sum.Split(' ');
            if (sumParts.Length == 1)
            {
                if (double.TryParse(sumParts[0], out var result))
                {
                    return result;
                }
                else
                {
                    throw new ArgumentException();
                }
            }

            double left, right;
            char operand;

            try
            {
                GetSumParts(sumParts, out left, out operand, out right);
            }
            catch (FormatException)
            {
                throw new InvalidCastException();
            }

            switch (operand)
            {
                case '+':
                    return left + right;
                case '-':
                    return left - right;
                case '*':
                    return left * right;
                case '/':
                    return left / right;
                default:
                    throw new ArgumentOutOfRangeException(nameof(operand));
            }
        }

        private static void GetSumParts(string[] sumParts, out double left, out char operand, out double right)
        {
            if (sumParts.Length != 3)
            {
                throw new ArgumentException();
            }

            left = double.Parse(sumParts[0]);
            operand = sumParts[1][0];
            right = double.Parse(sumParts[2]);
        }

        // Hint: You may want to split out the pieces of the calculator into other methods (one for add, one for subtract etc)
        // Hint 2: You may want to split the functionality to split the string into its 3 parts (number1, operator, number2) into a different method too
    }
}
