//-----------------------------------------------------------------------------
// Runtime: 80ms
// Memory Usage: 23.4 MB
// Link: https://leetcode.com/submissions/detail/378104683/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _005_LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s) || s.Length == 1) return s;

            int n2 = s.Length * 2 + 1;
            var s2 = new char[n2];
            for (int i = 0; i < s.Length; i++)
            {
                s2[i * 2] = '#';
                s2[i * 2 + 1] = s[i];
            }
            s2[n2 - 1] = '#';

            var p = new int[n2];
            int rangeMax = 0, center = 0;
            var longestCenter = 0;

            for (int i = 1; i < n2 - 1; i++)
            {
                if (rangeMax > i)
                    p[i] = Math.Min(p[center * 2 - i], rangeMax - i);

                while (i - 1 - p[i] >= 0 && i + 1 + p[i] < n2 && s2[i - 1 - p[i]] == s2[i + 1 + p[i]])
                    p[i]++;

                if (i + p[i] > rangeMax)
                {
                    center = i;
                    rangeMax = i + p[i];
                }

                if (p[i] > p[longestCenter])
                    longestCenter = i;
            }

            var range = p[longestCenter];
            return s.Substring((longestCenter - range) / 2, range);
        }
    }
}
