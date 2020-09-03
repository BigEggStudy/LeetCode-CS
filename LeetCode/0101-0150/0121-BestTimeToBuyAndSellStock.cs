//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 25.4 MB
// Link: https://leetcode.com/submissions/detail/378087252/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0121_BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            int minPrice = int.MaxValue, maxProfit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minPrice) minPrice = prices[i];
                else
                    maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
            }
            return maxProfit;
        }
    }
}
