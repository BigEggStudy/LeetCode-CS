//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 25.1 MB
// Link: https://leetcode.com/submissions/detail/342528215/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0953_VerifyingAnAlienDictionary
    {
        public bool IsAlienSorted(string[] words, string order)
        {
            int[] index = new int[26];
            for (int i = 0; i < order.Length; i++)
                index[order[i] - 'a'] = i;

            for (int i = 0; i < words.Length - 1; i++)
            {
                var word1 = words[i];
                var word2 = words[i + 1];

                var skip = false;

                for (int j = 0; j < Math.Min(word1.Length, word2.Length); j++)
                {
                    if (word1[j] != word2[j])
                    {
                        if (index[word1[j] - 'a'] > index[word2[j] - 'a'])
                            return false;
                        skip = true;
                        break;
                    }
                }

                if (skip)
                    continue;

                if (word1.Length > word2.Length)
                    return false;
            }

            return true;
        }
    }
}
