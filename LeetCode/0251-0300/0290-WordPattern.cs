//-----------------------------------------------------------------------------
// Runtime: 68ms
// Memory Usage: 21.9 MB
// Link: https://leetcode.com/submissions/detail/358739161/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0290_WordPattern
    {
        public bool WordPattern(string pattern, string str)
        {
            var words = str.Split();
            if (words.Length != pattern.Length) return false;

            var map1 = new Dictionary<char, string>();
            var map2 = new Dictionary<string, char>();
            for (int i = 0; i < pattern.Length; i++)
            {
                var ch = pattern[i];
                if (map1.ContainsKey(ch))
                {
                    if (map1[ch] != words[i])
                        return false;
                }
                else
                    map1[ch] = words[i];

                if (map2.ContainsKey(words[i]))
                {
                    if (map2[words[i]] != ch)
                        return false;
                }
                else
                    map2[words[i]] = ch;
            }

            return true;
        }
    }
}
