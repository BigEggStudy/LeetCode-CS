//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 25.3 MB
// Link: https://leetcode.com/submissions/detail/398960221/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0835_ImageOverlap
    {
        public int LargestOverlap(int[][] img1, int[][] img2)
        {
            int count = 0, N = img1.Length;
            var counts = new int[N * 2, N * 2];
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                {
                    if (img1[i][j] == 0)
                        continue;

                    for (int m = 0; m < N; m++)
                        for (int n = 0; n < N; n++)
                        {
                            if (img2[m][n] == 0)
                                continue;

                            count = Math.Max(count, ++counts[N + i - m, N + j - n]);
                        }
                }

            return count;
        }
    }
}
