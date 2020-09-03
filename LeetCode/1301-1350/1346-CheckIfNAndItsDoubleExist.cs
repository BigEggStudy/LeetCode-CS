//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 25.5 MB
// Link: https://leetcode.com/submissions/detail/358339129/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1346_CheckIfNAndItsDoubleExist
    {
        public bool CheckIfExist(int[] arr)
        {
            var set = new HashSet<int>();
            foreach (var num in arr)
            {
                if (set.Contains(num * 2)) return true;
                if (num % 2 == 0 && set.Contains(num / 2)) return true;
                set.Add(num);
            }

            return false;
        }
    }
}
