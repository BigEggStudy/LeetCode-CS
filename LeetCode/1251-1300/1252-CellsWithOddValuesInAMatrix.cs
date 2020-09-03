//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 24.6 MB
// Link: https://leetcode.com/submissions/detail/327405801/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1252_CellsWithOddValuesInAMatrix
    {
        public int OddCells(int n, int m, int[][] indices)
        {
            var row = new bool[n];
            var col = new bool[m];

            foreach (var indice in indices)
            {
                row[indice[0]] = !row[indice[0]];
                col[indice[1]] = !col[indice[1]];
            }

            var count = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (row[i] != col[j]) count++;

            return count;
        }
    }
}
