//-----------------------------------------------------------------------------
// Runtime: 248ms
// Memory Usage: 32.9 MB
// Link: https://leetcode.com/submissions/detail/330131749/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1337_TheKWeakestRowsInAMatrix
    {
        public int[] KWeakestRows(int[][] mat, int k)
        {
            int m = mat.Length;
            int n = mat[0].Length;

            int[] results = new int[k];
            int count = 0;
            for (int col = 0; col < n && count < k; col++)
                for (int row = 0; row < m && count < k; row++)
                {
                    if (mat[row][col] == 0 && (col == 0 || mat[row][col - 1] == 1))
                    {
                        results[count] = row;
                        count++;
                    }
                }

            for (int row = 0; count < k; row++)
                if (mat[row][n - 1] == 1)
                {
                    results[count] = row;
                    count++;
                }

            return results;
        }
    }
}
