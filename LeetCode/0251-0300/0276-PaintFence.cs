//-----------------------------------------------------------------------------
// Runtime: 36ms
// Memory Usage: 14.6 MB
// Link: https://leetcode.com/submissions/detail/358343439/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0276_PaintFence
    {
        public int NumWays(int n, int k)
        {
            if (n == 0) return 0;
            if (n == 1) return k;

            int differentCount = k * (k - 1);
            int sameCount = k;
            for (int i = 2; i < n; i++)
            {
                int temp = differentCount;
                differentCount = (differentCount + sameCount) * (k - 1);
                sameCount = temp;
            }

            return differentCount + sameCount;
        }
    }
}
