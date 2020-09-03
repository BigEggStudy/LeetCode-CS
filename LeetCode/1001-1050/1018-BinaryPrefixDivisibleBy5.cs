//-----------------------------------------------------------------------------
// Runtime: 256ms
// Memory Usage: 34.1 MB
// Link: https://leetcode.com/submissions/detail/351919224/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1018_BinaryPrefixDivisibleBy5
    {
        public IList<bool> PrefixesDivBy5(int[] A)
        {
            var results = new List<bool>(A.Length);
            var current = 0;
            foreach (var digit in A)
            {
                current = (current * 2 + digit) % 5;
                results.Add(current == 0);
            }

            return results;
        }
    }
}
