//-----------------------------------------------------------------------------
// Runtime: 80ms
// Memory Usage: 26.2 MB
// Link: https://leetcode.com/submissions/detail/326872389/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1266_MinimumTimeVisitingAllPoints
    {
        public int MinTimeToVisitAllPoints(int[][] points)
        {
            var result = 0;
            for (int i = 1; i < points.Length; i++)
                result += Math.Max(
                    Math.Abs(points[i][0] - points[i - 1][0]),
                    Math.Abs(points[i][1] - points[i - 1][1]));

            return result;
        }
    }
}
