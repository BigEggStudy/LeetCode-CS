//-----------------------------------------------------------------------------
// Runtime: 108ms
// Memory Usage: 34.1 MB
// Link: https://leetcode.com/submissions/detail/343384693/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class _0451_SortCharactersByFrequency
    {
        public string FrequencySort(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return s;

            var counts = new Dictionary<char, int>();
            foreach (var ch in s)
            {
                if (!counts.ContainsKey(ch))
                    counts.Add(ch, 1);
                else
                    counts[ch]++;
            }

            var maxCount = counts.Values.Max();
            var buckets = new List<IList<char>>(maxCount + 1);
            for (int i = 0; i <= maxCount; i++)
                buckets.Add(new List<char>());
            foreach (var ch in counts.Keys)
                buckets[counts[ch]].Add(ch);

            var sb = new StringBuilder();
            for (int i = maxCount; i >= 1; i--)
                foreach (var ch in buckets[i])
                    sb.Append(ch, i);

            return sb.ToString();
        }
    }
}
