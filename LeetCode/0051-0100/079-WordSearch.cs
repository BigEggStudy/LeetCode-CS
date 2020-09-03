//-----------------------------------------------------------------------------
// Runtime: 148ms
// Memory Usage: 28.7 MB
// Link: https://leetcode.com/submissions/detail/369734401/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _079_WordSearch
    {
        public bool Exist(char[][] board, string word)
        {
            int R = board.Length, C = board[0].Length;
            var used = new bool[R, C];

            int i, j;
            for (i = 0; i < R; i++)
                for (j = 0; j < C; j++)
                    if (Exist(board, word, 0, i, j, used))
                        return true;

            return false;
        }

        private bool Exist(char[][] board, string word, int index, int row, int column, bool[,] used)
        {
            int R = board.Length, C = board[0].Length;
            if (board[row][column] != word[index] || used[row, column]) { return false; }

            used[row, column] = true;
            index++;

            if (index == word.Length) { return true; }

            if ((row + 1 < R && Exist(board, word, index, row + 1, column, used)) ||
                (row > 0 && Exist(board, word, index, row - 1, column, used)) ||
                (column + 1 < C && Exist(board, word, index, row, column + 1, used)) ||
                (column > 0 && Exist(board, word, index, row, column - 1, used)))
            {
                return true;
            }

            used[row, column] = false;
            return false;
        }
    }
}
