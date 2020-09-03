//-----------------------------------------------------------------------------
// Runtime: 260ms
// Memory Usage: 33.5 MB
// Link: https://leetcode.com/submissions/detail/328314479/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _1380_LuckyNumbersInAMatrix
    {
        public IList<int> LuckyNumbers(int[][] matrix)
        {
            var row = matrix.Length;
            var col = matrix[0].Length;

            var row_min = new int[row];
            for (int i = 0; i < row; i++)
                row_min[i] = int.MaxValue;
            var col_max = new int[col];
            for (int i = 0; i < col; i++)
                col_max[i] = int.MinValue;

            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                {
                    row_min[i] = Math.Min(row_min[i], matrix[i][j]);
                    col_max[j] = Math.Max(col_max[j], matrix[i][j]);
                }

            var result = new List<int>();
            var set = new HashSet<int>(row_min);
            for (int i = 0; i < col; i++)
            {
                if (set.Contains(col_max[i]))
                    result.Add(col_max[i]);
            }

            return result;
        }
    }
}
