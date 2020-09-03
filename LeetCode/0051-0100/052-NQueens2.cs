//-----------------------------------------------------------------------------
// Runtime: 52ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _052_NQueens2
    {
        public int TotalNQueens(int n)
        {
            int result = 0;
            var queenColumns = new int[n];
            RecursiveSolver(n, 0, queenColumns, ref result);

            return result;
        }

        void RecursiveSolver(int n, int currentRow, int[] queenColumns, ref int result)
        {
            if (currentRow == n)
            {
                result++;
                return;
            }

            bool isValid = true;
            for (int col = 0; col < n; col++)
            {
                isValid = true;
                for (int i = 0; i < currentRow; i++)
                {
                    if (queenColumns[i] == col || Math.Abs(col - queenColumns[i]) == Math.Abs(currentRow - i))
                    {
                        isValid = false;
                        break;
                    }
                }
                if (!isValid) continue;

                queenColumns[currentRow] = col;
                RecursiveSolver(n, currentRow + 1, queenColumns, ref result);
            }
        }
    }
}
