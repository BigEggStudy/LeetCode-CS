//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 24.2 MB
// Link: https://leetcode.com/submissions/detail/338613393/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0812_LargestTriangleArea
    {
        public double LargestTriangleArea(int[][] points)
        {
            int N = points.Length;
            double ans = 0;
            for (int i = 0; i < N; ++i)
                for (int j = i + 1; j < N; ++j)
                    for (int k = j + 1; k < N; ++k)
                        ans = Math.Max(ans, Area(points[i], points[j], points[k]));
            return ans;
        }

        private double Area(int[] A, int[] B, int[] C)
        {
            return 0.5 * Math.Abs(A[0] * B[1] + B[0] * C[1] + C[0] * A[1] - A[1] * B[0] - B[1] * C[0] - C[1] * A[0]);
        }
    }
}
