//-----------------------------------------------------------------------------
// Runtime: 236ms
// Memory Usage: 31.5 MB
// Link: https://leetcode.com/submissions/detail/358278882/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1475_FinalPricesWithASpecialDiscountInAShop
    {
        public int[] FinalPrices(int[] prices)
        {
            var stack = new Stack<int>();
            for (var i = 0; i < prices.Length; i++)
            {
                while (stack.Count > 0 && prices[stack.Peek()] >= prices[i])
                    prices[stack.Pop()] -= prices[i];

                stack.Push(i);
            }

            return prices;
        }
    }
}
