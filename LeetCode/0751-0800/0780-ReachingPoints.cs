//-----------------------------------------------------------------------------
// Runtime: 40ms
// Memory Usage: 14.5 MB
// Link: https://leetcode.com/submissions/detail/375108833/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0780_ReachingPoints
    {
        public bool ReachingPoints(int sx, int sy, int tx, int ty)
        {
            while (tx >= sx && ty >= sy)
            {
                if (tx == ty) break;
                if (tx > ty)
                {
                    if (ty > sy) tx %= ty;
                    else
                        return (tx - sx) % ty == 0;
                }
                else
                {
                    if (tx > sx) ty %= tx;
                    else
                        return (ty - sy) % tx == 0;
                }
            }

            return (tx == sx && ty == sy);
        }
    }
}
