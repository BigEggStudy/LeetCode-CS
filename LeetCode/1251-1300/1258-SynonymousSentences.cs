//-----------------------------------------------------------------------------
// Runtime: 284ms
// Memory Usage: 31.4 MB
// Link: https://leetcode.com/submissions/detail/368578305/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _1258_SynonymousSentences
    {
        public IList<string> GenerateSentences(IList<IList<string>> synonyms, string text)
        {
            var result = new List<string>();
            if (synonyms == null || synonyms.Count == 0) return result;

            var map = new Dictionary<string, SortedSet<string>>();

            foreach (var wordPair in synonyms)
            {
                SortedSet<string> set;
                if (map.ContainsKey(wordPair[0]))
                    set = map[wordPair[0]];
                else
                    set = new SortedSet<string>(StringComparer.Ordinal);

                set.Add(wordPair[0]);
                set.Add(wordPair[1]);
                map[wordPair[0]] = set;
                map[wordPair[1]] = set;
            }

            var words = text.Split();
            foreach (var word in words)
            {
                if (!map.ContainsKey(word))
                {
                    var set = new SortedSet<string>();
                    set.Add(word);
                    map[word] = set;
                }
            }

            var builders = new List<string>();
            DFS(words, 0, map, builders, result);
            return result;
        }

        private void DFS(string[] words, int index, Dictionary<string, SortedSet<string>> map, List<string> builders, List<string> result)
        {
            if (index == words.Length)
            {
                result.Add(string.Join(" ", builders));
                return;
            }

            foreach (var replacement in map[words[index]])
            {
                builders.Add(replacement);
                DFS(words, index + 1, map, builders, result);
                builders.RemoveAt(builders.Count - 1);
            }
        }
    }
}
