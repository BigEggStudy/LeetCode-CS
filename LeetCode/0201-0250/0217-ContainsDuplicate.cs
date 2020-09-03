//-----------------------------------------------------------------------------
// Runtime: 112ms
// Memory Usage: 31.4 MB
// Link: https://leetcode.com/submissions/detail/342501480/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0217_ContainsDuplicate
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var set = new HashSet<int>();
            foreach (var num in nums)
            {
                if (set.Contains(num)) return true;
                set.Add(num);
            }
            return false;
        }
    }
}
