//-----------------------------------------------------------------------------
// Runtime: 164ms
// Memory Usage: 39.9 MB
// Link: https://leetcode.com/submissions/detail/370195128/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1375_BulbSwitcherIII
    {
        public int NumTimesAllBlue(int[] light)
        {
            int last_on = 0;
            int result = 0;

            for (int i = 0; i < light.Length; i++)
            {
                last_on = Math.Max(last_on, light[i]);
                if (last_on == i + 1) result++;
            }

            return result;
        }
    }
}
