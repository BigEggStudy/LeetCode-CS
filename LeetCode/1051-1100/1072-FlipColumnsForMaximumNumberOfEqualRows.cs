//-----------------------------------------------------------------------------
// Runtime: 740ms
// Memory Usage: 42.1 MB
// Link: https://leetcode.com/submissions/detail/371131618/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class _1072_FlipColumnsForMaximumNumberOfEqualRows
    {
        public int MaxEqualRowsAfterFlips(int[][] matrix)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;

            var map = new Dictionary<string, int>();
            for (int r = 0; r < rows; r++)
            {
                var sb = new StringBuilder();
                int head = matrix[r][0];
                for (int c = 0; c < cols; c++)
                    sb.Append(head == matrix[r][c] ? '1' : '0');

                var str = sb.ToString();
                if (map.ContainsKey(str))
                    map[str]++;
                else
                    map[str] = 1;
            }

            return map.Values.Max();
        }
    }
}
