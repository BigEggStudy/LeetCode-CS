//-----------------------------------------------------------------------------
// Runtime: 628ms
// Memory Usage: 73.8 MB
// Link: https://leetcode.com/submissions/detail/385354300/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _1032_StreamOfCharacters
    {
        private readonly Trie root;
        private readonly List<char> stream;

        public _1032_StreamOfCharacters(string[] words)
        {
            root = new Trie();
            stream = new List<char>();

            foreach (var word in words)
            {
                var current = root;
                foreach (var ch in new string(word.Reverse().ToArray()))
                {
                    if (current.Children[ch - 'a'] == null)
                        current.Children[ch - 'a'] = new Trie();
                    current = current.Children[ch - 'a'];
                }
                current.IsFinished = true;
            }
        }

        public bool Query(char letter)
        {
            stream.Add(letter);
            var current = root;

            for (int i = stream.Count - 1; i >= 0; i--)
            {
                if (current.IsFinished) return true;

                if (current.Children[stream[i] - 'a'] == null)
                    return false;

                current = current.Children[stream[i] - 'a'];
            }

            return current.IsFinished;
        }


        public class Trie
        {
            public Trie[] Children { get; } = new Trie[26];
            public bool IsFinished { get; set; }
        }
    }

    /**
     * Your StreamChecker object will be instantiated and called as such:
     * StreamChecker obj = new StreamChecker(words);
     * bool param_1 = obj.Query(letter);
     */
}
