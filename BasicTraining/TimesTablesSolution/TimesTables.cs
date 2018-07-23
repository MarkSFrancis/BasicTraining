using System;
using System.Collections.Generic;

namespace TimesTablesSolution
{
    public static class TimesTables
    {
        public static IEnumerable<int> GetTimesTableFor(int baseNumber, int timesTablesUpTo)
        {
            if (baseNumber < 0)
            {
                throw new ArgumentException();
            }

            for (int times = 1; times <= timesTablesUpTo; ++times)
            {
                yield return baseNumber * times;
            }
        }
    }
}
