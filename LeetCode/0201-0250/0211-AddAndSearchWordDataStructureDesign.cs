//-----------------------------------------------------------------------------
// Runtime: 272ms
// Memory Usage: 45 MB
// Link: https://leetcode.com/submissions/detail/366155243/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0211_AddAndSearchWordDataStructureDesign
    {
        private readonly Trie root;

        /** Initialize your data structure here. */
        public _0211_AddAndSearchWordDataStructureDesign()
        {
            root = new Trie();
        }

        /** Adds a word into the data structure. */
        public void AddWord(string word)
        {
            var current = root;
            foreach (var ch in word)
            {
                if (!current.Children.ContainsKey(ch))
                    current.Children.Add(ch, new Trie());
                current = current.Children[ch];
            }

            current.Finished = true;
        }

        /** Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter. */
        public bool Search(string word)
        {
            return Search(word, root);
        }

        private bool Search(string word, Trie startPoint)
        {
            var current = startPoint;
            for (int i = 0; i < word.Length; i++)
            {
                var ch = word[i];
                if (ch == '.')
                {
                    foreach (var key in current.Children.Keys)
                    {
                        if (Search(word.Substring(i + 1), current.Children[key]))
                            return true;
                    }
                    return false;
                }
                else if (current.Children.ContainsKey(ch))
                    current = current.Children[ch];
                else
                    return false;
            }

            return current.Finished;
        }

        private class Trie
        {
            public Dictionary<char, Trie> Children = new Dictionary<char, Trie>();
            public bool Finished = false;
        }
    }

    /**
     * Your WordDictionary object will be instantiated and called as such:
     * WordDictionary obj = new WordDictionary();
     * obj.AddWord(word);
     * bool param_2 = obj.Search(word);
     */
}
