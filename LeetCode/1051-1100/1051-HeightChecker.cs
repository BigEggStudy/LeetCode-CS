//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 24.1 MB
// Link: https://leetcode.com/submissions/detail/328771282/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1051_HeightChecker
    {
        public int HeightChecker(int[] heights)
        {
            var sortedHeights = new int[heights.Length];
            heights.CopyTo(sortedHeights, 0);
            Array.Sort(sortedHeights);

            var count = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] != sortedHeights[i])
                    count++;
            }

            return count;
        }
    }
}
