//-----------------------------------------------------------------------------
// Runtime: 
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0289_GameOfLife
    {
        public void GameOfLife(int[][] board)
        {
            int[] neighbors = { 0, 1, -1 };

            int rowsCount = board.Length;
            int colsCount = board[0].Length;

            for (int row = 0; row < rowsCount; row++)
                for (int col = 0; col < colsCount; col++)
                {
                    int liveNeighbors = 0;

                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            if (!(neighbors[i] == 0 && neighbors[j] == 0))
                            {
                                int r = (row + neighbors[i]);
                                int c = (col + neighbors[j]);

                                if ((r < rowsCount && r >= 0) && (c < colsCount && c >= 0) && (Math.Abs(board[r][c]) == 1))
                                    liveNeighbors += 1;
                            }

                    if ((board[row][col] == 1) && (liveNeighbors < 2 || liveNeighbors > 3))
                        board[row][col] = -1;
                    if (board[row][col] == 0 && liveNeighbors == 3)
                        board[row][col] = 2;
                }

            for (int row = 0; row < rowsCount; row++)
                for (int col = 0; col < colsCount; col++)
                    if (board[row][col] > 0)
                        board[row][col] = 1;
                    else
                        board[row][col] = 0;
        }
    }
}
