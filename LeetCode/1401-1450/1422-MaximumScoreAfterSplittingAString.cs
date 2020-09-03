//-----------------------------------------------------------------------------
// Runtime: 64ms
// Memory Usage: 22.1 MB
// Link: https://leetcode.com/submissions/detail/342552893/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1422_MaximumScoreAfterSplittingAString
    {
        public int MaxScore(string s)
        {
            var score = new int[s.Length - 1];

            int zeros = 0, ones = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == '0') zeros++;
                score[i] += zeros;

                if (s[s.Length - 1 - i] == '1') ones++;
                score[s.Length - 2 - i] += ones;
            }

            var maxScore = 0;
            for (int i = 0; i < s.Length - 1; i++)
                maxScore = Math.Max(maxScore, score[i]);

            return maxScore;
        }
    }
}
