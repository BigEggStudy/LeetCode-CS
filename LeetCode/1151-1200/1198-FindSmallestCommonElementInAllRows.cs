//-----------------------------------------------------------------------------
// Runtime: 168ms
// Memory Usage: 36.6 MB
// Link: https://leetcode.com/submissions/detail/360478346/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _1198_FindSmallestCommonElementInAllRows
    {
        public int SmallestCommonElement(int[][] mat)
        {
            int n = mat.Length;
            if (n == 1) return -1;
            int m = mat[0].Length;

            var set = new HashSet<int>();
            for (int i = 0; i < m; i++)
                set.Add(mat[0][i]);

            for (int i = 1; i < n; i++)
            {
                var newSet = new HashSet<int>();
                for (int j = 0; j < m; j++)
                    if (set.Contains(mat[i][j]))
                        newSet.Add(mat[i][j]);

                set = newSet;
            }

            return set.Count > 0 ? set.First() : -1;
        }
    }
}
