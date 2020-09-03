//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 22.5 MB
// Link: https://leetcode.com/submissions/detail/379101868/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0767_ReorganizeString
    {
        public string ReorganizeString(string S)
        {
            var counts = new int[26];
            foreach (var ch in S)
                counts[ch - 'a']++;

            var pairs = new (char ch, int count)[26];
            for (int i = 0; i < 26; i++)
                pairs[i] = ((char)('a' + i), counts[i]);
            Array.Sort(pairs, (p1, p2) => p2.count.CompareTo(p1.count));

            if (pairs[0].count > (S.Length + 1) / 2) return string.Empty;

            var result = new char[S.Length];
            var index = 0;
            foreach ((var ch, var count) in pairs)
            {
                if (count == 0) break;

                for (int i = 0; i < count; i++)
                {
                    result[index] = ch;
                    index += 2;
                    if (index >= S.Length) index = 1;
                }
            }

            return new string(result);
        }
    }
}
