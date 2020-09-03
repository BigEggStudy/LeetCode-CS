//-----------------------------------------------------------------------------
// Runtime: 324ms
// Memory Usage: 46.8 MB
// Link: https://leetcode.com/submissions/detail/384877520/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0497_RandomPointInNonOverlappingRectangles
    {
        private readonly int[][] rects;
        private readonly int totalPointCount;
        private readonly int[] points;
        private readonly Random random;

        public _0497_RandomPointInNonOverlappingRectangles(int[][] rects)
        {
            this.rects = rects;
            points = new int[rects.Length];
            for (int i = 0; i < rects.Length; i++)
            {
                var rect = rects[i];
                totalPointCount += (rect[2] - rect[0] + 1) * (rect[3] - rect[1] + 1);
                points[i] = totalPointCount;
            }

            random = new Random();
        }

        public int[] Pick()
        {
            var target = random.Next(totalPointCount);
            var index = Array.BinarySearch(points, target);
            if (index < 0)
                index = ~index;
            else
                index++;

            var rect = rects[index];
            var width = rect[2] - rect[0] + 1;
            var height = rect[3] - rect[1] + 1;
            var prevPoints = points[index] - width * height;
            return new int[2] { rect[0] + (target - prevPoints) % width, rect[1] + (target - prevPoints) / width };
        }
    }

    /**
     * Your Solution object will be instantiated and called as such:
     * Solution obj = new Solution(rects);
     * int[] param_1 = obj.Pick();
     */
}
