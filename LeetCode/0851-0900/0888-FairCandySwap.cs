//-----------------------------------------------------------------------------
// Runtime: 308ms
// Memory Usage: 46.2 MB
// Link: https://leetcode.com/submissions/detail/338622172/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _0888_FairCandySwap
    {
        public int[] FairCandySwap(int[] A, int[] B)
        {
            var different = (B.Sum() - A.Sum()) / 2;

            var set = new HashSet<int>(B);
            foreach (var num in A)
            {
                if (set.Contains(num + different))
                    return new int[] { num, num + different };
            }
            return null;
        }
    }
}
