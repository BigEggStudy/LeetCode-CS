//-----------------------------------------------------------------------------
// Runtime: 120ms
// Memory Usage: 28.6 MB
// Link: https://leetcode.com/submissions/detail/378115442/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _085_MaximalRectangle
    {
        public int MaximalRectangle(char[][] matrix)
        {
            if (matrix.Length == 0) return 0;

            int N = matrix.Length;
            int M = matrix[0].Length;

            int[] heights = new int[M];
            var maxArea = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                    heights[j] = matrix[i][j] == '1' ? heights[j] + 1 : 0;
                maxArea = Math.Max(maxArea, ComputeLargestRectangle(heights));
            }

            return maxArea;
        }

        private int ComputeLargestRectangle(int[] heights)
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
