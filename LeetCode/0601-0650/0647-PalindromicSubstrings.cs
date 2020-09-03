//-----------------------------------------------------------------------------
// Runtime: 68ms
// Memory Usage: 22.1 MB
// Link: https://leetcode.com/submissions/detail/371206163/
//-----------------------------------------------------------------------------

using System;
using System.Linq;

namespace LeetCode
{
    public class _0647_PalindromicSubstrings
    {
        public int CountSubstrings(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            if (s.Length == 1) return 1;

            int n2 = s.Length * 2 + 1;
            var s2 = new char[n2];
            for (int i = 0; i < s.Length; i++)
            {
                s2[i * 2] = '#';
                s2[i * 2 + 1] = s[i];
            }
            s2[n2 - 1] = '#';

            var p = new int[n2];
            var range_max = 0;
            var center = 0;

            for (int i = 1; i < n2 - 1; i++)
            {
                if (range_max > i)
                    p[i] = Math.Min(p[center * 2 - i], range_max - i);

                while (i - 1 - p[i] >= 0 && i + 1 + p[i] < n2 && s2[i - 1 - p[i]] == s2[i + 1 + p[i]])
                    p[i]++;

                if (i + p[i] > range_max)
                {
                    range_max = i + p[i];
                    center = i;
                }
            }

            return (p.Sum() + s.Length) / 2;
        }
    }
}
