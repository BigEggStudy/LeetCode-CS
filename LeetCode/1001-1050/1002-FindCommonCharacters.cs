//-----------------------------------------------------------------------------
// Runtime: 232ms
// Memory Usage: 32.2 MB
// Link: https://leetcode.com/submissions/detail/330724785/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _1002_FindCommonCharacters
    {
        public IList<string> CommonChars(string[] A)
        {
            var current = new int[26];
            for (int i = 0; i < 26; i++)
                current[i] = int.MaxValue;

            foreach (var word in A)
            {
                var temp = new int[26];
                foreach (var ch in word)
                    temp[ch - 'a']++;

                for (int i = 0; i < 26; i++)
                    current[i] = Math.Min(current[i], temp[i]);
            }

            var result = new List<string>();
            for (int i = 0; i < 26; i++)
            {
                while (current[i]-- > 0)
                    result.Add(((char)('a' + i)).ToString());
            }

            return result;
        }
    }
}
