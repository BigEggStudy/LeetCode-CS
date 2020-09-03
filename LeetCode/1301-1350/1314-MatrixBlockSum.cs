//-----------------------------------------------------------------------------
// Runtime: 256ms
// Memory Usage: 33.5 MB
// Link: https://leetcode.com/submissions/detail/360772678/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1314_MatrixBlockSum
    {
        public int[][] MatrixBlockSum(int[][] mat, int K)
        {
            int n = mat.Length, m = mat[0].Length;
            var rangeSum = new int[n + 1, m + 1];
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= m; j++)
                    rangeSum[i, j] = rangeSum[i - 1, j] + rangeSum[i, j - 1] - rangeSum[i - 1, j - 1] + mat[i - 1][j - 1];

            var result = new int[n][];
            for (int i = 0; i < n; i++)
            {
                result[i] = new int[m];
                for (int j = 0; j < m; j++)
                {
                    int r1 = Math.Max(0, i - K), c1 = Math.Max(0, j - K);
                    int r2 = Math.Min(n, i + K + 1), c2 = Math.Min(m, j + K + 1);
                    result[i][j] = rangeSum[r2, c2] - rangeSum[r2, c1] - rangeSum[r1, c2] + rangeSum[r1, c1];
                }
            }

            return result;
        }
    }
}
