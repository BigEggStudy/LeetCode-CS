//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 26.2 MB
// Link: https://leetcode.com/submissions/detail/336928800/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0243_ShortestWordDistance
    {
        public int ShortestDistance(string[] words, string word1, string word2)
        {
            int index1 = -1, index2 = -1;
            int distance = int.MaxValue;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == word1)
                    index1 = i;
                if (words[i] == word2)
                    index2 = i;

                if (index1 != -1 && index2 != -1)
                    distance = Math.Min(distance, Math.Abs(index2 - index1));
            }

            return distance;
        }
    }
}
