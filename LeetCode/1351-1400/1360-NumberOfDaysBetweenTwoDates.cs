//-----------------------------------------------------------------------------
// Runtime: 68ms
// Memory Usage: 22.6 MB
// Link: https://leetcode.com/submissions/detail/345105009/
//-----------------------------------------------------------------------------

using System;
using System.Linq;

namespace LeetCode
{
    public class _1360_NumberOfDaysBetweenTwoDates
    {
        public int DaysBetweenDates(string date1, string date2)
        {
            var split1 = date1.Split('-').Select(s => int.Parse(s)).ToArray();
            var split2 = date2.Split('-').Select(s => int.Parse(s)).ToArray();

            return Math.Abs(ComputeDays(split1[0], split1[1], split1[2]) - ComputeDays(split2[0], split2[1], split2[2]));
        }

        private int ComputeDays(int year, int month, int day)
        {
            if (month < 3)
            {
                year--;
                month += 12;
            }

            return year * 365 + year / 400 + year / 4 - year / 100 + day + (153 * month + 8) / 5;
        }
    }
}
