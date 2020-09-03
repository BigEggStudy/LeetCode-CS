//-----------------------------------------------------------------------------
// Runtime: 72ms
// Memory Usage: 22.3 MB
// Link: https://leetcode.com/submissions/detail/344795109/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0409_LongestPalindrome
    {
        public int LongestPalindrome(string s)
        {
            var counts = new Dictionary<int, int>();
            foreach (var ch in s)
            {
                if (!counts.ContainsKey(ch))
                    counts[ch] = 1;
                else
                    counts[ch]++;
            }

            var result = 0;
            var odd = 0;
            foreach (var ch in counts.Keys)
            {
                odd |= counts[ch] & 1;
                result += counts[ch] / 2;
            }

            return result * 2 + odd;
        }
    }
}
