//-----------------------------------------------------------------------------
// Runtime: 476ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _054_SpiralMatrix
    {
        public IList<int> SpiralOrder(int[,] matrix)
        {
            var result = new List<int>();
            var rowLength = matrix.GetLength(0);
            var colLength = matrix.GetLength(1);
            int circle = 0, i, lastCol, lastRow;

            while (true)
            {
                lastCol = colLength - circle - 1;
                lastRow = rowLength - circle - 1;

                for (i = circle; i <= lastCol; i++)
                    result.Add(matrix[circle, i]);
                if (result.Count == matrix.Length) { break; }

                for (i = circle + 1; i < lastRow; i++)
                    result.Add(matrix[i, lastCol]);
                if (result.Count == matrix.Length) { break; }

                for (i = lastCol; i >= circle; i--)
                    result.Add(matrix[lastRow, i]);
                if (result.Count == matrix.Length) { break; }

                for (i = lastRow - 1; i > circle; i--)
                    result.Add(matrix[i, circle]);
                if (result.Count == matrix.Length) { break; }

                circle++;
            }

            return result;
        }
    }
}
