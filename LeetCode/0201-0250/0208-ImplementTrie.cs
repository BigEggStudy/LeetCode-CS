//-----------------------------------------------------------------------------
// Runtime: 184ms
// Memory Usage: 48 MB
// Link: https://leetcode.com/submissions/detail/263024765/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0208_ImplementTrie
    {
        private Node root;

        /** Initialize your data structure here. */
        public _0208_ImplementTrie()
        {
            root = new Node();
        }

        /** Inserts a word into the trie. */
        public void Insert(string word)
        {
            var currentNode = root;

            foreach (var ch in word)
            {
                if (currentNode.Children[ch - 'a'] == null)
                    currentNode.Children[ch - 'a'] = new Node();
                currentNode = currentNode.Children[ch - 'a'];
            }

            currentNode.IsFinished = true;
        }

        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            var currentNode = root;

            foreach (var ch in word)
                if (currentNode.Children[ch - 'a'] == null)
                    return false;
                else
                    currentNode = currentNode.Children[ch - 'a'];

            return currentNode.IsFinished;
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix)
        {
            var currentNode = root;

            foreach (var ch in prefix)
                if (currentNode.Children[ch - 'a'] == null)
                    return false;
                else
                    currentNode = currentNode.Children[ch - 'a'];

            return true;
        }

        public class Node
        {
            public Node[] Children { get; } = new Node[26];

            public bool IsFinished { get; set; }
        }
    }
}
