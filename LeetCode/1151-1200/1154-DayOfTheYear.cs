//-----------------------------------------------------------------------------
// Runtime: 80ms
// Memory Usage: 22.6 MB
// Link: https://leetcode.com/submissions/detail/351839198/
//-----------------------------------------------------------------------------

using System.Linq;

namespace LeetCode
{
    public class _1154_DayOfTheYear
    {
        public int DayOfYear(string date)
        {
            var days = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            var split = date.Split('-').Select(s => int.Parse(s)).ToArray();
            var year = split[0];
            var count = 0;

            for (int i = 0; i < 12; i++)
            {
                if (split[1] == i + 1)
                {
                    count += split[2];
                    break;
                }
                else
                {
                    count += days[i];
                }
            }

            if (split[1] > 2)
                if ((year % 400 == 0) || (year % 100 != 0 && year % 4 == 0)) count++;


            return count;
        }
    }
}
