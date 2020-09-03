//-----------------------------------------------------------------------------
// Runtime: 396ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _051_NQueens
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            CONST_RESULT = new string('.', n);

            var results = new List<IList<string>>();
            var queenColumns = new int[n];
            RecursiveSolver(n, 0, queenColumns, results);

            return results;
        }

        string CONST_RESULT;

        void RecursiveSolver(int n, int currentRow, int[] queenColumns, IList<IList<string>> results)
        {
            if (currentRow == n)
            {
                var result = new List<string>();
                StringBuilder rowString;
                for (int i = 0; i < n; i++)
                {
                    rowString = new StringBuilder(CONST_RESULT, n);
                    rowString[queenColumns[i]] = 'Q';
                    result.Add(rowString.ToString());
                }
                results.Add(result);
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
                RecursiveSolver(n, currentRow + 1, queenColumns, results);
            }
        }
    }
}
