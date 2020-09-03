//-----------------------------------------------------------------------------
// Runtime: 244ms
// Memory Usage: 33.3 MB
// Link: https://leetcode.com/submissions/detail/337648929/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1170_CompareStringsByFrequencyOfTheSmallestCharacter
    {
        public int[] NumSmallerByFrequency(string[] queries, string[] words)
        {
            var count = new int[12];

            foreach (var word in words)
            {
                var charCount = new int[26];
                var minChar = 26;
                foreach (var ch in word)
                {
                    var index = ch - 'a';
                    charCount[index]++;
                    if (index < minChar)
                        minChar = index;
                }
                count[charCount[minChar]]++;
            }

            for (int i = count.Length - 1; i > 0; i--)
                count[i - 1] += count[i];

            var result = new int[queries.Length];
            var queryIndex = 0;
            foreach (var query in queries)
            {
                var charCount = new int[26];
                var minChar = 26;
                foreach (var ch in query)
                {
                    var index = ch - 'a';
                    charCount[index]++;
                    if (index < minChar)
                        minChar = index;
                }

                result[queryIndex++] = count[charCount[minChar] + 1];
            }

            return result;
        }
    }
}
