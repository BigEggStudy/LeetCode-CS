//-----------------------------------------------------------------------------
// Runtime: 112ms
// Memory Usage: 33.1 MB
// Link: https://leetcode.com/submissions/detail/351895712/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0720_LongestWordInDictionary
    {
        public string LongestWord(string[] words)
        {
            var root = new Trie() { Finished = true };
            foreach (var word in words)
            {
                var current = root;
                foreach (var ch in word)
                {
                    if (current.Children[ch - 'a'] == null)
                        current.Children[ch - 'a'] = new Trie();

                    current = current.Children[ch - 'a'];
                }

                current.Finished = true;
                current.Word = word;
            }

            var result = string.Empty;
            var stack = new Stack<Trie>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var node = stack.Pop();
                if (node.Finished)
                {
                    if (node.Word.Length >= result.Length)
                        result = node.Word;
                    for (int i = 0; i < 26; i++)
                    {
                        if (node.Children[i] != null)
                            stack.Push(node.Children[i]);
                    }
                }
            }

            return result;
        }

        public class Trie
        {
            public Trie[] Children = new Trie[26];
            public bool Finished = false;
            public string Word = string.Empty;
        }
    }
}
