//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 23.9 MB
// Link: https://leetcode.com/submissions/detail/352837509/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0198_HouseRobber
    {
        public int Rob(int[] nums)
        {
            int p2Amount = 0, p1Amount = 0;

            foreach (var money in nums)
            {
                var currentAmount = Math.Max(p2Amount + money, p1Amount);
                p2Amount = p1Amount;
                p1Amount = currentAmount;
            }

            return p1Amount;
        }
    }
}
