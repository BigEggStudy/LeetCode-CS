//-----------------------------------------------------------------------------
// Runtime: 232ms
// Memory Usage: 30.7 MB
// Link: https://leetcode.com/submissions/detail/333630822/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1078_OccurrencesAfterBigram
    {
        public string[] FindOcurrences(string text, string first, string second)
        {
            var words = text.Split();

            var results = new List<string>();
            for (int i = 0; i < words.Length - 2; i++)
            {
                if (words[i] == first && words[i + 1] == second)
                    results.Add(words[i + 2]);
            }

            return results.ToArray();
        }
    }
}
