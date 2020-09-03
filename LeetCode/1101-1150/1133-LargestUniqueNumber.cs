//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 24.9 MB
// Link: https://leetcode.com/submissions/detail/330730484/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1133_LargestUniqueNumber
    {
        public int LargestUniqueNumber(int[] A)
        {
            if (A.Length == 1) return A[0];

            var list = new Dictionary<int, int>();
            foreach (var num in A)
            {
                if (list.ContainsKey(num))
                    list[num]++;
                else
                    list.Add(num, 1);
            }

            int max = -1;
            foreach (var key in list.Keys)
            {
                if (list[key] == 1 && max < key)
                    max = key;
            }

            return max;
        }
    }
}
