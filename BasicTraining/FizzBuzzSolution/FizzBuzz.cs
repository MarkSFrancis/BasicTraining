using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzSolution
{
    public class FizzBuzz
    {
        public static IEnumerable<string> PlayFizzBuzzUpTo(int upTo)
        {
            return PlayFizzBuzz2UpTo(upTo, new Dictionary<int, string>
            {
                { 3, "Fizz" },
                { 5, "Buzz" }
            });
        }

        public static IEnumerable<string> PlayFizzBuzz2UpTo(int upTo, IDictionary<int, string> fizzBuzzSettings)
        {
            var settings = fizzBuzzSettings.OrderBy(s => s.Key).ToList();

            for (int curNum = 1; curNum <= upTo; ++curNum)
            {
                StringBuilder val = new StringBuilder();
                foreach (var setting in settings)
                {
                    if (curNum % setting.Key == 0)
                    {
                        val.Append(setting.Value);
                    }
                }

                yield return val.Length > 0 ? val.ToString() : curNum.ToString();
            }
        }
    }
}