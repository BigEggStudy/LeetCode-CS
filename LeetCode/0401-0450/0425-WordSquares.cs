//-----------------------------------------------------------------------------
// Runtime: 340ms
// Memory Usage: 38.4 MB
// Link: https://leetcode.com/submissions/detail/409243426/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _0425_WordSquares
    {
        public IList<IList<string>> WordSquares(string[] words)
        {
            var root = BuildTrie(words);

            var results = new List<IList<string>>();
            foreach (var word in words)
            {
                var square = new List<string>();
                square.Add(word);
                BackTracking(1, words, root, square, results);
            }

            return results;
        }

        private void BackTracking(int step, string[] words, Trie root, List<string> square, IList<IList<string>> results)
        {
            if (step == words[0].Length)
            {
                results.Add(new List<string>(square));
                return;
            }

            var sb = new StringBuilder();
            foreach (var word in square)
                sb.Append(word[step]);

            foreach (var index in GetWordsWithPrefix(sb.ToString(), root))
            {
                square.Add(words[index]);
                BackTracking(step + 1, words, root, square, results);
                square.RemoveAt(square.Count - 1);
            }
        }

        private Trie BuildTrie(string[] words)
        {
            var root = new Trie();

            for (int i = 0; i < words.Length; i++)
            {
                var word = words[i];
                var current = root;
                foreach (var ch in word)
                {
                    if (current.Children[ch - 'a'] == null)
                        current.Children[ch - 'a'] = new Trie();
                    current = current.Children[ch - 'a'];
                    current.WordIndexes.Add(i);
                }
            }
            return root;
        }

        private IList<int> GetWordsWithPrefix(string prefix, Trie root)
        {
            var current = root;
            foreach (var ch in prefix)
            {
                if (current.Children[ch - 'a'] == null)
                    return new List<int>();
                else
                    current = current.Children[ch - 'a'];
            }

            return current.WordIndexes;
        }

        public class Trie
        {
            public Trie[] Children { get; } = new Trie[26];
            public IList<int> WordIndexes = new List<int>();
        }
    }
}
