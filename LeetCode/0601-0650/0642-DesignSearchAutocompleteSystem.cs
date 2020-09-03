//-----------------------------------------------------------------------------
// Runtime: 820ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class _0642_DesignSearchAutocompleteSystem
    {
        private readonly Trie dummyHeader = new Trie();
        private Trie currentNode;
        private StringBuilder currentString;

        public _0642_DesignSearchAutocompleteSystem(string[] sentences, int[] times)
        {
            for (int i = 0; i < sentences.Length; i++)
            {
                var node = dummyHeader;

                foreach (var ch in sentences[i])
                {
                    var index = ch == ' ' ? 26 : ch - 'a';
                    if (node.Children[index] == null)
                        node.Children[index] = new Trie(node);

                    node = node.Children[index];
                }

                UpdateSentenceCount(node, sentences[i], times[i]);
            }

            currentNode = dummyHeader;
            currentString = new StringBuilder();
        }

        public IList<string> Input(char c)
        {
            IList<string> result = null;

            if (c == '#')
            {
                result = new List<string>();
                UpdateSentenceCount(currentNode, currentString.ToString());
                currentNode = dummyHeader;
                currentString.Clear();
            }
            else
            {
                currentString.Append(c);

                var index = c == ' ' ? 26 : c - 'a';
                if (currentNode.Children[index] == null)
                    currentNode.Children[index] = new Trie(currentNode);

                currentNode = currentNode.Children[index];
                result = currentNode.SentenceMap.OrderByDescending(p => p.Value).ThenBy(p => p.Key).Take(3).Select(p => p.Key).ToList();
            }

            return result;
        }

        private void UpdateSentenceCount(Trie node, string sentence, int count = 1)
        {
            while (node != null)
            {
                if (node.SentenceMap.ContainsKey(sentence))
                    node.SentenceMap[sentence] += count;
                else
                    node.SentenceMap.Add(sentence, count);

                node = node.Parent;
            }
        }
        public class Trie
        {
            public Trie(Trie parent = null)
            {
                Children = new Trie[27];
                Parent = parent;
                SentenceMap = new Dictionary<string, int>();
            }

            public Trie[] Children { get; private set; }

            public Trie Parent { get; set; }

            public IDictionary<string, int> SentenceMap { get; private set; }
        }
    }
}
