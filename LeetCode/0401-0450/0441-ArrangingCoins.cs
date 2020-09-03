//-----------------------------------------------------------------------------
// Runtime: 40ms
// Memory Usage: 14.6 MB
// Link: https://leetcode.com/submissions/detail/352955327/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0441_ArrangingCoins
    {
        public int ArrangeCoins(int n)
        {
            return (int)(Math.Sqrt(2 * (long)n + 0.25) - 0.5);
        }
    }
}
