//-----------------------------------------------------------------------------
// Runtime: 272ms
// Memory Usage: 33.9 MB
// Link: https://leetcode.com/submissions/detail/365321159/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _0692_TopKFrequentWords
    {
        public IList<string> TopKFrequent(string[] words, int k)
        {
            var counts = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (!counts.ContainsKey(word))
                    counts[word] = 1;
                else
                    counts[word]++;
            }

            var heap = new SortedDictionary<(string word, int count), int>(Comparer<(string word, int count)>.Create((a, b) =>
            {
                var result = a.count.CompareTo(b.count);
                if (result == 0)
                    result = -a.word.CompareTo(b.word);
                return result;
            }));

            foreach (var word in counts.Keys)
            {
                heap[(word, counts[word])] = 1;
                if (heap.Count > k)
                    heap.Remove(heap.Keys.First());
            }

            var results = new List<string>();
            foreach ((string word, int count) in heap.Keys)
                results.Add(word);

            results.Reverse();
            return results;
        }
    }
}
