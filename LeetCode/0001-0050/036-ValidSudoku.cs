//-----------------------------------------------------------------------------
// Runtime: 160ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _036_ValidSudoku
    {
        public bool IsValidSudoku(char[,] board)
        {
            int row, column, squareId, value;
            var colUsed = new bool[9, 9];
            var rowUsed = new bool[9, 9];
            var squareUsed = new bool[9, 9];

            for (row = 0; row < 9; row++)
            {
                for (column = 0; column < 9; column++)
                {
                    value = board[row, column] - '0' - 1;
                    if (value > 8 || value < 0) { continue; }
                    squareId = (row / 3) * 3 + column / 3;
                    if (colUsed[column, value] || rowUsed[row, value] || squareUsed[squareId, value]) { return false; }

                    colUsed[column, value] = rowUsed[row, value] = squareUsed[squareId, value] = true;
                }
            }

            return true;
        }
    }
}
