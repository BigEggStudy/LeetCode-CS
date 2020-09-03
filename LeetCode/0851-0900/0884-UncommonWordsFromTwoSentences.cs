//-----------------------------------------------------------------------------
// Runtime: 232ms
// Memory Usage: 31.7 MB
// Link: https://leetcode.com/submissions/detail/335023222/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _0884_UncommonWordsFromTwoSentences
    {
        public string[] UncommonFromSentences(string A, string B)
        {
            var counts = new Dictionary<string, int>();
            foreach (var word in A.Split())
                if (counts.ContainsKey(word))
                    counts[word]++;
                else
                    counts[word] = 1;

            foreach (var word in B.Split())
                if (counts.ContainsKey(word))
                    counts[word]++;
                else
                    counts[word] = 1;

            return counts.Where(p => p.Value == 1).Select(p => p.Key).ToArray();
        }
    }
}
