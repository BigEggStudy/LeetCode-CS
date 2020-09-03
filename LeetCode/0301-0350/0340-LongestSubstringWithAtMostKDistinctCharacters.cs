//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 22.6 MB
// Link: https://leetcode.com/submissions/detail/373794812/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _0340_LongestSubstringWithAtMostKDistinctCharacters
    {
        public int LengthOfLongestSubstringKDistinct(string s, int k)
        {
            var counts = new Dictionary<char, int>();
            int left = 0, right = 0, maxLength = 0;
            while (right < s.Length)
            {
                if (counts.ContainsKey(s[right]))
                    counts[s[right]]++;
                else
                    counts[s[right]] = 1;

                while (counts.Count > k)
                {
                    counts[s[left]]--;
                    if (counts[s[left]] == 0) counts.Remove(s[left]);
                    left++;
                }

                maxLength = Math.Max(maxLength, right - left + 1);
                right++;
            }
            return maxLength;
        }
    }
}
