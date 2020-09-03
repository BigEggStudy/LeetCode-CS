//-----------------------------------------------------------------------------
// Runtime: 112ms
// Memory Usage: 25.7 MB
// Link: https://leetcode.com/submissions/detail/352425630/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _0819_MostCommonWord
    {
        public string MostCommonWord(string paragraph, string[] banned)
        {
            var split = paragraph.Replace('!', ' ').Replace('?', ' ').Replace('\'', ' ').Replace(',', ' ').Replace(';', ' ').Replace('.', ' ').ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var bannedSet = new HashSet<string>(banned);
            var counts = new Dictionary<string, int>();
            foreach (var word in split)
            {
                if (bannedSet.Contains(word))
                    continue;
                if (counts.ContainsKey(word))
                    counts[word]++;
                else
                    counts[word] = 1;
            }

            var max = 0;
            var result = string.Empty;
            foreach (var pair in counts)
            {
                if (max < pair.Value)
                {
                    max = pair.Value;
                    result = pair.Key;
                }
            }

            return result;
        }
    }
}
