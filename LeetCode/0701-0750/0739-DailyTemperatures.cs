//-----------------------------------------------------------------------------
// Runtime: 328ms
// Memory Usage: 41.6 MB
// Link: https://leetcode.com/submissions/detail/369513240/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0739_DailyTemperatures
    {
        public int[] DailyTemperatures(int[] T)
        {
            var stack = new Stack<int>();
            var result = new int[T.Length];
            for (int i = T.Length - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && T[i] >= T[stack.Peek()])
                    stack.Pop();
                result[i] = stack.Count == 0 ? 0 : (stack.Peek() - i);
                stack.Push(i);
            }

            return result;
        }
    }
}
