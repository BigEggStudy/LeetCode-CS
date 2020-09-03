//-----------------------------------------------------------------------------
// Runtime: 72ms
// Memory Usage: 23 MB
// Link: https://leetcode.com/submissions/detail/340979348/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1446_ConsecutiveCharacters
    {
        public int MaxPower(string s)
        {
            var current = s[0];
            var maxLength = 1;
            var length = 1;

            for (int i = 1; i < s.Length; i++)
            {
                if (current == s[i])
                {
                    length++;
                    maxLength = Math.Max(maxLength, length);
                }
                else
                {
                    length = 1;
                    current = s[i];
                }
            }

            return maxLength;
        }
    }
}
