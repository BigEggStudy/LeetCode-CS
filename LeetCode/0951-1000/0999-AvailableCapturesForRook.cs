//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 23.8 MB
// Link: https://leetcode.com/submissions/detail/331970361/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0999_AvailableCapturesForRook
    {
        public int NumRookCaptures(char[][] board)
        {
            (var row, var col) = FindRook(board);

            int count = 0;
            for (var i = row - 1; i >= 0; i--)
            {
                if (board[i][col] == 'p')
                {
                    count++;
                    break;
                }
                else if (board[i][col] == 'B')
                    break;
            }
            for (var i = row + 1; i < 8; i++)
            {
                if (board[i][col] == 'p')
                {
                    count++;
                    break;
                }
                else if (board[i][col] == 'B')
                    break;
            }
            for (var i = col - 1; i >= 0; i--)
            {
                if (board[row][i] == 'p')
                {
                    count++;
                    break;
                }
                else if (board[row][i] == 'B')
                    break;
            }
            for (var i = col + 1; i < 8; i++)
            {
                if (board[row][i] == 'p')
                {
                    count++;
                    break;
                }
                else if (board[row][i] == 'B')
                    break;
            }

            return count;
        }

        private (int row, int col) FindRook(char[][] board)
        {
            for (var i = 0; i < 8; i++)
                for (var j = 0; j < 8; j++)
                    if (board[i][j] == 'R')
                        return (i, j);

            return (-1, -1);
        }
    }
}
