//-----------------------------------------------------------------------------
// Runtime: 344ms
// Memory Usage: 38.4 MB
// Link: https://leetcode.com/submissions/detail/363974655/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0503_NextGreaterElementII
    {
        public int[] NextGreaterElements(int[] nums)
        {
            var stack = new Stack<int>();
            var n = nums.Length;
            var result = new int[n];
            for (int i = 0; i < n; i++)
                result[i] = -1;

            for (int i = 0; i < n * 2; i++)
            {
                while (stack.Count > 0 && nums[stack.Peek()] < nums[i % n])
                    result[stack.Pop()] = nums[i % n];
                if (i < n)
                    stack.Push(i);
            }

            return result;
        }
    }
}
