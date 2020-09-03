//-----------------------------------------------------------------------------
// Runtime: 228ms
// Memory Usage: 30.4 MB
// Link: https://leetcode.com/submissions/detail/361649970/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0885_SpiralMatrixIII
    {
        public int[][] SpiralMatrixIII(int R, int C, int r0, int c0)
        {
            int[] dr = new int[] { 0, 1, 0, -1 };
            int[] dc = new int[] { 1, 0, -1, 0 };

            int[][] result = new int[R * C][];
            int index = 0, direction = 0, step = 2;
            result[index++] = new int[] { r0, c0 };

            while (index < R * C)
            {
                var distance = step / 2;
                for (int i = 0; i < distance; i++)
                {
                    r0 += dr[direction];
                    c0 += dc[direction];

                    if (r0 >= 0 && r0 < R && c0 >= 0 && c0 < C)
                    {
                        result[index++] = new int[] { r0, c0 };
                        if (index == R * C) break;
                    }
                }

                direction++;
                direction %= 4;
                step++;
            }

            return result;
        }
    }
}
