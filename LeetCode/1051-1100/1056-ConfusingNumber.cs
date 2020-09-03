//-----------------------------------------------------------------------------
// Runtime: 36ms
// Memory Usage: 14.7 MB
// Link: https://leetcode.com/submissions/detail/344764388/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1056_ConfusingNumber
    {
        public bool ConfusingNumber(int N)
        {
            var map = new Dictionary<int, int>()
            {
                { 0, 0 },
                { 1, 1 },
                { 6, 9 },
                { 8, 8 },
                { 9, 6 },
            };

            var num = N;
            var revert = 0;
            while (num > 0)
            {
                var digit = num % 10;
                if (!map.ContainsKey(digit)) return false;

                revert = revert * 10 + map[digit];
                num /= 10;
            }

            return revert != N;
        }
    }
}
