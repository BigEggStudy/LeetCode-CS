//-----------------------------------------------------------------------------
// Runtime: 72ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0159_LongestSubstringWithAtMostTwoDistinctCharacters
    {
        public int LengthOfLongestSubstringTwoDistinct(string s)
        {
            char p1 = (char)0;
            int p1Size = 0;
            char p2 = (char)0;
            int p2Size = 0;

            int max = 0;

            foreach (var ch in s)
            {
                if (p2 == (char)0)
                {
                    p2 = ch;
                    p2Size = 1;
                }
                else if (p2 == ch)
                {
                    p2Size++;
                }
                else if (p1 == ch)
                {
                    p1 = p2;
                    p1Size += p2Size;
                    p2 = ch;
                    p2Size = 1;
                }
                else
                {
                    p1 = p2;
                    p1Size = p2Size;
                    p2 = ch;
                    p2Size = 1;
                }

                max = Math.Max(max, p1Size + p2Size);
            }

            return max;
        }
    }
}
