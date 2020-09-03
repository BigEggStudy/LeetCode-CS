//-----------------------------------------------------------------------------
// Runtime: 48ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _059_SpiralMatrix2
    {
        public int[,] GenerateMatrix(int n)
        {
            var result = new int[n, n];
            int start = 0, end = n - 1;
            int num = 1, i;

            while (start < end)
            {
                for (i = start; i < end; i++) result[start, i] = num++;
                for (i = start; i < end; i++) result[i, end] = num++;
                for (i = end; i > start; i--) result[end, i] = num++;
                for (i = end; i > start; i--) result[i, start] = num++;

                start++;
                end--;
            }

            if (start == end) result[start, start] = num;

            return result;
        }
    }
}
