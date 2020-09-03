//-----------------------------------------------------------------------------
// Runtime: 240ms
// Memory Usage: 32 MB
// Link: https://leetcode.com/submissions/detail/360796985/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0890_FindAndReplacePattern
    {
        public IList<string> FindAndReplacePattern(string[] words, string pattern)
        {
            var result = new List<string>();
            foreach (var word in words)
                if (Match(word, pattern))
                    result.Add(word);

            return result;
        }

        private bool Match(string word, string pattern)
        {
            var map1 = new Dictionary<char, char>();
            var map2 = new Dictionary<char, char>();
            for (int i = 0; i < pattern.Length; i++)
            {
                if (!map1.ContainsKey(pattern[i]))
                    map1[pattern[i]] = word[i];
                if (!map2.ContainsKey(word[i]))
                    map2[word[i]] = pattern[i];

                if (map1[pattern[i]] != word[i] || map2[word[i]] != pattern[i])
                    return false;
            }

            return true;
        }
    }
}
