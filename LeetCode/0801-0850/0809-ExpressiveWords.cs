//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0809_ExpressiveWords
    {
        public int ExpressiveWords(string S, string[] words)
        {
            (var keys, var counts) = CountString(S);

            var result = 0;
            foreach (var word in words)
            {
                (var wordKeys, var wordCounts) = CountString(word);
                if (keys.Count != wordKeys.Count) continue;

                var continueNext = false;
                for (int i = 0; i < keys.Count; i++)
                {
                    if (keys[i] != wordKeys[i] || counts[i] < wordCounts[i] || (counts[i] < 3 && counts[i] != wordCounts[i]))
                    {
                        continueNext = true;
                        break;
                    }
                }
                if (continueNext) continue;

                result++;
            }

            return result;
        }

        private (IList<char> keys, IList<int> counts) CountString(string str)
        {
            var keys = new List<char>();
            var counts = new List<int>();
            for (int i = 0; i < str.Length; i++)
            {
                var count = 1;
                while (i + 1 < str.Length && str[i] == str[i + 1])
                {
                    count++;
                    i++;
                }
                keys.Add(str[i]);
                counts.Add(count);
            }

            return (keys, counts);
        }
    }
}
