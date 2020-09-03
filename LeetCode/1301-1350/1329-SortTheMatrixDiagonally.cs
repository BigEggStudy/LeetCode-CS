//-----------------------------------------------------------------------------
// Runtime: 292MS
// Memory Usage: 33.6 MB
// Link: https://leetcode.com/submissions/detail/360444219/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _1329_SortTheMatrixDiagonally
    {
        public int[][] DiagonalSort(int[][] mat)
        {
            int n = mat.Length;
            int m = mat[0].Length;

            var map = new Dictionary<int, SortedDictionary<int, int>>();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    if (!map.ContainsKey(i - j))
                        map[i - j] = new SortedDictionary<int, int>();
                    if (map[i - j].ContainsKey(mat[i][j]))
                        map[i - j][mat[i][j]]++;
                    else
                        map[i - j][mat[i][j]] = 1;
                }

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    int value = map[i - j].Keys.First();
                    map[i - j][value]--;
                    if (map[i - j][value] == 0)
                        map[i - j].Remove(value);

                    mat[i][j] = value;
                }

            return mat;
        }
    }
}
