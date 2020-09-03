//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 24.5 MB	
// Link: https://leetcode.com/submissions/detail/373264619/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0309_BestTimeToBuyAndSellStockWithCooldown
    {
        public int MaxProfit(int[] prices)
        {
            int sold = int.MinValue, held = int.MinValue, reset = 0;

            foreach (var price in prices)
            {
                var temp = sold;

                sold = held + price;
                held = Math.Max(held, reset - price);
                reset = Math.Max(reset, temp);
            }

            return Math.Max(sold, reset);
        }
    }
}
