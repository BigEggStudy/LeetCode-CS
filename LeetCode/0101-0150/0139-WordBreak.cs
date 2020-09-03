//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 24.4 MB
// Link: https://leetcode.com/submissions/detail/378107269/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _0139_WordBreak
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            int minLength = int.MaxValue, maxLength = int.MinValue;
            var map = new HashSet<string>();
            foreach (var item in wordDict)
            {
                map.Add(item);
                maxLength = Math.Max(maxLength, item.Length);
                minLength = Math.Min(minLength, item.Length);
            }

            var dp = new bool[s.Length];
            var index = 0;
            while (index < s.Length)
            {
                for (int length = minLength; index + length <= s.Length && length <= maxLength; length++)
                    if (map.Contains(s.Substring(index, length)))
                        dp[index + length - 1] = true;

                var j = index;
                var found = false;
                while (j < s.Length)
                    if (dp[j++])
                    {
                        index = j;
                        found = true;
                        break;
                    }

                if (!found) return false;
            }

            return dp[s.Length - 1];
        }
    }
}
