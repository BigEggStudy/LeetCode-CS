//-----------------------------------------------------------------------------
// Runtime: 80ms
// Memory Usage: 22.5 MB
// Link: https://leetcode.com/submissions/detail/333633527/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1185_DayOfTheWeek
    {
        public string DayOfTheWeek(int day, int month, int year)
        {
            return new DateTime(year, month, day).DayOfWeek.ToString();
        }
    }
}
