//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 26.3 MB
// Link: https://leetcode.com/submissions/detail/378114933/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _084_LargestRectangleInHistogram
    {
        public int LargestRectangleArea(int[] heights)
        {
            var stack = new Stack<int>();
            stack.Push(-1);
            int maxArea = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                while (stack.Peek() != -1 && heights[stack.Peek()] >= heights[i])
                    maxArea = Math.Max(maxArea, heights[stack.Pop()] * (i - stack.Peek() - 1));
                stack.Push(i);
            }
            while (stack.Peek() != -1)
                maxArea = Math.Max(maxArea, heights[stack.Pop()] * (heights.Length - stack.Peek() - 1));
            return maxArea;
        }
    }
}
