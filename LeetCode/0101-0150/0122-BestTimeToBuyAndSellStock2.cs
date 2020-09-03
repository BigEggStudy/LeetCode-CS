//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 25.1 MB
// Link: https://leetcode.com/submissions/detail/340984824/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0122_BestTimeToBuyAndSellStock2
    {
        public int MaxProfit(int[] prices)
        {
            var maxProfit = 0;
            for (int i = 1; i < prices.Length; i++)
                maxProfit += Math.Max(0, prices[i] - prices[i - 1]);

            return maxProfit;
        }
    }
}
