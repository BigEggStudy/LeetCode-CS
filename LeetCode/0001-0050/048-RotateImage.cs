//-----------------------------------------------------------------------------
// Runtime: 148ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _048_RotateImage
    {
        public void Rotate(int[,] matrix)
        {
            int i, j, temp;
            var lenght = matrix.GetLength(1);

            for (i = 0; i < lenght / 2; i++)
            {
                for (j = i; j < lenght - i - 1; j++)
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[lenght - j - 1, i];
                    matrix[lenght - j - 1, i] = matrix[lenght - i - 1, lenght - j - 1];
                    matrix[lenght - i - 1, lenght - j - 1] = matrix[j, lenght - i - 1];
                    matrix[j, lenght - i - 1] = temp;
                }
            }
        }
    }
}
