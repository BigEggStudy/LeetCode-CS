//-----------------------------------------------------------------------------
// Runtime: 160ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _063_UniquePaths2
    {
        public int UniquePathsWithObstacles(int[,] obstacleGrid)
        {
            var rowLenght = obstacleGrid.GetLength(0);
            var columnLenght = obstacleGrid.GetLength(1);

            if (rowLenght <= columnLenght)
            {
                var possiblePath = new int[rowLenght];
                possiblePath[0] = obstacleGrid[0, 0] == 0 ? 1 : 0;

                for (int i = 0; i < columnLenght; i++)
                    for (int j = 0; j < rowLenght; j++)
                        possiblePath[j] = obstacleGrid[j, i] == 1
                            ? 0
                            : j != 0 ? possiblePath[j - 1] + possiblePath[j] : possiblePath[j];

                return possiblePath[rowLenght - 1];
            }
            else
            {
                var possiblePath = new int[columnLenght];
                possiblePath[0] = obstacleGrid[0, 0] == 0 ? 1 : 0;

                for (int i = 0; i < rowLenght; i++)
                    for (int j = 0; j < columnLenght; j++)
                        possiblePath[j] = obstacleGrid[i, j] == 1
                            ? 0
                            : j != 0 ? possiblePath[j - 1] + possiblePath[j] : possiblePath[j];

                return possiblePath[columnLenght - 1];
            }
        }
    }
}
