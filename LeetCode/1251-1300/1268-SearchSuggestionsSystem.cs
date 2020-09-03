//-----------------------------------------------------------------------------
// Runtime: 360ms
// Memory Usage: 50 MB
// Link: https://leetcode.com/submissions/detail/369509717/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _1268_SearchSuggestionsSystem
    {
        public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            Array.Sort(products);
            var root = new TrieNode();
            foreach (string prod in products)
            {
                var curr = root;
                foreach (char c in prod)
                {
                    if (curr.Children[c - 'a'] == null)
                        curr.Children[c - 'a'] = new TrieNode();

                    curr = curr.Children[c - 'a'];

                    if (curr.Suggestion.Count < 3)
                        curr.Suggestion.Add(prod);
                }
            }

            List<IList<string>> res = new List<IList<string>>();
            TrieNode curr2 = root;
            foreach (char c in searchWord)
            {
                if (curr2 != null)
                    curr2 = curr2.Children[c - 'a'];

                res.Add(curr2 == null ? new List<string>() : curr2.Suggestion);
            }

            return res;
        }

        private class TrieNode
        {
            public List<string> Suggestion;
            public TrieNode[] Children;

            public TrieNode()
            {
                Suggestion = new List<string>();
                Children = new TrieNode[26];
            }
        }
    }
}
