//-----------------------------------------------------------------------------
// Runtime: 212ms
// Memory Usage: 40.8 MB
// Link: https://leetcode.com/submissions/detail/408811373/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0452_MinimumNumberOfArrowsToBurstBalloons
    {
        public int FindMinArrowShots(int[][] points)
        {
            if (points.Length == 0) return 0;

            Array.Sort(points, (a, b) => a[0].CompareTo(b[0]));

            var result = 1;
            int end = points[0][1];
            foreach (var point in points)
            {
                if (point[0] <= end)
                    end = Math.Min(end, point[1]);
                else
                {
                    result++;
                    end = point[1];
                }
            }

            return result;
        }
    }
}
