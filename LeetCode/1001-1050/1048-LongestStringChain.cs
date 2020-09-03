//-----------------------------------------------------------------------------
// Runtime: 216ms
// Memory Usage: 31.5 MB
// Link: https://leetcode.com/submissions/detail/372933116/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _1048_LongestStringChain
    {
        public int LongestStrChain(string[] words)
        {
            var chainLength = new Dictionary<string, int>();
            var set = new HashSet<string>(words);

            int max = 0;
            foreach (var word in words)
            {
                DFS(word, set, chainLength);
                max = Math.Max(max, chainLength[word]);
            }
            return max;
        }

        private int DFS(string word, HashSet<string> set, Dictionary<string, int> chainLength)
        {
            if (string.IsNullOrEmpty(word) || !set.Contains(word)) return 0;
            if (chainLength.ContainsKey(word)) return chainLength[word];

            var sb = new StringBuilder(word);
            var max = 0;
            for (int i = 0; i < word.Length; i++)
            {
                var ch = sb[i];

                sb.Remove(i, 1);
                max = Math.Max(max, DFS(sb.ToString(), set, chainLength) + 1);
                sb.Insert(i, ch);
            }

            chainLength[word] = max;
            return max;
        }
    }
}
