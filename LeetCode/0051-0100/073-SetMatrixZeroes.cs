//-----------------------------------------------------------------------------
// Runtime: 184ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _073_SetMatrixZeroes
    {
        public void SetZeroes(int[,] matrix)
        {
            var rowLength = matrix.GetLength(0);
            var columnLenght = matrix.GetLength(1);

            var rowZero = new bool[rowLength];
            var columnZero = new bool[columnLenght];

            int i, j;
            for (i = 0; i < rowLength; i++)
                for (j = 0; j < columnLenght; j++)
                    if (matrix[i, j] == 0)
                    {
                        rowZero[i] = true;
                        columnZero[j] = true;
                    }

            for (i = 0; i < rowLength; i++)
                for (j = 0; j < columnLenght; j++)
                    if (rowZero[i] || columnZero[j])
                        matrix[i, j] = 0;
        }

        public void SetZeroes_2(int[,] matrix)
        {
            var rowLength = matrix.GetLength(0);
            var columnLenght = matrix.GetLength(1);

            var firstRowHasZero = false;
            var firstColumnHasZero = false;

            int i, j;
            for (i = 0; i < rowLength; i++)
                if (matrix[i, 0] == 0) { firstColumnHasZero = true; break; }
            for (i = 0; i < columnLenght; i++)
                if (matrix[0, i] == 0) { firstRowHasZero = true; break; }

            for (i = 1; i < rowLength; i++)
                for (j = 1; j < columnLenght; j++)
                    if (matrix[i, j] == 0)
                        matrix[0, j] = matrix[i, 0] = 0;

            for (i = 1; i < rowLength; i++)
                for (j = 1; j < columnLenght; j++)
                    if (matrix[i, 0] == 0 || matrix[0, j] == 0)
                        matrix[i, j] = 0;
            if (firstRowHasZero)
                for (i = 0; i < columnLenght; i++)
                    matrix[0, i] = 0;
            if (firstColumnHasZero)
                for (i = 0; i < rowLength; i++)
                    matrix[i, 0] = 0;
        }
    }
}
