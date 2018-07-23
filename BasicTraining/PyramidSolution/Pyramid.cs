using System;
using System.Collections.Generic;

namespace PyramidSolution
{
    public class Pyramid
    {
        public const char PyramidBlock = '□';

        public static string Build(int rows)
        {
            List<string> pyramid = new List<string>(rows);

            for (var spaceChars = rows - 1; spaceChars >= 0; --spaceChars)
            {
                string spacer = new string(' ', spaceChars);
                string pyramidRow = new string(PyramidBlock, ((rows - spaceChars) * 2) - 1);

                pyramid.Add(spacer + pyramidRow + spacer);
            }

            return string.Join(Environment.NewLine, pyramid);
        }
    }
}
