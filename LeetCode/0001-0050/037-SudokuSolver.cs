//-----------------------------------------------------------------------------
// Runtime: 168ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _037_SudokuSolver
    {
        bool[,] colUsed = new bool[9, 9];
        bool[,] rowUsed = new bool[9, 9];
        bool[,] squareUsed = new bool[9, 9];

        public void SolveSudoku(char[,] board)
        {
            int row, column, squareId, value;
            for (row = 0; row < 9; row++)
            {
                for (column = 0; column < 9; column++)
                {
                    value = board[row, column] - '0' - 1;
                    if (value > 8 || value < 0) { continue; }
                    squareId = (row / 3) * 3 + column / 3;
                    if (colUsed[column, value] || rowUsed[row, value] || squareUsed[squareId, value]) { return; }

                    colUsed[column, value] = rowUsed[row, value] = squareUsed[squareId, value] = true;
                }
            }

            RecursiveSolver(board, 0, 0);
        }

        bool RecursiveSolver(char[,] boarder, int row, int col)
        {
            if (row == 9) { return true; }
            if (col == 9) { return RecursiveSolver(boarder, row + 1, 0); }
            if (boarder[row, col] != '.') { return RecursiveSolver(boarder, row, col + 1); }

            int squareId;
            for (int i = 0; i < 9; i++)
            {
                squareId = (row / 3) * 3 + col / 3;
                if (colUsed[col, i] || rowUsed[row, i] || squareUsed[squareId, i]) { continue; }

                boarder[row, col] = (char)('1' + i);
                colUsed[col, i] = rowUsed[row, i] = squareUsed[squareId, i] = true;
                if (RecursiveSolver(boarder, row, col + 1))
                {
                    return true;
                }

                boarder[row, col] = '.';
                colUsed[col, i] = rowUsed[row, i] = squareUsed[squareId, i] = false;
            }

            return false;
        }
    }
}
