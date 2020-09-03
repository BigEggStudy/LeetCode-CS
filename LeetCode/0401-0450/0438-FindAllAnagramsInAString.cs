//-----------------------------------------------------------------------------
// Runtime: 244ms
// Memory Usage: 35.4 MB
// Link: https://leetcode.com/submissions/detail/340971330/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _0438_FindAllAnagramsInAString
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            var sLength = s.Length;
            var pLength = p.Length;

            var pCount = new int[26];
            foreach (var ch in p)
                pCount[ch - 'a']++;

            var sCount = new int[26];
            var result = new List<int>();
            for (int i = 0; i < sLength; i++)
            {
                sCount[s[i] - 'a']++;
                if (i >= pLength)
                    sCount[s[i - pLength] - 'a']--;

                if (Enumerable.SequenceEqual(sCount, pCount))
                    result.Add(i - pLength + 1);
            }

            return result;
        }
    }
}
