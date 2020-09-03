//-----------------------------------------------------------------------------
// Runtime: 448ms
// Memory Usage: 54 MB
// Link: https://leetcode.com/submissions/detail/342076328/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0901_OnlineStockSpan
    {
        private Stack<int[]> stack = new Stack<int[]>();

        public _0901_OnlineStockSpan()
        {
        }

        public int Next(int price)
        {
            int span = 1;
            while (stack.Count > 0 && stack.Peek()[0] <= price)
                span += stack.Pop()[1];

            stack.Push(new int[] { price, span });
            return span;
        }
    }

    /**
     * Your StockSpanner object will be instantiated and called as such:
     * StockSpanner obj = new StockSpanner();
     * int param_1 = obj.Next(price);
     */
}
