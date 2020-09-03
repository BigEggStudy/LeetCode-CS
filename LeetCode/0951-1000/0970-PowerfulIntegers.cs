//-----------------------------------------------------------------------------
// Runtime: 200ms
// Memory Usage: 25.6 MB
// Link: https://leetcode.com/submissions/detail/358324921/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _0970_PowerfulIntegers
    {
        public IList<int> PowerfulIntegers(int x, int y, int bound)
        {
            var results = new HashSet<int>();
            for (int i = 1; i < bound; i *= x)
            {
                for (int j = 1; i + j <= bound; j *= y)
                {
                    results.Add(i + j);
                    if (y == 1) break;
                }
                if (x == 1) break;
            }

            return results.ToArray();
        }
    }
}
