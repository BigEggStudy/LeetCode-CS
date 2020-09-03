//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 23.8 MB
// Link: https://leetcode.com/submissions/detail/381927165/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0794_ValidTicTacToeState
    {
        public bool ValidTicTacToe(string[] board)
        {
            int xCount = 0, oCount = 0;
            foreach (string row in board)
                foreach (char ch in row)
                {
                    if (ch == 'X') xCount++;
                    if (ch == 'O') oCount++;
                }

            if (oCount != xCount && oCount != xCount - 1) return false;
            if (Win(board, 'X') && oCount != xCount - 1) return false;
            if (Win(board, 'O') && oCount != xCount) return false;
            return true;
        }

        private bool Win(string[] board, char ch)
        {
            for (int i = 0; i < 3; ++i)
            {
                if (ch == board[0][i] && ch == board[1][i] && ch == board[2][i])
                    return true;
                if (ch == board[i][0] && ch == board[i][1] && ch == board[i][2])
                    return true;
            }

            if (ch == board[0][0] && ch == board[1][1] && ch == board[2][2])
                return true;
            if (ch == board[0][2] && ch == board[1][1] && ch == board[2][0])
                return true;

            return false;
        }
    }
}
