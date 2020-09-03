//-----------------------------------------------------------------------------
// Runtime: 48ms
// Memory Usage: 15.6 MB
// Link: https://leetcode.com/submissions/detail/334988973/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _1399_CountLargestGroup
    {
        public int CountLargestGroup(int n)
        {
            var groups = new Dictionary<int, int>();
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int num = i;
                while (num != 0)
                {
                    sum += num % 10;
                    num /= 10;
                }

                if (!groups.ContainsKey(sum))
                    groups[sum] = 0;
                groups[sum]++;
            }

            var maxSize = groups.Max(p => p.Value);
            int result = 0;
            foreach (var g in groups)
            {
                if (g.Value == maxSize)
                    result++;
            }

            return result;
        }
    }
}
