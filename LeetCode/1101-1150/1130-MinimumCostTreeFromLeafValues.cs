//-----------------------------------------------------------------------------
// Runtime: 108ms
// Memory Usage: 23.9 MB
// Link: https://leetcode.com/submissions/detail/363969397/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _1130_MinimumCostTreeFromLeafValues
    {
        public int MctFromLeafValues(int[] arr)
        {
            var stack = new Stack<int>();
            stack.Push(int.MaxValue);
            var result = 0;
            foreach (var num in arr)
            {
                while (stack.Peek() <= num)
                {
                    var min = stack.Pop();
                    result += min * Math.Min(stack.Peek(), num);
                }
                stack.Push(num);
            }

            while (stack.Count > 2)
                result += stack.Pop() * stack.Peek();

            return result;
        }
    }
}
