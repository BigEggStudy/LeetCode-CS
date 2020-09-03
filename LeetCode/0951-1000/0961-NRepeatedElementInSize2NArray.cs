//-----------------------------------------------------------------------------
// Runtime: 124ms
// Memory Usage: 32.9 MB
// Link: https://leetcode.com/submissions/detail/328288496/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0961_NRepeatedElementInSize2NArray
    {
        public int RepeatedNTimes(int[] A)
        {
            var set = new HashSet<int>();
            foreach (var num in A)
            {
                if (set.Contains(num))
                    return num;
                else
                    set.Add(num);
            }

            return -1;
        }
    }
}
