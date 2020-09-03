//-----------------------------------------------------------------------------
// Runtime: 116ms
// Memory Usage: 28.1 MB
// Link: https://leetcode.com/submissions/detail/371088478/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1504_CountSubmatricesWithAllOnes
    {
        public int NumSubmat(int[][] mat)
        {
            int N = mat.Length;
            int M = mat[0].Length;

            for (int i = 1; i < N; i++)
                for (int j = 0; j < M; j++)
                    if (mat[i][j] != 0)
                        mat[i][j] += mat[i - 1][j];

            int result = 0;
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                {
                    if (mat[i][j] == 0) continue;

                    int min = mat[i][j];
                    for (int k = j; k < M; k++)
                    {
                        min = Math.Min(min, mat[i][k]);
                        if (min == 0) break;
                        result += min;
                    }
                }
            return result;
        }
    }
}
