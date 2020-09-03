//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 24.4 MB
// Link: https://leetcode.com/submissions/detail/358357895/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1037_ValidBoomerang
    {
        public bool IsBoomerang(int[][] points)
        {
            double x1 = points[0][0] - points[1][0], y1 = points[0][1] - points[1][1];
            double x2 = points[0][0] - points[2][0], y2 = points[0][1] - points[2][1];

            if ((x1 == 0 && y1 == 0) || (x2 == 0 && y2 == 0)) return false;
            if (y1 == 0) return y2 != 0;

            return (x1 / y1) != (x2 / y2);
        }
    }
}
