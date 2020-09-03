//-----------------------------------------------------------------------------
// Runtime: 100ms
// Memory Usage: 26 MB
// Link: https://leetcode.com/submissions/detail/361640840/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0419_BattleshipsInABoard
    {
        public int CountBattleships(char[][] board)
        {
            int rows = board.Length, cols = board[0].Length;
            var count = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (board[i][j] == 'X')
                    {
                        if ((i == 0 || board[i - 1][j] != 'X') &&
                            (j == 0 || board[i][j - 1] != 'X'))
                            count++;
                    }
                }
            }

            return count;
        }
    }
}
