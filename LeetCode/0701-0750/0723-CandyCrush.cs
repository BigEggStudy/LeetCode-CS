//-----------------------------------------------------------------------------
// Runtime: 260ms
// Memory Usage: 32.7 MB
// Link: https://leetcode.com/submissions/detail/361676731/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0723_CandyCrush
    {
        public int[][] CandyCrush(int[][] board)
        {
            int rows = board.Length, cols = board[0].Length;
            var updated = false;

            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols - 2; c++)
                {
                    var value = Math.Abs(board[r][c]);
                    if (value != 0 && value == Math.Abs(board[r][c + 1]) && value == Math.Abs(board[r][c + 2]))
                    {
                        board[r][c] = board[r][c + 1] = board[r][c + 2] = -value;
                        updated = true;
                    }
                }
            for (int r = 0; r < rows - 2; r++)
                for (int c = 0; c < cols; c++)
                {
                    var value = Math.Abs(board[r][c]);
                    if (value != 0 && value == Math.Abs(board[r + 1][c]) && value == Math.Abs(board[r + 2][c]))
                    {
                        board[r][c] = board[r + 1][c] = board[r + 2][c] = -value;
                        updated = true;
                    }
                }

            if (updated)
                for (int c = 0; c < cols; c++)
                {
                    var rowIndex = rows - 1;
                    for (int r = rows - 1; r >= 0; r--)
                        if (board[r][c] > 0)
                            board[rowIndex--][c] = board[r][c];

                    while (rowIndex >= 0)
                        board[rowIndex--][c] = 0;
                }

            return updated ? CandyCrush(board) : board;
        }
    }
}
