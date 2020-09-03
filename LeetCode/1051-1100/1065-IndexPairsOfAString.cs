//-----------------------------------------------------------------------------
// Runtime: 240ms
// Memory Usage: 32.4 MB
// Link: https://leetcode.com/submissions/detail/336996248/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1065_IndexPairsOfAString
    {
        public int[][] IndexPairs(string text, string[] words)
        {
            var trie = new Trie();

            foreach (var word in words)
            {
                var current = trie;
                foreach (var ch in word)
                {
                    if (current[ch] == null)
                        current[ch] = new Trie();
                    current = current[ch];
                }
                current.End = true;
            }

            var result = new List<int[]>();
            for (int left = 0; left < text.Length; left++)
            {
                var current = trie;
                for (int right = left; right < text.Length; right++)
                {
                    var ch = text[right];
                    if (current[ch] == null)
                        break;

                    current = current[ch];
                    if (current.End)
                        result.Add(new int[] { left, right });
                }
            }

            return result.ToArray();
        }
    }


    public class Trie
    {
        private IDictionary<char, Trie> list = new Dictionary<char, Trie>();

        public Trie this[char key]
        {
            get
            {
                if (!list.ContainsKey(key))
                    return null;
                return list[key];
            }
            set { list[key] = value; }
        }

        public bool End { get; set; }
    }
}
