//-----------------------------------------------------------------------------
// Runtime: 76ms
// Memory Usage: 25.7 MB
// Link: https://leetcode.com/submissions/detail/347341211/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _072_EditDistance
    {
        public int MinDistance(string word1, string word2)
        {
            int size1 = word1.Length + 1, size2 = word2.Length + 1;
            if (size2 > size1) { return MinDistance(word2, word1); }

            var path = new int[size2];

            int i, j, upper_left, upper;
            for (i = 0; i < size2; i++) { path[i] = i; }

            for (i = 1; i < size1; i++)
            {
                upper_left = path[0];
                path[0] = i;

                for (j = 1; j < size2; j++)
                {
                    upper = path[j];

                    if (word1[i - 1] == word2[j - 1]) { path[j] = upper_left; }
                    else
                    {
                        path[j] = Math.Min(upper_left, Math.Min(path[j], path[j - 1])) + 1;
                    }

                    upper_left = upper;
                }
            }

            return path[size2 - 1];
        }
    }
}
