//-----------------------------------------------------------------------------
// Runtime: 576ms
// Memory Usage: 48.9 MB
// Link: https://leetcode.com/submissions/detail/365358654/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0472_ConcatenatedWords
    {
        public IList<string> FindAllConcatenatedWordsInADict(string[] words)
        {
            var set = new HashSet<string>(words);
            var result = new List<string>();

            foreach (var word in words)
            {
                set.Remove(word);
                if (DFS(word, set))
                    result.Add(word);
                set.Add(word);
            }

            return result;
        }

        private bool DFS(string word, HashSet<string> set)
        {
            if (set.Contains(word)) return true;

            for (int i = word.Length - 1; i > 0; i--)
            {
                var str = word.Substring(0, i);
                if (set.Contains(str) && DFS(word.Substring(i), set)) return true;
            }
            return false;
        }
    }
}
