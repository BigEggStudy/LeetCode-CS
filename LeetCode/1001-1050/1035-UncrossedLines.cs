//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 26.1 MB
// Link: https://leetcode.com/submissions/detail/344727563/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1035_UncrossedLines
    {
        public int MaxUncrossedLines(int[] A, int[] B)
        {
            var rows = A.Length;
            var cols = B.Length;
            var dp = new int[rows + 1, cols + 1];

            for (int i = 1; i <= rows; i++)
                for (int j = 1; j <= cols; j++)
                {
                    if (A[i - 1] == B[j - 1])
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    else
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }

            return dp[rows, cols];
        }
    }
}
