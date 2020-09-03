//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 24.4 MB
// Link: https://leetcode.com/submissions/detail/368370909/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1502_CanMakeArithmeticProgressionFromSequence
    {
        public bool CanMakeArithmeticProgression(int[] arr)
        {
            int min = int.MaxValue, max = int.MinValue, sum = 0;
            foreach (var num in arr)
            {
                min = Math.Min(min, num);
                max = Math.Max(max, num);
                sum += num;
            }

            return sum * 2 == (min + max) * arr.Length;
        }
    }
}
