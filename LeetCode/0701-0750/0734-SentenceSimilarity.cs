//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 26.2 MB
// Link: https://leetcode.com/submissions/detail/352834208/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0734_SentenceSimilarity
    {
        public bool AreSentencesSimilar(string[] words1, string[] words2, IList<IList<string>> pairs)
        {
            if (words1.Length != words2.Length) return false;

            var map = new Dictionary<string, HashSet<string>>();
            foreach (var pair in pairs)
            {
                if (!map.ContainsKey(pair[0]))
                    map[pair[0]] = new HashSet<string>();
                if (!map.ContainsKey(pair[1]))
                    map[pair[1]] = new HashSet<string>();

                map[pair[0]].Add(pair[1]);
                map[pair[1]].Add(pair[0]);
            }

            for (int i = 0; i < words1.Length; i++)
            {
                if (words1[i] != words2[i] && (!map.ContainsKey(words1[i]) || !map[words1[i]].Contains(words2[i])))
                    return false;
            }

            return true;
        }
    }
}
